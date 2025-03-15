using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class Bmw : Araba, IHızlıGit, IYuzebilir, IUcabilir
    {
      

        public Bmw(string marka, string model, double tuketim, double mesafe) : base(marka, model, tuketim, mesafe)
        {
        }

        public void hızlıGit(string isim)
        {
            Console.WriteLine(isim +" " + " çok hızlı  gidiyor...");
        }

        public void ucabilir(string isim)
        {
            Console.WriteLine(isim + " havda uçuyor..");
        }

        public void yuzebilir(string isim)
        {
            Console.WriteLine(isim + "denizde yüzüyor...");
        }
    }
}
