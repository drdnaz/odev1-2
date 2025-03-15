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
        public string Marka { get; set; }    
        public string Model { get; set; }
        public double YakıtTüketimi { get; protected set; }
     public double Mesafe { get; set; }
        public string rengi;
        public string  arabaAdi;


        public Araba(string marka, string model, double tuketim, double mesafe)
        {
            Marka = marka;
            Model = model;
            YakıtTüketimi = tuketim;
            Mesafe = mesafe;
        }

        
        // Benzin tüketimini hesaplayan metod
        public double BenzinTuketimiHesapla()
        {
            return (YakıtTüketimi * Mesafe) / 100;
        }

        // Araba bilgilerini yazdıran metod
        public void BilgileriYazdir()
        {
            Console.WriteLine($"{Marka} {Model} - {Mesafe} km - {YakıtTüketimi} L/100km");
        }
    
   

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
