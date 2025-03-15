﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMT17OOP.Interfaces;

namespace CMT17OOP.Classes
{
    public class Porche : Araba, IHızlıGit
    {
       
        public Porche(string marka, string model, double tuketim, double mesafe) : base(marka, model, tuketim, mesafe)
        {
        }

        public void hızlıGit(string isim)
        {
            Console.WriteLine(isim + " " + " çok hızlı gidiyor...");
        } 
    }
}
