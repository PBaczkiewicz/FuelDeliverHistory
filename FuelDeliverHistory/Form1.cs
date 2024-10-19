using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FuelDeliverHistory
{
    public partial class Form1 : Form
    {
        public List<Dostawy> listaDostaw = new List<Dostawy>();
        public Auto auto = new Auto();

        #region Moduł Dostaw
        //inicjalizuje formularz i ustawia bieżącą datę w okienku wyboru daty
        public Form1()
        {
            InitializeComponent();
            OdczytDanych(ref listaDostaw);
            AktualizacjaListy(listaDostaw);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yy HH:mm";
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, 0, dateTimePicker1.Value.Kind);

        }
        //moduł wyświetlający zapisane dostawy w liście w dataGridView
        public void AktualizacjaListy(List<Dostawy> listaDostaw)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            listaDostaw = listaDostaw.OrderBy(DateTime => DateTime.data).ToList();
            Dostawy dostawy = new Dostawy();
            for (int i = 0; i < listaDostaw.Count; i++)
            {
                dataGridView.Rows.Add();
                //string napis;
                dostawy = listaDostaw[i];
                dataGridView.Rows[i].Cells[0].Value = dostawy.data;
                dataGridView.Rows[i].Cells[1].Value = dostawy.iloscPaliwa;
                dataGridView.Rows[i].Cells[2].Value = dostawy.nettoLitr;
                dataGridView.Rows[i].Cells[3].Value = dostawy.bruttoLitr;
                dataGridView.Rows[i].Cells[4].Value = dostawy.cenaNetto;
                dataGridView.Rows[i].Cells[5].Value = dostawy.cenaBrutto;
                dataGridView.Rows[i].Cells[6].Value = dostawy.dostawca;
                dataGridView.Rows[i].Cells[7].Value = dostawy.uwagi;
                #region old version
                //napis = listaDostaw[i - 1].data.ToString();
                //napis = napis.Substring(0, napis.Length - 3);
                //napis += "  |  " + listaDostaw[i - 1].iloscPaliwa.ToString();
                //napis += "  |  " + listaDostaw[i - 1].nettoLitr.ToString();
                //napis += "  |  " + listaDostaw[i - 1].bruttoLitr.ToString();
                //napis += "  |  ";
                //if (listaDostaw[i - 1].cenaNetto < 10000)
                //{
                //    napis += "  ";
                //}
                //napis += listaDostaw[i - 1].cenaNetto.ToString();
                //napis += "  |  ";
                //if (listaDostaw[i - 1].cenaNetto < 10000)
                //{
                //    napis += "  ";
                //}
                //napis += listaDostaw[i - 1].cenaBrutto.ToString();
                //napis += "  ||  " + listaDostaw[i - 1].dostawca;
                //napis += "  ||  " + listaDostaw[i - 1].uwagi;
                //checkedListBox1.Items.Add(napis);
                #endregion
                dataGridView.Sort(dataGridView.Columns["DataDostawy"], ListSortDirection.Descending);

            }
            int amount = 0, weight = 0;
            double nettoL = 0, bruttoL = 0, nettoTotal = 0, bruttoTotal = 0, wNettoL = 0, wBruttoL = 0;
            List<double> nettoList = new List<double>();
            List<double> bruttoList = new List<double>();
            List<double> wNettoList = new List<double>();
            List<double> wBruttoList = new List<double>();
            for (int i = 0; i < listaDostaw.Count; i++)
            {
                dostawy = listaDostaw[i];
                amount += dostawy.iloscPaliwa;
                weight += dostawy.iloscPaliwa;
                wNettoList.Add(dostawy.nettoLitr * dostawy.iloscPaliwa);
                nettoList.Add(dostawy.nettoLitr);
                wBruttoList.Add(dostawy.bruttoLitr * dostawy.iloscPaliwa);
                bruttoList.Add(dostawy.bruttoLitr);
                nettoTotal += dostawy.cenaNetto;
                bruttoTotal += dostawy.cenaBrutto;
            }
            nettoL = nettoList.Average();
            bruttoL = bruttoList.Average();
            wNettoL = wNettoList.Sum() / weight;
            wBruttoL = wBruttoList.Sum() / weight;
            textBoxWNetto.Text = wNettoL.ToString().Substring(0, 4);
            textBoxWBrutto.Text = wBruttoL.ToString().Substring(0, 4);
            textBoxAmount.Text = amount.ToString();
            textBoxNettoL.Text = nettoL.ToString().Substring(0, 4);
            textBoxBruttoL.Text = bruttoL.ToString().Substring(0, 4);
            textBoxNettoTotal.Text = nettoTotal.ToString();
            textBoxBruttoTotal.Text = bruttoTotal.ToString();
        }
        //zapisuje listę do JSON'a
        static public void ZapisDanych(List<Dostawy> listaDostaw)
        {
            string jsonString = JsonConvert.SerializeObject(listaDostaw);
            System.IO.File.WriteAllText("data.json", jsonString);
        }
        //wczytuje dane z JSON'a
        static public void OdczytDanych(ref List<Dostawy> listaDostaw)
        {

            string jsonString = System.IO.File.ReadAllText("data.json");
            listaDostaw = JsonConvert.DeserializeObject<List<Dostawy>>(jsonString);

        }
        //Przycisk usuwający wpis z listy i podglądu
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count == 0)
            {
                // No cells are selected
                MessageBox.Show("Brak wybranych pozycji do usunięcia!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć ten wpis?", "Uwaga!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowIndex = dataGridView.CurrentCell.RowIndex;
                    DateTime deletedDate = new DateTime();
                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        deletedDate = (DateTime)dataGridView.Rows[rowIndex].Cells["DataDostawy"].Value;
                        //dataGridView.Rows.RemoveAt(rowIndex);
                    }
                    if (deletedDate != null)
                    {
                        listaDostaw.RemoveAll(obj => obj.data == deletedDate);
                    }
                    AktualizacjaListy(listaDostaw);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                ZapisDanych(listaDostaw);
            }
        }
        //Przycisk dodający wpis do listy i podglądu
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dostawy dostawa = new Dostawy();
            try { dostawa.data = dateTimePicker1.Value; }
            catch { MessageBox.Show("Brak wprowadzonej daty!", "Błąd!"); return; }
            try { dostawa.iloscPaliwa = int.Parse(iloscLitrow.Text); }
            catch { MessageBox.Show("Brak podanych litrów!", "Błąd!"); return; }
            try { dostawa.nettoLitr = double.Parse(nettoLitr.Text); }
            catch { MessageBox.Show("Brak podanej ceny netto za litr!", "Błąd!"); return; }
            dostawa.cenaNetto = dostawa.iloscPaliwa * dostawa.nettoLitr;
            try { dostawa.bruttoLitr = double.Parse(bruttoLitr.Text); }
            catch { MessageBox.Show("Brak podanej ceny brutto za litr!", "Błąd!"); return; }
            dostawa.cenaBrutto = dostawa.iloscPaliwa * dostawa.bruttoLitr;
            try { dostawa.dostawca = dostawca.Text; }
            catch { MessageBox.Show("Brak podanego dostawcy!", "Błąd!"); return; }
            try { dostawa.uwagi = uwagi.Text; }
            catch { dostawa.uwagi = "-BRAK-"; }
            listaDostaw.Add(dostawa);

            AktualizacjaListy(listaDostaw);
            ZapisDanych(listaDostaw);
            MessageBox.Show("Dodano nowy wpis!");

        }
        #endregion

        #region Zaprogramowanie przycisków itp.
        //Lista wyboru pojazdu
        private void comboBoxTruck_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto.calculation = new Auto.Calculation();
            auto = new Auto();
            string filePath = "Auta\\" + comboBoxTruck.Text + ".json";
            string jsonAuto;
            if (!File.Exists(filePath))
            {
                auto.registration = comboBoxTruck.Text;
                jsonAuto = JsonConvert.SerializeObject(auto);
                System.IO.File.WriteAllText(filePath, jsonAuto);
            }
            else
            {
                jsonAuto = System.IO.File.ReadAllText(filePath);
                auto = JsonConvert.DeserializeObject<Auto>(jsonAuto);
            }
            LoadHistory();

        }
        //Zapisanie danych z wyliczeń
        public void SaveTruck()
        {
            string filePath = "Auta\\" + comboBoxTruck.Text + ".json";
            string jsonAuto = JsonConvert.SerializeObject(auto);
            System.IO.File.WriteAllText(filePath, jsonAuto);
        }
        //Wczytywanie danych porzednio zapisanych
        public void LoadHistory()
        {
            textBoxStartKM.Text = ""; textBoxEndKM.Text = ""; textBoxFuel.Text = "";
            checkedListBox1.Items.Clear();
            float totalFuelSpent = 0;
            auto.CalculationList = auto.CalculationList.OrderByDescending(DateTime => DateTime.dateTo).ToList();
            if (comboBoxTruck.Text != "")
            {
                foreach (Auto.Calculation calc in auto.CalculationList)
                {
                    string formattedDate = calc.dateFrom.ToString("dd/MM/yyyy"); string formattedDate2 = calc.dateTo.ToString("dd/MM/yyyy");
                    checkedListBox1.Items.Add(calc.fromKM + " -> " + calc.toKM + " = " + (calc.toKM - calc.fromKM) + " KM  Średnio " + calc.avgFuelSpent.ToString("0.00") + "/100 KM. Data pomiaru :" + formattedDate + " -> " + formattedDate2);
                    totalFuelSpent += calc.avgFuelSpent;
                }
                textBoxTotalAverage.Text = (totalFuelSpent / auto.CalculationList.Count).ToString();
                if (auto.CalculationList.Count > 0)
                {
                    textBoxStartKM.Text = auto.CalculationList[0].toKM.ToString();
                }
            }
        }
        //Przycisk dodający wpis
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            auto.calculation = new Auto.Calculation();
            if (auto.CalculationList.Count > 0)
            {
                dateTime = auto.CalculationList[0].dateTo;
            }
            else
            {
                dateTime = DateTime.Now;
            }
            Form2 form = new Form2(auto.calculation, dateTime);
            if (form.ShowDialog() == DialogResult.OK)
            {
                auto.calculation = form.calc;
            }
            else
            {
                return;
            }
            auto.calculation.fromKM = int.Parse(textBoxStartKM.Text);
            auto.calculation.toKM = int.Parse(textBoxEndKM.Text);
            auto.calculation.avgFuelSpent = float.Parse(textBoxAverage.Text);
            auto.CalculationList.Add(auto.calculation);
            auto.calculation = new Auto.Calculation();
            SaveTruck();
            LoadHistory();
            textBoxAverage.Text = "";
        }
        //Automatyczne wyliczanie średniej
        private void textBoxStartKM_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStartKM.Text != "" && textBoxEndKM.Text != "" && textBoxFuel.Text != "" && int.Parse(textBoxStartKM.Text) < int.Parse(textBoxEndKM.Text))
            {
                textBoxAverage.Text = (float.Parse(textBoxFuel.Text) / (float.Parse(textBoxEndKM.Text) - float.Parse(textBoxStartKM.Text)) * 100).ToString();
                buttonCalculate.Enabled = true; ;
            }
            else
            {
                buttonCalculate.Enabled = false;
            }

        }
        //Usuwanie danych
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Brak zaznaczonych pozycji do usunięcia!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć ten zapis?", "Uwaga!", MessageBoxButtons.YesNo);
                int removed = 0;
                if (dialogResult == DialogResult.Yes)
                {

                    List<int> checkedIndices = new List<int>();
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            checkedIndices.Add(i);
                            auto.CalculationList.RemoveAt(i - removed);
                            removed++;
                        }
                    }

                    for (int i = checkedIndices.Count - 1; i >= 0; i--)
                    {
                        checkedListBox1.Items.RemoveAt(checkedIndices[i]);

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                SaveTruck();
                LoadHistory();
            }
        }
        #endregion

        #region Kontrola wprowadzania danych
        private void iloscLitrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void nettoLitr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if ((nettoLitr.Text.Contains(',') && (e.KeyChar == '.' || e.KeyChar == ',')) || nettoLitr.Text == "" && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                return;
            }
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        private void bruttoLitr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if ((bruttoLitr.Text.Contains(',') && (e.KeyChar == '.' || e.KeyChar == ',')) || bruttoLitr.Text == "" && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                return;
            }
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        private void nettoLitr_KeyUp(object sender, KeyEventArgs e)
        {
            if (nettoLitr.Text.Count() > 0)
            {
                bruttoLitr.Text = Math.Round(double.Parse(nettoLitr.Text) * ((double.Parse(numericUpDown1.Text) / 100) + 1), 2).ToString();
            }
            else
            {
                bruttoLitr.Text = "";
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (nettoLitr.Text.Count() > 0)
            {
                bruttoLitr.Text = Math.Round(double.Parse(nettoLitr.Text) * ((double.Parse(numericUpDown1.Text) / 100) + 1), 2).ToString();
            }
        }
        private void textBoxStartKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}

