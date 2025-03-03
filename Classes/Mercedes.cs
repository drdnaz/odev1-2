using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class Mercedes : Araba, IHızlıGit, IYuzebilir

    {
        public void hızlıGit(string isim)
        {
            Console.WriteLine(isim + " "+ " çok hızlı gidiyor..");
        }

        public void yuzebilir(string isim)
        {
            Console.WriteLine(isim +" " +  " denizde yüzüyor");
        }
    }
}
