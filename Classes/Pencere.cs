using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMT17OOP.Classes
{
    public class Pencere
    {

        public int PencereSayisi{ get; private set; }
        //Bu özelliğin değerini okumak için bir public getter sağlar. Yani herkes bu değeri okuyabilir.
        //Bu özelliğin değerini değiştirmek için private bir setter sağlar. Yani bu değer sadece sınıfın içinden değiştirilebilir, dışarıdan değiştirilemez.

        public Pencere(int pencereSayisi)
        {
            PencereSayisi = pencereSayisi;
        }

    }
}
