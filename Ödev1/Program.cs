using System;

namespace Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {

            string KategoriVeri = "Kategori : Yazılımcı Olma Kampı";

            bool SistemeGirisKontorl = true;

            Console.WriteLine(KategoriVeri);
            Console.WriteLine("   ");

            if (SistemeGirisKontorl==true)
            {
                Console.WriteLine("Kurslarım  Tüm Kurslar   Kampa Hazırlık     ");

                Console.WriteLine("    ");
            }
            else
            {
                Console.WriteLine("Kayıt Ol Butonu");

                Console.WriteLine("    ");
            }


            EgitimKursu kurs1 = new EgitimKursu();

            kurs1.KursunAdi = "Yazılım Geliştirici Yetiştirme Kampı ";
            kurs1.KursunEgitmeni = "Engin Demiroğ ";
            kurs1.KursİzlenmeOranı = 82;

            EgitimKursu kurs2 = new EgitimKursu();

            kurs2.KursunAdi = "Programlamaya Giriş İçin Temel Kurs ";
            kurs2.KursunEgitmeni = "Engin Demiroğ ";
            kurs2.KursİzlenmeOranı = 67;


            EgitimKursu[] TümKurslar = new EgitimKursu[] {kurs1,kurs2 };


            foreach (var kurs in TümKurslar)
            {
                Console.WriteLine(kurs.KursunAdi+"  -- "+kurs.KursunEgitmeni+"  %"+kurs.KursİzlenmeOranı);
            }

          


        }
    }
}
class EgitimKursu
{
    public string KursunAdi { get; set; }

    public string KursunEgitmeni { get; set; }

    public int KursİzlenmeOranı { get; set; }
}
