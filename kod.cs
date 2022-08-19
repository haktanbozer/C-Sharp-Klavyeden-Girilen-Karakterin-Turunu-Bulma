using System;

namespace Ders_01
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            for (; ; )
            {
                Console.Write("Karakteri Girin : ");
                ch = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (ch >= 65 && ch <= 90)
                    Console.WriteLine("Büyük Harf");

                else if (ch >= 97 && ch <= 122)
                    Console.WriteLine("Küçük Harf");

                else if (ch >= 48 && ch <= 57)
                    Console.WriteLine("Sayı");

                else
                    Console.WriteLine("Özel Karakter");
            }
        }
    }
}
