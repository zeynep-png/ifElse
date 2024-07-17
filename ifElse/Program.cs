using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir  sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür");

            }
            else if (sayi < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dur.");
            }

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else if (sayi == 1)
            {
                Console.WriteLine("Sayı tektir.");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayı negatiftir.");
            }

            Console.WriteLine("Programdan çıkmak için bir tuşa basınız.");
            Console.ReadKey();

        }
    }
}

