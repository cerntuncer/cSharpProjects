
using KalitimOrnekleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
            k.Ad = "Minnak";
            Console.WriteLine($"Kedinin adı: {k.Ad}");
            k.SesCikar();   // Base sınıftan gelen metot
            k.Miyavla();    // Kedi sınıfına özgü metot

        }
    }
}
