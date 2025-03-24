using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temelUygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Bir sayı gir:");//konsola yazı yazdırmak için kullanılır
            number = Convert.ToInt32(Console.ReadLine());//konsoldan kullanıcının yazdığı veriyi okur ama bu değer string bu yüzden tam sayıya çeviriyoruz
            Console.WriteLine("Girilen sayı:{0}",number);
            Console.ReadLine();//programın hemen kapanmaması için bekleme yapar.
        }
       
    }
}
