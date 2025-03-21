using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Matematik
    {




        public int Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("iki integer prametrelli topla metodu çağrıldı. ");
            return sayi1 + sayi2;
        }




        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("üç integer prametrelli topla metodu çağrıldı. ");
            return sayi1 + sayi2 + sayi3;
        }

        public double Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("iki double prametrelli topla metodu çağrıldı. ");
            return sayi1 + sayi2;

        }

        public double Topla(double sayi1, double sayi2, double sayi3)
        {
            Console.WriteLine("Üç double parametreli Topla metodu çağrıldı.");
            return sayi1 + sayi2 + sayi3;
        }





        //public int topla(int sayi1, int sayi2)
        //   {
        //       int sonuc = 0;
        //       sonuc = sayi1 + sayi2;
        //       //bu metodu kim nerde çağırıyorsa ona ilgili değeri sonucu geriye dön
        //       return sonuc;
        //   }

        //   public int cikar(int sayi1, int sayi2)
        //   {
        //       return sayi1 - sayi2;
        //   }

        public int Carp(int sayi1, int sayi2)
        {
            Console.WriteLine("iki integer parametreli carp metodu çağrıldı.");
            return sayi1 * sayi2;
        }

        public int Carp(int sayi1, int sayi2 , int sayi3)
        {
            Console.WriteLine("üç integer parametreli carp metodu çağrıldı.");
            return sayi1 * sayi2 * sayi3;
        }


        public double Carp(double sayi1, double sayi2)
        {
            Console.WriteLine("iki double parametreli carp metodu çağrıldı.");
            return sayi1 * sayi2;
        }
        public double Carp(double sayi1, double sayi2, double sayi3)
        {
            Console.WriteLine("Üç double parametreli Carp metodu çağrıldı.");
            return sayi1 * sayi2 * sayi3;
        }


        //   public int bol(int sayi1, int sayi2)
        //   {
        //       return sayi1 / sayi2;
        //   }
    }





}
    

