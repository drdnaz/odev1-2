using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class AkilliCocuk : Cocuk,IAskereGit,IEhliyetAl,IKlubeGit
    {
        public void askereGit(string isim)
        {
            Console.WriteLine(isim + " askere gidiyor...");
        }

        public void ehliyetAl(string isim)
        {
            Console.WriteLine(isim + " ehliyet alıyor...");
        }

        public void klubeGit(string isim)
        {
            Console.WriteLine(isim + " askere gidiyor...");
        }
    }
}
