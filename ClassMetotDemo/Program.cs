using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 2;
            musteri1.MusteriAd = "Ahmet   ";
            musteri1.MusteriSoyad = "Batman";
            musteri1.MusteriYas = 21;

            Musteri musteri2 = new Musteri();

            musteri2.Id = 4;
            musteri2.MusteriAd = "Ömer   ";
            musteri2.MusteriSoyad = "Demir";
            musteri2.MusteriYas = 23;

            Musteri musteri3 = new Musteri();

            musteri3.Id = 7;
            musteri3.MusteriAd = "Kerem   ";
            musteri3.MusteriSoyad = "Gümüş";
            musteri3.MusteriYas = 19;

            Musteri musteri4 = new Musteri();

            musteri4.Id = 8;
            musteri4.MusteriAd = "Safa   ";
            musteri4.MusteriSoyad = "Demirdağ";
            musteri4.MusteriYas = 20;

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            musteriManager.Remove(musteri4);
            musteriManager.Sırala(musteriler);

            

        }
    }
}
