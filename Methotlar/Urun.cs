using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class Urun  // bu şekilde oluşturdumuz classlarda (encapsulation) olası kod düzenlemede yeni bir parametre eklediğmizde olan kodlarımız hata ile karşılaşmaz...
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }  // Bunu sonradan ekledim örneğin. 



    }
}
