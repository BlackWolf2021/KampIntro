using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagoriEtiketi = "Katagori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(katagoriEtiketi);
        }
    }
}
