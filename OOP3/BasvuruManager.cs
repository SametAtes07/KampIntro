using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Başvuran bilgilerini değerlendirme

            /* KonutKrediManager konutKrediManager = new KonutKrediManager();
             konutKrediManager.Hesapla(); */

            // Yukardaki  tanımlama sadece konut kredisi hesaplatır.

            krediManager.Hesapla();


        }

        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }


    }
}
