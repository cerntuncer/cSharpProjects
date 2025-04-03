using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class FaktoriyelOrnegi
    {
        public static void Calistir()
        {
            Console.Write("Faktöriyeli alınacak sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = Faktoriyel(sayi);
            Console.WriteLine($"{sayi}! = {sonuc}");
        }

        private static int Faktoriyel(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Faktoriyel(n - 1);
        }
    }
}
