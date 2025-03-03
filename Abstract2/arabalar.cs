using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Abstract2
{
    public abstract class arabalar 
    {
        public abstract double nekadarYakiyor();
        public void yakiyor(String isim)
        {
            Console.WriteLine(isim + "lt yakıyor..");
        }
    }
}
