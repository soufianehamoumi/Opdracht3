using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    internal class Auto
    {
        private string Merk { get; set; }
        private double Km { get; set; }

        public Auto(string merk, double km)
        {
            Merk = merk;
            Km = km;
        }

        public override string ToString()
        {
            return "Merk van de auto  " + Merk + ": heeft :  " + Km + "km";
        }
    }
}
