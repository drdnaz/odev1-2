using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Insan
    { //başlangıç scope

        //bir değişkeni tanımlarken
        //access modifiers(public,private,protected) dataType değişkenAdi
        //string tipindeki değişkenler alfanümerik değerleri saklamamızı sağlar
        //PROPERTIES DEĞİŞKENLER 
        public string adi = "35";
        public string soyadi;
        //tam sayısal verileri saklamımızı sağlar
        public int yas = 35;
        //kesirli küsuratlı verileri saklamamızı sağlar
        public double maas = 0.0;
        //true yada false şeklinde verileri saklamamızı sağlar
        public bool cinsiyet = false;


        //METODLAR 2 YE AYRILIRLAR
        //geriye değer döndüren ve geriye değer döndürmeyen
        //access modifiers dönüştipi metodAdi()  {   }
        //geriye değer döndüryemen adı uyu olan ve paramerre almayan bir metod
        public void uyu(string isim, string soyisim)
        {

            Console.WriteLine(isim + " " + soyisim + " uyuyor...");
        }

        public void ekranaYaz(string isim, string soyisim)
        {
            Console.WriteLine("Kişinin adı : " + isim + " Kişinin soyadı : " + soyisim);
        }

        public int yasHesapla(int dogumYili)
        {
            int sonuc = 0;
            sonuc = DateTime.Now.Year - dogumYili;
            return sonuc;
        }

    }

    }
