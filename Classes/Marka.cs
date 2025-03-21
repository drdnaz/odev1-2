using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Marka
    {

        public string MarkaAdi { get; private set; }
        public string Model {  get; private set; }

        public Marka(string markaAdi, string model)
        {
        MarkaAdi = markaAdi;
            Model = model;
        
        }
    }
}
