using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FuelDeliverHistory
{
    public class Dostawy
    {
        public DateTime data { get; set; }
        public int iloscPaliwa { get; set; }
        public double nettoLitr { get; set; }
        public double bruttoLitr { get; set; }
        public double cenaNetto { get; set; }
        public double cenaBrutto { get; set; }
        public string dostawca { get; set; }
        public string uwagi { get; set; }

    }

    public class Auto
    {
        public class Calculation
        {
            public DateTime dateFrom { get; set; }
            public DateTime dateTo { get; set; }
            public int fromKM { get; set; }
            public int toKM { get; set; }
            public float avgFuelSpent { get; set; }
        }
        public Auto()
        {
            calculation = new Calculation();
            CalculationList = new List<Calculation>();
        }
        public Calculation calculation { get; set; }
        public string registration { get; set; }
        public List<Calculation> CalculationList { get; set; }

    }

}
