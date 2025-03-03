// See https://aka.ms/new-console-template for more information
using System;
using CMT17OOP.Abstract2;
using CMT17OOP.Abstractts;
using CMT17OOP.Classes;


Console.WriteLine("Hello, World!");

//bir class tan nesne oluşturma
//ClassIsmi nesneAdi = new ClassIsmi();
Insan i = new Insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = false;
//uyu metodunu çağırdık
i.uyu("hakan","yılmaz");
i.uyu(i.adi,i.soyadi);


Araba araba = new Araba();
araba.model = "bmw";
araba.rengi = "siyah";
araba.arabaAdi = "bugatti";
araba.git(araba.model, araba.rengi);



Matematik m =new Matematik();  
m.topla(5,5);
//1. yöntem
int gelenDeger = m.topla(5,5);
Console.WriteLine("Toplam: "+gelenDeger);
// 2.yöntem
Console.WriteLine("Toplam 2. yöntem :"+ m.topla(5,5));

Console.WriteLine("Çıkan sonuç: "+ m.cikar(5,5));
Console.WriteLine("çarpım sonuç: "+ m.carp(10,5));
Console.WriteLine("bölüm sonuç: "+ m.bol(5,5));



Anne an = new Anne();
an.adi = "fahriye";
an.soyadi = "Gökyar";
an.uyu(an.adi, an.soyadi);
an.ekranaYaz(an.adi, an.soyadi);
an.yaz(an.adi);
an.oku(an.adi);


Baba b = new Baba();
b.ekranaYaz("Kasım", "Gökyar");

b.oku(b.adi);


Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");

Bmw bm = new Bmw();
bm.ekranaYaz("Bmw", "X5");
bm.cıktı("bmw", "Düz vitestir.");
bm.ucabilir("bmw");
bm.yuzebilir("bmw");
bm.hızlıGit("bmw");

Mercedes me = new Mercedes();
me.ekranaYaz("Mercedes", "xl");
me.hızlıGit("mercedes");
me.yuzebilir("mercedes");

me.cıktı("Mercedes", "otomatik vitestir.");
Porche p = new Porche();
p.hızlıGit("porche");

p.ekranaYaz("porshe", "X5");
p.cıktı("porshe", "otomatik vitestir.");
Togg t = new Togg();
t.cıktı("Togg", "otamatik vitestir.");
Toyota ty = new Toyota();
ty.cıktı("Toyota", "düz vitestir.");

Auidi ai = new Auidi();
ai.cıktı("Auidi", "otomatik vitestir.");


AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.adSoyadSifatYaz(ak.adi, ak.soyadi, ak.sifat);
ak.askereGit(ak.adi);
ak.klubeGit(ak.adi);
ak.ehliyetAl(ak.adi);

UsluCocuk us = new UsluCocuk();
us.adSoyadSifatYaz("Mehmet", "yıldız", "usludur");
us.askereGit("mehmet");

us.ehliyetAl("Mehmet");



HiperAktifCocuk hp = new HiperAktifCocuk();
hp.ehliyetAl("Hüseyin");

// abstarcct classların nesnesi oluşturulamaz.
GenelMudur gm = new GenelMudur();   
Mudur mü = new Mudur();
Programcı pr = new Programcı();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += gm.maasinizNedir(); //toplamMaas = toplamMaas + gm.maasinizNedir();
toplamMaas += mü.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam : " + toplamMaas + " TL maaş alıyorlar");

bmw bw =new bmw();
mercedes mr = new mercedes();
porche pc = new porche();  

double toplamltyakiti = 0.0;

toplamltyakiti += bw.nekadarYakiyor();
toplamltyakiti += mr.nekadarYakiyor();
toplamltyakiti += pc.nekadarYakiyor();

Console.WriteLine("Toplam: " + toplamltyakiti + " " + "lt Yakmıştır.");

