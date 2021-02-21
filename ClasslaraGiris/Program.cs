using System;

namespace ClasslaraGiris
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();

            kurs1.KursunAdi = "C# ";
            kurs1.KursunEgitmeni = "Samet Ateş ";
            kurs1.İzlenmeOranı = 60;

            Kurs kurs2 = new Kurs();

            kurs2.KursunAdi = "Java Eğitimi ";
            kurs2.KursunEgitmeni = "Ahmet Batman ";
            kurs2.İzlenmeOranı = 31;

            Kurs kurs3 = new Kurs();

            kurs3.KursunAdi = "Valorant Nasıl oynanır ";
            kurs3.KursunEgitmeni = "Marul ";
            kurs3.İzlenmeOranı = 86;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursunAdi + " -- " + kurs.KursunEgitmeni + "  %" + kurs.İzlenmeOranı);

            }


        }
    }
}
class Kurs
{
    public string KursunAdi { get; set; }

    public string KursunEgitmeni { get; set; }

    public int İzlenmeOranı { get; set; }
}