// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Xml.Linq;
using CMT17OOP.Abstract2;
using CMT17OOP.Abstractts;
using CMT17OOP.Classes;
using CM17OOP.Classes.Matematik;
using System.Diagnostics.Metrics;


//Console.WriteLine("Hello, World!");

////bir class tan nesne oluşturma
////ClassIsmi nesneAdi = new ClassIsmi();
//Insan i = new Insan();
//i.adi = "ibrahim";
//i.soyadi = "gökyar";
//i.yas = 46;
//i.maas = 3.14;
//i.cinsiyet = false;
////uyu metodunu çağırdık
//i.uyu("hakan", "yılmaz");
//i.uyu(i.adi, i.soyadi);
//int gelenyas = i.yasHesapla(1980);
////Diyorum ki insan classının içinmdeki yasHesapla metodunu cağır ona ona 1980 gönder buradan gelen sonucu da gelenyas değişkenine aktar.
//Console.WriteLine("yaşınız: " + gelenyas);





//Araba hondaCivic = new Araba("Honda", "civic", 4, 4, "sedan", 200000);

//hondaCivic.BilgiGosterr();
//Console.ReadLine();











////Araba araba = new Araba();
////araba.Model = "bmw";
////araba.rengi = "siyah";
////araba.arabaAdi = "bugatti";
////araba.git(araba.Model, araba.rengi);



Matematik m = new Matematik();

Console.WriteLine("Toplama işlemleri");
int sonuc1 = m.Topla(5, 5);
Console.WriteLine("5+5= " +sonuc1);

int sonuc2 = m.Topla(6, 5, 3);
Console.WriteLine("6+5+3" +sonuc2);

double sonuc3 = m.Topla(10.1, 5.2);
Console.WriteLine("10.1+5.2= "+ sonuc3);

double sonuc4 = m.Topla(5.5, 3.2, 4.2);
Console.WriteLine("5.5+3.2+4.2= "+ sonuc4);

Console.WriteLine("ÇARPMA İŞLEMLERİ");

int sonuc5 = m.Carp(5, 2);
Console.WriteLine("5*2= "+sonuc5);

int sonuc6=m.Carp(6, 2, 3);
Console.WriteLine("6*2*3= " + sonuc6);

double sonuc7 = m.Carp(5.5, 10.3);
Console.WriteLine(".5*10.3= " + sonuc7);

double sonuc8 = m.Carp(5.5, 4.3, 5.4);
Console.WriteLine("5.5*4.3*5.4= " + sonuc8);



//m.topla(5,5);
////1. yöntem
//int gelenDeger = m.topla(5,5);
//Console.WriteLine("Toplam: "+gelenDeger);
//// 2.yöntem
//Console.WriteLine("Toplam 2. yöntem :"+ m.topla(5,5));

//Console.WriteLine("Çıkan sonuç: "+ m.cikar(5,5));
//Console.WriteLine("çarpım sonuç: "+ m.carp(10,5));
//Console.WriteLine("bölüm sonuç: "+ m.bol(5,5));



//Anne an = new Anne();
//an.adi = "fahriye";
//an.soyadi = "Gökyar";
//an.uyu(an.adi, an.soyadi);
//an.ekranaYaz(an.adi, an.soyadi);
//an.yaz(an.adi);
//an.oku(an.adi);


//Baba b = new Baba();
//b.ekranaYaz("Kasım", "Gökyar");

//b.oku(b.adi);


//Cocuk c = new Cocuk();
//c.ekranaYaz("ibrahim", "gökyar");

////Bmw bm = new Bmw();
////bm.ekranaYaz("Bmw", "X5");
////bm.cıktı("bmw", "Düz vitestir.");
////bm.ucabilir("bmw");
////bm.yuzebilir("bmw");
////bm.hızlıGit("bmw");

////Mercedes me = new Mercedes();
////me.ekranaYaz("Mercedes", "xl");
////me.hızlıGit("mercedes");
////me.yuzebilir("mercedes");

////me.cıktı("Mercedes", "otomatik vitestir.");
////Porche p = new Porche();
////p.hızlıGit("porche");

////p.ekranaYaz("porshe", "X5");
////p.cıktı("porshe", "otomatik vitestir.");
////Togg t = new Togg();
////t.cıktı("Togg", "otamatik vitestir.");
////Toyota ty = new Toyota();
////ty.cıktı("Toyota", "düz vitestir.");

////Auidi ai = new Auidi();
////ai.cıktı("Auidi", "otomatik vitestir.");


//AkilliCocuk ak = new AkilliCocuk();
//ak.adi = "Hakan";
//ak.soyadi = "Yılmaz";
//ak.sifat = "Akıllıdır";
//ak.adSoyadSifatYaz(ak.adi, ak.soyadi, ak.sifat);
//ak.askereGit(ak.adi);
//ak.klubeGit(ak.adi);
//ak.ehliyetAl(ak.adi);

//UsluCocuk us = new UsluCocuk();
//us.adSoyadSifatYaz("Mehmet", "yıldız", "usludur");
//us.askereGit("mehmet");

//us.ehliyetAl("Mehmet");



//HiperAktifCocuk hp = new HiperAktifCocuk();
//hp.ehliyetAl("Hüseyin");

////// abstarcct classların nesnesi oluşturulamaz.
////GenelMudur gm = new GenelMudur();
////Mudur mü = new Mudur();
////Programcı pr = new Programcı();
////Stajyer s = new Stajyer();

//double toplamMaas = 0.0;

////toplamMaas += gm.maasinizNedir(); //toplamMaas = toplamMaas + gm.maasinizNedir();
////toplamMaas += mü.maasinizNedir();
////toplamMaas += pr.maasinizNedir();
////toplamMaas += s.maasinizNedir();

//Console.WriteLine("Toplam : " + toplamMaas + " TL maaş alıyorlar");

//bmw bw =new bmw();
//mercedes mr = new mercedes();
//porche pc = new porche();  

//double toplamltyakiti = 0.0;

//toplamltyakiti += bw.nekadarYakiyor();
//toplamltyakiti += mr.nekadarYakiyor();
//toplamltyakiti += pc.nekadarYakiyor();

//Console.WriteLine("Toplam: " + toplamltyakiti + " " + "lt Yakmıştır.");



//ArrayList arr = new ArrayList();

////1. aynı türden verileri bir isim altında tutmamızı sağlar
////hangiturdeveri[] diziAdi = new hangiturdeveri[7];
////dizilerin ilk elamanı sıfırdan başlar.
//string[] gunler = new string[7];
//gunler[0] = "pazartesi";
//gunler[1] = "salı";
//gunler[2] = "çarşamba";
//gunler[3] = "perşembe";
//gunler[4] = "cuma";
//gunler[5] = "cumartesi";
//gunler[6] = "pazar";

//for (int sayac2 = 0; sayac2 < gunler.Length; sayac2++)
//{
//    Console.WriteLine(gunler[sayac2]);
//}

////if(kosul) { yapılması gereken neyse o yapılır  } else if(kosul) { neyse yapılacak işlemler yapılır  }  else { yapılması gereken neyse o yapılır   }
//int yas = 19;
//if (yas > 0 && yas <= 18)
//{
//    Console.WriteLine("küçüksünüz");

//}
//else if (yas > 18 && yas <= 35)
//{
//    Console.WriteLine("gençsiniz");
//}
//else if (yas > 35 && yas <= 55)
//{
//    Console.WriteLine("yetişkinsiniz");

//}
//else if (yas > 55 && yas <= 75)
//{
//    Console.WriteLine("yaşlısınız");
//}
//else if (yas > 75 && yas <= 99)
//{
//    Console.WriteLine("çok yaşlısınız");

//}
//else
//{
//    Console.WriteLine("hiç doğmadınız ya da çoktan öldünüz!!");

//}

///*
//--Soru : 

//kişinin doğum yılını parametre alan ve geriye bu doğum yılından şu anki bulunduğumuz
//yılı çıkartıp ekrana yaşınız budur yazan kodu nasıl yazardınız

//1980  Yaşınız : 45
//    */

//int gelenYas = i.yasHesapla(1988);
//Console.WriteLine("yaşınız: " + gelenYas);

//// Kişinin yaşı 0 dan büyükse ve 18 den küçük ve eşitse 
//// kişinin yaşı 18 den büyük 35 den küçük ve eşitse gençsiniz yazsın
////kişinin yaşı 35 den büyük 55 denküçük ve eşitse yetişkinsiniz 
///*kişinin 55 den büyük 75 den küçük ve eşitse
//yaşlısınız
//kişinin yaşı 75 den büyük 99 dan küçük ve eşitse
//çok yaşlısınız
//ya hiç doğmadınızı yada çoktan öldünüz!!


//koşulları kontrol eden vereyi string tipinde değer dönen
//bir metodumuz olacak

//--Ödev : 2

//arabanın yaşı 0 dan büyükse ve 10 den küçük ve eşitse
//arabanız yeni
//kişinin yaşı 10 den büyük 20 den küçük ve eşitse
//servise götürmeniz gerekibilir
//kişinin yaşı 20 den büyük 30 den küçük ve eşitse
//arabanız hurdaya çıkabilir

//ya hiç üretilmedi yada arabanız trafikten men edildi


//--if yerine switch case araştırma ödevi : 
//*/


////for(int sayac=0; sayac <10; sayac++ )    {  yapılması gereken işlemler    }
//for (int sayac = 0; sayac < 10; sayac++)
//{
//    Console.WriteLine("Merhaba Dünya : " + sayac);
//}



////dizinin 2 farkıl tanımı
////n elemanlı bir dizi tanımlamıştık
////hangitürdeveri[] diziAdi = new {  };
//int[] sayilar = { 3, 5, 7, 8, 11, 22, 33, 44, 55, 66, 88, 99, 101, 104 };

//int sayiToplam = 0;

//for (int x = 0; x < sayilar.Length; x++)
//{
//    Console.WriteLine("Sıradaki Sayı : " + sayilar[x]);
//    //  sayiToplam = sayiToplam + sayilar[x];
//    sayiToplam += sayilar[x];
//}

//Console.WriteLine("Sayıların toplamı : " + sayiToplam);

///*
//ÖDEV Access Modifiers (Erişim Belirleyicileri)
// Değişkenler ve Metotlar

//C# dilinde kullanılan erişim belirleyiciler protected, private, public, internal'dır.
//Sınıfların ve üyelerinin erişilebilirliğini belirlerler.
//Public : Herkesin Erişimine açık, Proje içindeki tüm sınıflar ve hatta farklı projelerden bile erişilebilir.
//Örnek olarak otobüs durakları, metro istasyonları herkesin erişimine açıktır. Şehirde yaşayan herkes durağa gelip bekleyebilir.

//public class OtobusDuragi
//{
//    public string DurakAdi = "Merkez Durak";

//    public void DuraktaBekle()
//    {
//        Console.WriteLine("Bu durakta herkes bekleyebilir.");
//    }
//}
//böyle bir kodlama yapabiliriz.Böylece herkes bu bilgiye erişebilecektir.

//Private : Sadece aynı sınıf içinde yani yalnızca tanımlandığı sınıf içinde erişilebilirler. Mesela örnek verecek olursam bir telefonun ekran kilidi şifresi sadece telefonun sahibi tarafından bilinmesi istenir. Başkaları bu şifreye erişmesini istemeyiz. Bu yüzden Private'i kullanırız.
//public class Telefon
//{
//    private string sifre = "naz22"; 

//    private void sifreyiGoster()
//    {
//        Console.WriteLine("Şifre: " + sifre);
//    }
//}
//kod olarak da böyle kullanabilirim.

//Protected : Miras alan sınıflara açık olandır. Örnek verecek olursam bir ailede soyadı, aile üyeleri arasında paylaşılır ama başkaları değiştiremez. Soyadı sadece aile içindekiler tarafından kullanılır.
//public class Aile
//{
//    protected string soyad = "Yılmaz"; // sadece aile üyeleri görmesi için böyle kullandım.

//public class Cocuk : Aile
//{
//    public void soyadiniGoster()
//    {
//        Console.WriteLine("Benim soyadım: " + soyad);     }
//}
//kod olarak da bu örneği verebilirim.

//internal : Aynı proje içinde erişilebilir,farklı bir projeden erişelemez.
//örnek olarak üniversite öğrencilerinden verebilirim. Sadece bizler üniversitenin öğrenci portalına erişim sağlayabiliriz.
//internal class OgrenciPortali
//{
//    internal void girisYap()
//    {
//        Console.WriteLine("Sadece üniversite öğrencileri erişebilir.");
//    }
//}

//Erişim Belirleyicilerin OOP'deki Rolü :  
//Veri gizliliğini sağlayarak güvenli yapı oluşturur. Kodun yönetilebilir olmasını sağlar Bu sayede gereksiz erişim açmak karmaşıklık ve güvenlik sorunlarına yol açmasını engeller.


//*/
//User kullanici = new User();
//kullanici.SetAdSoyad("Naz Babaoğlu");
//kullanici.SetYas(25);

//// Email doğrudan atanabilir çünkü public
//kullanici.email = "nazbabaoglu@gmail.com";

//kullanici.BilgileriGoster();


//Hesapla h = new Hesapla();
//int toplam = h.topla(8, 4);
//Console.WriteLine("toplam: " + toplam);
//int carpim = h.carp(5, 6);
//Console.WriteLine("çarpım: " + carpim);


////Random rnd = new Random();  
////int randomNumber = rnd.Next(1,11);
////int guessNumber = 0;
////int guessCount = 0;
////Console.WriteLine("Bilgisayar 1 ile 10 arasında bir sayı tuttu. Tahmin et bakalım!");

////while (guessNumber != randomNumber) // Bu döngü kullanıcı doğru tahmin yapana kadar devam eder.
////{
////    Console.Write("Tahmininizi girin: ");
////    guessNumber = Convert.ToInt32(Console.ReadLine()); // Hesap makinesi ödevinde öğrendiğimiz gibi kullanıcıdan tahmin alınır.
////                                                       // İlk bu ödevden başlamışsanız hesap makinesinde zorlanmazsınız :)
////    guessCount++;

////    // if-else yapısı kullanarak kullanıcının tahminini kontrol edin ve büyük/küçük olduğunu belirtin.
////    if (guessNumber < randomNumber)
////    {
////        Console.WriteLine("Daha büyük bir sayı tahmin edin");
////    }
////    else if (guessNumber > randomNumber)
////    {
////        Console.WriteLine("Daha küçük bir sayı tahmin edin");
////    }
////    else
////    {
////        Console.WriteLine($"Tebrikler! {guessCount}. tahminde doğru sayıyı buldunuz.");
////    }
////}




//    int sayi = 5;

//    while (sayi < 5)
//    {
//        Console.WriteLine("While Döngüsü: " + sayi);
//        sayi++;
//    }

//    Console.WriteLine("While döngüsü tamamlandı.");


//int sayi2 = 5;

//do
//{
//    Console.WriteLine("Do-While Döngüsü: " + sayi);
//    sayi++;
//}
//while (sayi2 < 5);

//Console.WriteLine("Do-While döngüsü tamamlandı.");



//        List<Araba> arabalar = new List<Araba>
//        {
//            new Araba("Toyota", "Corolla", 6.5, 500),
//            new Araba("Volkswagen", "Golf", 7.2, 400),
//            new Araba("Honda", "Civic", 6.8, 600)
//        };

//        double toplamTuketim = 0;

//        Console.WriteLine("Araba Bilgileri:\n");
//        foreach (var araba in arabalar)
//        {
//            araba.BilgileriYazdir();
//            toplamTuketim += araba.BenzinTuketimiHesapla();
//        }

//        Console.WriteLine($"\nToplam Benzin Tüketimi: {toplamTuketim} litre");



//int[] numbers = new int[5];
//int summ = 0;


//for (int a = 0; a < numbers.Length; a++)
//{
//    Console.WriteLine($"{a + 1}. sayiyi girin: ");
//    numbers[a] = Convert.ToInt32(Console.ReadLine());

//}

//foreach (int number in numbers)
//    {
//    summ += number;

//}
//double average = summ / 5.0;
//Console.WriteLine($"toplam: {summ}" + $"ortalama:  {average}" );


// for döngüsü tekrar eden işlemler için kullanabiliriz.
// for(int sayac =0; sayac <10; sayac ++)
//{ yapılması gereken işlemler neyse onu yazarız}


