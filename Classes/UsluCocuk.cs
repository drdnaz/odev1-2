using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class UsluCocuk : Cocuk, IAskereGit, IEhliyetAl
    {
        public void askereGit(string isim)
        {
            Console.WriteLine(isim + "askere gitti ");
        }

        public void ehliyetAl(string isim)
        {
            Console.WriteLine(isim + "ehliyet aldı");
        }
    }
}
