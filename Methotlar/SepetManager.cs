using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun) 
        {

            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
            
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) // E-ticaret vb. siteler açtığımız vakit olası koda eklme yapmamız gerektiğinde bu sistem sayfalarca kod hatası almamıza neden olur.
                                                                           
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);

        }

    }
}
