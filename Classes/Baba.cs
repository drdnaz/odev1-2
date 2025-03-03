using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class Baba : Insan, IOzellik
    {
        public void oku(string isim)
        {
            Console.WriteLine(isim + "okuyor");
        }

       
    }
}
