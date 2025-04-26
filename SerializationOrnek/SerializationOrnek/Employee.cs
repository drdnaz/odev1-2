using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOrnek
{
    //attiribute = []
    [Serializable] // farklı davran diyecek c# bunu classın başına eklersek bbu demek oluyor. yani başka bir formata dönüştürülebilir serialize edilebilir diyor.
    //bir metodun bir classın bir değişkenin basşında [abc] gördüğünde c# buna ayrı özel muamele yapıyor.
    public class Employee
    {

        public string Name;
        public string Phone { get; set; }
        public DateTime DoB { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
