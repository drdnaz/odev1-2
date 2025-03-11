using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class User
    {
        private string adSoyad; 
        private int yas;        

        public string email { get; set; } 

       
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string yeniAdSoyad)
        {
            adSoyad = yeniAdSoyad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int yeniYas)
        {
            if (yeniYas > 0) 
            {
                yas = yeniYas;
            }
            else
            {
                Console.WriteLine("Yaş negatif olamaz!");
            }
        }

      
        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad: " + adSoyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Email: " + email);
        }
    }
}

