using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string isim1 = "ali";
            string isim2 = "veli";
            isim1 = isim2;
            isim2 = "nuri";

            Console.WriteLine(isim1+isim2);

        }
    }
}
