﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Matematik
    {
 
     public int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            //bu metodu kim nerde çağırıyorsa ona ilgili değeri sonucu geriye dön
            return sonuc;
        }

        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
    

