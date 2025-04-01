using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class CarpmaOrnegi
    {
       public static void SonucCalıstır()
        {
            float number1, number2, product;
            Console.Write("Sayı-1:");
            number1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Sayı-2:");
            number2= Convert.ToSingle(Console.ReadLine());
            product = number1 * number2;
            Console.WriteLine($"Sonuç: {product}");
            Console.Read();
        }

    }
}
