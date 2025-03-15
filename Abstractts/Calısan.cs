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
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public decimal Maas { get; set; }
        public string Departman { get; set; }





        public Calısan(string ad, string soyad, string meslek, decimal maas, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Maaş: {Maas} TL, Departman: {Departman}");
        }


        public abstract double maasinizNedir();
        public void mesaiyeBasla(String isim)
        {
            Console.WriteLine(isim +    "mesaiye basladı..");
        }
    }
}
//override iptal etmek anlamında