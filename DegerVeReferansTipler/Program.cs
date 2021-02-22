using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // int , decimal , flout, double, bool = değer Tip.
            // array , class , interface = referans Tip.


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int[] sayilar1 = new int[] { 30, 60, 90 };
            int[] sayilar2 = new int[] { 200, 600, 900 };
            sayilar1 = sayilar2;
            sayilar2[0] = 86951;
            
            
            Console.WriteLine(sayilar1[0]);

            Console.WriteLine("----");
        }
    }
}
