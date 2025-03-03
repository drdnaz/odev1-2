using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class HiperAktifCocuk : Cocuk, IEhliyetAl
    {
        public void ehliyetAl(string isim)
        {
            Console.WriteLine(isim + " ehliyet alıyor...");
        }
    }
}
