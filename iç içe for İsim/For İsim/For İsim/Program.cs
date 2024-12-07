using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_İsim
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolon, adet;
            string Kelime;

            Console.Write("Lütfen Bir İsim Veya Kelime Giriniz: \t");
            Kelime = Console.ReadLine();

            Console.Write("Kelimeyi Veya İsmi Kaç Kolon İçinde Yazdırmak İstiyorsunuz: \t");
            kolon = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kelimeyi Veya İsmi Kolonlar İçinde Kaç Defa Yazdırmak İstiyorsunuz: \t");
            adet = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            for (int i = 0; i < kolon; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(i + 1 + " --- Kolon ----- " + "\n");
                Console.Write("\n");
                for (int j = 0; j < adet; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(j + 1 + ".isim " + Kelime + " \n ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
