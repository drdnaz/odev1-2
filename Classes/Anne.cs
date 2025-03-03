using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;


namespace CMT17OOP.Classes
{

    //Anne class ı Insan class ından türemiştir
    //Anne classı Insan classındaki public olan tüm değişken ve metodlara erişebilir

    public class Anne : Insan, IOzellik, IOzellik2
    {
        public void dinle(string isim)
        {
            Console.WriteLine(isim + " dinliyor...");
        }

        public void oku(string isim)
        {
            Console.WriteLine(isim + " okuyor..");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor...");
        }
    }
}
