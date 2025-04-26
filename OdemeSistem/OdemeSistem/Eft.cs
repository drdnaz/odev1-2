using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeSistem
{
    public class Eft : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"EFT ile {tutar} TL ödeme başarıyla gerçekleştirildi.";

        }
    }
}
