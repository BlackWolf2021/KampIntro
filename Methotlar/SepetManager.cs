using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int urunAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }
    }
}
