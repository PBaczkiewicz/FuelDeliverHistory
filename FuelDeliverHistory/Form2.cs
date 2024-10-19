using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelDeliverHistory
{
    public partial class Form2 : Form
    {
        public Auto.Calculation calc {get; set;}
        public Form2(Auto.Calculation _calc, DateTime dateFrom)
        {
             calc = _calc;
            InitializeComponent();
            dateTimePickerFrom.Value = dateFrom; dateTimePickerTo.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc.dateFrom=dateTimePickerFrom.Value;
            calc.dateTo=dateTimePickerTo.Value;
            DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
