using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    class SayininBasamaklari
    {
        public static void BasamakYazdir(int sayi)
        {
            if (sayi < 10)
            {
                Console.WriteLine(sayi);
                return;
            }

            BasamakYazdir(sayi / 10); // önce üst basamakları yaz
            Console.WriteLine(sayi % 10); // sonra en alt basamağı yaz
        }

        public static void Calistir()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Basamaklar:");
            BasamakYazdir(sayi);
        }
    }
    }
