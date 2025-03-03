using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Araba
    {
        public string vites;
        public string marka;    
        public string model;
        public string rengi;
        public string  arabaAdi;
        public void git(string model, string rengi)
        {
            Console.WriteLine(model +" " +  rengi + " " + "gidiyor..");
        }
        
        public void ekranaYaz(string model, string marka)
        {
            Console.WriteLine(" " + model + "  " + marka);
        }

        public void cıktı(string arabaAdi, string vites)
        {
            Console.WriteLine(" " + arabaAdi + " " + vites);   
        }
    }
}
