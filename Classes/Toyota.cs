using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Toyota : Araba
    {

        public Toyota(string marka, string model, double tuketim, double mesafe) : base(marka, model, tuketim, mesafe)
        {
        }
    }
}
