using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM17OOP.Classes.Matematik  
{
    public class Hesapla  
    {
        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;  
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;  
        }
    }
}
/*
  Aynı isimdeki sınıfların veya diğer türlerin çakışmasını engellemek için kullanılır.Bu sayede çakışmaları önler
Proje büyük ve karmaşık hale geldikçe, farklı işlevleri ayrı namespace'lerde tutmak, kodun düzenli ve okunabilir olmasını sağlar.
Doğru namespace kullanımı, gereksiz bağımlılıkları ve yüklemeleri ortadan kaldırarak, sadece gerekli sınıfların kullanılmasını sağlar.

Genişletilebilirlik (Extensibility),bir yazılımın mevcut işlevselliklerini bozmadan yeni özellikler eklenebilmesi anlamına gelir
Yazılım geliştirme sürecinde, yazılımın mevcut kodu üzerinde değişiklik yapmadan yeni özellikler eklenmesi sağlanmalıdır. Bunu başarmak için, sınıflar ve metodlar genellikle genişletilebilir şekilde tasarlanır.
geliştirme süreçlerinde genişletilebilirliği sağlamak için açık/kapalı prensibi, polimorfizm, bağımlılık enjeksiyonu, soyutlama gibi yaklaşımlar kullanılır.
Polimorfizm özelliğini kullanarak, aynı interface ya da temel sınıf ile farklı implementasyonlar yapılabilir.
Soyutlama,yalnızca gerekli olan özellikleri ve metotları gösterir zaten. Bu da yeni işlevlerin eklenmesi kolaylaştırır.
*/