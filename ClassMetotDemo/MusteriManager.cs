using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {

            Console.WriteLine("Eklendi : "+ " Id :  " + musteri.Id +" Ad:  " + musteri.MusteriAd + " Soyad: " + musteri.MusteriSoyad +" Yas: "+musteri.MusteriYas);

        }

        public void Remove(Musteri musteri)
        {

            Console.WriteLine("Silindi : "+" Ad: "+ musteri.MusteriAd+" Soyad: "+musteri.MusteriSoyad+" Yas: "+musteri.MusteriYas+" Id: "+musteri.Id);

            Console.WriteLine("----------------------------------------------");
        }


       
        public void Sırala(Musteri[] musteriler)
        {

            foreach (var x in musteriler)
            {


                Console.WriteLine("Liste : "+" Id: " +x.Id+" Ad: "+x.MusteriAd+" Soyad: "+x.MusteriSoyad+" Yas: "+x.MusteriYas);

            }

        }



    }
}
