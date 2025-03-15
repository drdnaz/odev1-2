using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Abstractts
{
    public class Stajyer : Calısan
    {
        public Stajyer(string ad, string soyad, string meslek, decimal maas, string departman) : base(ad, soyad, meslek, maas, departman)
        {

        }

        public override double maasinizNedir()
        {
            return 5000.0;

        }
    }
}
