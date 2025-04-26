using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeSistem
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar} tl ödeme yapıldı.";
        }
    }
}
