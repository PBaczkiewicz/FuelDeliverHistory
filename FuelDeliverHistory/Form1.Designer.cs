namespace FuelDeliverHistory
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.iloscLitrow = new System.Windows.Forms.TextBox();
            this.nettoLitr = new System.Windows.Forms.TextBox();
            this.bruttoLitr = new System.Windows.Forms.TextBox();
            this.dostawca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uwagi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DataDostawy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxNettoL = new System.Windows.Forms.TextBox();
            this.textBoxBruttoL = new System.Windows.Forms.TextBox();
            this.textBoxNettoTotal = new System.Windows.Forms.TextBox();
            this.textBoxBruttoTotal = new System.Windows.Forms.TextBox();
            this.textBoxWNetto = new System.Windows.Forms.TextBox();
            this.textBoxWBrutto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStartKM = new System.Windows.Forms.TextBox();
            this.textBoxEndKM = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.comboBoxTruck = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxTotalAverage = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 260);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(598, 391);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data";
            // 
            // iloscLitrow
            // 
            this.iloscLitrow.Location = new System.Drawing.Point(727, 287);
            this.iloscLitrow.Name = "iloscLitrow";
            this.iloscLitrow.Size = new System.Drawing.Size(200, 20);
            this.iloscLitrow.TabIndex = 14;
            this.iloscLitrow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iloscLitrow_KeyPress);
            // 
            // nettoLitr
            // 
            this.nettoLitr.Location = new System.Drawing.Point(727, 313);
            this.nettoLitr.Name = "nettoLitr";
            this.nettoLitr.Size = new System.Drawing.Size(200, 20);
            this.nettoLitr.TabIndex = 15;
            this.nettoLitr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nettoLitr_KeyPress);
            this.nettoLitr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nettoLitr_KeyUp);
            // 
            // bruttoLitr
            // 
            this.bruttoLitr.Location = new System.Drawing.Point(727, 339);
            this.bruttoLitr.Name = "bruttoLitr";
            this.bruttoLitr.Size = new System.Drawing.Size(200, 20);
            this.bruttoLitr.TabIndex = 16;
            this.bruttoLitr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bruttoLitr_KeyPress);
            // 
            // dostawca
            // 
            this.dostawca.Location = new System.Drawing.Point(727, 365);
            this.dostawca.Name = "dostawca";
            this.dostawca.Size = new System.Drawing.Size(200, 20);
            this.dostawca.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ilość litrów";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Netto/litr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Brutto/litr";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(661, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Dostawca";
            // 
            // uwagi
            // 
            this.uwagi.Location = new System.Drawing.Point(727, 391);
            this.uwagi.Name = "uwagi";
            this.uwagi.Size = new System.Drawing.Size(200, 20);
            this.uwagi.TabIndex = 22;
            this.uwagi.Text = "-BRAK-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(679, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Uwagi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(595, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "VAT";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(629, 340);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataDostawy,
            this.Ilosc,
            this.nettol,
            this.bruttol,
            this.netto,
            this.brutto,
            this.deliver,
            this.info});
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle64;
            this.dataGridView.Location = new System.Drawing.Point(12, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(916, 251);
            this.dataGridView.TabIndex = 28;
            // 
            // DataDostawy
            // 
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.DataDostawy.DefaultCellStyle = dataGridViewCellStyle58;
            this.DataDostawy.HeaderText = "Data dostawy";
            this.DataDostawy.Name = "DataDostawy";
            this.DataDostawy.ReadOnly = true;
            this.DataDostawy.Width = 140;
            // 
            // Ilosc
            // 
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Ilosc.DefaultCellStyle = dataGridViewCellStyle59;
            this.Ilosc.HeaderText = "Ilość";
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            this.Ilosc.Width = 45;
            // 
            // nettol
            // 
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nettol.DefaultCellStyle = dataGridViewCellStyle60;
            this.nettol.HeaderText = "Netto/litr";
            this.nettol.Name = "nettol";
            this.nettol.ReadOnly = true;
            this.nettol.Width = 70;
            // 
            // bruttol
            // 
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.bruttol.DefaultCellStyle = dataGridViewCellStyle61;
            this.bruttol.HeaderText = "Brutto/litr";
            this.bruttol.Name = "bruttol";
            this.bruttol.ReadOnly = true;
            this.bruttol.Width = 70;
            // 
            // netto
            // 
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.netto.DefaultCellStyle = dataGridViewCellStyle62;
            this.netto.HeaderText = "Cena netto";
            this.netto.Name = "netto";
            this.netto.ReadOnly = true;
            this.netto.Width = 65;
            // 
            // brutto
            // 
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.brutto.DefaultCellStyle = dataGridViewCellStyle63;
            this.brutto.HeaderText = "Cena brutto";
            this.brutto.Name = "brutto";
            this.brutto.ReadOnly = true;
            this.brutto.Width = 65;
            // 
            // deliver
            // 
            this.deliver.HeaderText = "Dostawca";
            this.deliver.Name = "deliver";
            this.deliver.ReadOnly = true;
            this.deliver.Width = 120;
            // 
            // info
            // 
            this.info.HeaderText = "Uwagi";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(192, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Łącznie\r\nlitrów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(244, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Średnia cena\r\nnetto/litr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(315, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Średnia cena\r\nbrutto/litr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(382, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "Łącznie netto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(445, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "Łącznie brutto";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(185, 256);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(53, 20);
            this.textBoxAmount.TabIndex = 34;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNettoL
            // 
            this.textBoxNettoL.Location = new System.Drawing.Point(237, 256);
            this.textBoxNettoL.Name = "textBoxNettoL";
            this.textBoxNettoL.ReadOnly = true;
            this.textBoxNettoL.Size = new System.Drawing.Size(72, 20);
            this.textBoxNettoL.TabIndex = 35;
            this.textBoxNettoL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBruttoL
            // 
            this.textBoxBruttoL.Location = new System.Drawing.Point(309, 256);
            this.textBoxBruttoL.Name = "textBoxBruttoL";
            this.textBoxBruttoL.ReadOnly = true;
            this.textBoxBruttoL.Size = new System.Drawing.Size(69, 20);
            this.textBoxBruttoL.TabIndex = 36;
            this.textBoxBruttoL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNettoTotal
            // 
            this.textBoxNettoTotal.Location = new System.Drawing.Point(379, 256);
            this.textBoxNettoTotal.Name = "textBoxNettoTotal";
            this.textBoxNettoTotal.ReadOnly = true;
            this.textBoxNettoTotal.Size = new System.Drawing.Size(66, 20);
            this.textBoxNettoTotal.TabIndex = 37;
            this.textBoxNettoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBruttoTotal
            // 
            this.textBoxBruttoTotal.Location = new System.Drawing.Point(442, 256);
            this.textBoxBruttoTotal.Name = "textBoxBruttoTotal";
            this.textBoxBruttoTotal.ReadOnly = true;
            this.textBoxBruttoTotal.Size = new System.Drawing.Size(66, 20);
            this.textBoxBruttoTotal.TabIndex = 38;
            this.textBoxBruttoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWNetto
            // 
            this.textBoxWNetto.Location = new System.Drawing.Point(237, 302);
            this.textBoxWNetto.Name = "textBoxWNetto";
            this.textBoxWNetto.ReadOnly = true;
            this.textBoxWNetto.Size = new System.Drawing.Size(72, 20);
            this.textBoxWNetto.TabIndex = 39;
            this.textBoxWNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWBrutto
            // 
            this.textBoxWBrutto.Location = new System.Drawing.Point(309, 302);
            this.textBoxWBrutto.Name = "textBoxWBrutto";
            this.textBoxWBrutto.ReadOnly = true;
            this.textBoxWBrutto.Size = new System.Drawing.Size(69, 20);
            this.textBoxWBrutto.TabIndex = 40;
            this.textBoxWBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(244, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Śr. waż cena\r\nnetto/litr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(310, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Śr. waż. cena\r\nbrutto/litr";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBoxTotalAverage);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBoxAverage);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBoxTruck);
            this.groupBox1.Controls.Add(this.textBoxFuel);
            this.groupBox1.Controls.Add(this.textBoxEndKM);
            this.groupBox1.Controls.Add(this.textBoxStartKM);
            this.groupBox1.Location = new System.Drawing.Point(12, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 163);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyliczanie spalania";
            // 
            // textBoxStartKM
            // 
            this.textBoxStartKM.Location = new System.Drawing.Point(110, 49);
            this.textBoxStartKM.Name = "textBoxStartKM";
            this.textBoxStartKM.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartKM.TabIndex = 44;
            this.textBoxStartKM.TextChanged += new System.EventHandler(this.textBoxStartKM_TextChanged);
            this.textBoxStartKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartKM_KeyPress);
            // 
            // textBoxEndKM
            // 
            this.textBoxEndKM.Location = new System.Drawing.Point(110, 75);
            this.textBoxEndKM.Name = "textBoxEndKM";
            this.textBoxEndKM.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndKM.TabIndex = 45;
            this.textBoxEndKM.TextChanged += new System.EventHandler(this.textBoxStartKM_TextChanged);
            this.textBoxEndKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartKM_KeyPress);
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(110, 101);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuel.TabIndex = 46;
            this.textBoxFuel.TextChanged += new System.EventHandler(this.textBoxStartKM_TextChanged);
            this.textBoxFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartKM_KeyPress);
            // 
            // comboBoxTruck
            // 
            this.comboBoxTruck.FormattingEnabled = true;
            this.comboBoxTruck.Items.AddRange(new object[] {
            "PSR97L8",
            "PSR99R4",
            "PSR99F4",
            "PSR5X99",
            "PSR9H53"});
            this.comboBoxTruck.Location = new System.Drawing.Point(109, 24);
            this.comboBoxTruck.Name = "comboBoxTruck";
            this.comboBoxTruck.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTruck.TabIndex = 47;
            this.comboBoxTruck.SelectedIndexChanged += new System.EventHandler(this.comboBoxTruck_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Auto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Licznik km od";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Licznik KM do";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Litry paliwa spalone";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Historia";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(257, 52);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 54;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(241, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 12);
            this.label20.TabIndex = 55;
            this.label20.Text = "Średnie spalanie/100 KM";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(233, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 12);
            this.label21.TabIndex = 57;
            this.label21.Text = "Ogólne średnie spalanie/100 KM";
            // 
            // textBoxTotalAverage
            // 
            this.textBoxTotalAverage.Location = new System.Drawing.Point(257, 101);
            this.textBoxTotalAverage.Name = "textBoxTotalAverage";
            this.textBoxTotalAverage.ReadOnly = true;
            this.textBoxTotalAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAverage.TabIndex = 56;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(109, 127);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 44;
            this.buttonCalculate.Text = "Dodaj";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(369, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(546, 139);
            this.checkedListBox1.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWBrutto);
            this.Controls.Add(this.textBoxWNetto);
            this.Controls.Add(this.textBoxBruttoTotal);
            this.Controls.Add(this.textBoxNettoTotal);
            this.Controls.Add(this.textBoxBruttoL);
            this.Controls.Add(this.textBoxNettoL);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.uwagi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dostawca);
            this.Controls.Add(this.bruttoLitr);
            this.Controls.Add(this.nettoLitr);
            this.Controls.Add(this.iloscLitrow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Historia Dostaw";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iloscLitrow;
        private System.Windows.Forms.TextBox nettoLitr;
        private System.Windows.Forms.TextBox bruttoLitr;
        private System.Windows.Forms.TextBox dostawca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uwagi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDostawy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttol;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxNettoL;
        private System.Windows.Forms.TextBox textBoxBruttoL;
        private System.Windows.Forms.TextBox textBoxNettoTotal;
        private System.Windows.Forms.TextBox textBoxBruttoTotal;
        private System.Windows.Forms.TextBox textBoxWNetto;
        private System.Windows.Forms.TextBox textBoxWBrutto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxTruck;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxEndKM;
        private System.Windows.Forms.TextBox textBoxStartKM;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxTotalAverage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}

