using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool test = false;
            string sonuc = test == false ? "Aşı olmanıza gerek yok" : "lütfen en yakın sağlık merkezine gidiniz";
            Console.WriteLine(sonuc);
        }
    }
}
