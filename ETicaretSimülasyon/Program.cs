using System;

namespace ETicaretSimülasyon
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.UrunMarka = "Monster";
            urun1.UrunAd = "Monster Abra A5";
            urun1.UrunAcıklama = "i7 10750H  Gtx 1650  16Gb Ram";
            urun1.UrunFiyat = 7850;
            urun1.UrunAyrac = "---------------------------------------";

            Urun urun2 = new Urun();
            urun2.UrunMarka = "Asus";
            urun2.UrunAd = "Asus ROG Strix";
            urun2.UrunAcıklama = "i7 10870H 8GB 1TB SSD RTX 2060";
            urun2.UrunFiyat = 12999;
            urun2.UrunAyrac = "---------------------------------------";

            Urun urun3 = new Urun();
            urun3.UrunMarka = "Lenovo";
            urun3.UrunAd = "Legion  Y540";
            urun3.UrunAcıklama = "i7 9750H 16GB 1TB + 256GB SSD GTX1660Ti";
            urun3.UrunFiyat = 10799;
            urun3.UrunAyrac = "--------------------------------------";

            Urun urun4 = new Urun();
            urun4.UrunMarka = "Acer";
            urun4.UrunAd = "Acer Predatör";
            urun4.UrunAcıklama = "i7 10750H 16GB 1TB SSD RTX 2070";
            urun4.UrunFiyat = 12799;
            urun4.UrunAyrac = "---------------------------------------";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4 };

            foreach (var urun in urunler)
            {
                UrunEkle urunEkle = new UrunEkle();

                urunEkle.Ekle(urun);
                          
            }

            Console.WriteLine("----------------For Döngüsü İle--------------");

            Console.WriteLine("     ");

            for (int i = 0; i < urunler.Length; i++)
            {

                Console.WriteLine(urunler[i].UrunMarka + "   --  " + urunler[i].UrunAd +"  -- " + urunler[i].UrunAcıklama +"  --  "+ urunler[i].UrunFiyat );



            }


        }
    }
}
