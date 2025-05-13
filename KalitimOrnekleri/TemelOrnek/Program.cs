using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemelOrnek
{
    public class Tasit
    {
        public int TekerlekSayisi;
    }

    public class Otomobil : Tasit
    {
        public Otomobil()
        {
            TekerlekSayisi = 4;
        }
    }

    public class Motorsiklet : Tasit
    {
        public Motorsiklet()
        {
            TekerlekSayisi = 2;
        }
    }

    class Program
    {
        static void Main()
        {
            Otomobil o = new Otomobil();
            Motorsiklet m = new Motorsiklet();

            Console.WriteLine("Otomobilin teker sayısı: " + o.TekerlekSayisi);
            Console.WriteLine("Motorsikletin teker sayısı: " + m.TekerlekSayisi);
        }
    }
}
