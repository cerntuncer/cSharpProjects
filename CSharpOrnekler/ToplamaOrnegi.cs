using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class ToplamaOrnegi
    {
        public static void OrnekCalistir()
        {
            Console.Write("Birinci sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam}");//$ koyarsak stringin içinde değişken olacak,güncel ve okunabilir yöntem
        }
    }
}
