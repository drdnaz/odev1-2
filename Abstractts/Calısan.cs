using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Abstractts
{
    //abstract class ların nesnesi oluşturulamaz
    //bu abstract class tan türeyen tüm classlar abstract ile başlayan metodları implement(uygulamak) zorundadırlar
    public abstract class Calısan
    {

        public abstract double maasinizNedir();
        public void mesaiyeBasla(String isim)
        {
            Console.WriteLine(isim +    "mesaiye basladı..");
        }
    }
}
//override iptal etmek anlamında