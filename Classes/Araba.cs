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
  
   
        public string ArabaDurumu(int yas)
        {
            if (yas >= 0 && yas < 10)
                return "Arabanız yeni";
            else if (yas >= 10 && yas < 20)
                return "Servise götürmeniz gerekebilir";
            else if (yas >= 20 && yas < 30)
                return "Arabanız hurdaya çıkabilir";
            else
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
    }



}
