using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class usAlmaIslemi
    {
       public static void usSonuc()
        {
            double taban, us, sonuc;
            Console.WriteLine("Taban sayısını girin:");
            taban=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üs sayısını girin:");
            us = Convert.ToDouble(Console.ReadLine());
            sonuc=Math.Pow(taban, us);
            Console.WriteLine("{0}^{1}={2}",taban,us,sonuc);
            Console.ReadLine();
        }
    }
}
