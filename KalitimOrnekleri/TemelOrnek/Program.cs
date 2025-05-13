using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemelOrnek;

namespace TemelOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil o = new Otomobil();
            Motorsiklet m = new Motorsiklet();

            Console.WriteLine($"Otomobil tekerlek sayısı: {o.TekerlekSayisi}");
            Console.WriteLine($"Motorsiklet tekerlek sayısı: {m.TekerlekSayisi}");
        }
    }
} 