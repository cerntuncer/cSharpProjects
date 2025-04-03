using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    class FibonacciOrnegi
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Calistir()
        {
            Console.Write("Kaç terimli Fibonacci dizisi yazılsın: ");
            int terimSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < terimSayisi; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.WriteLine();
        }
    }
    }
