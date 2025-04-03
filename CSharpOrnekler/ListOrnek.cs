using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class ListOrnek
    {
        public static void Calistir()
        {
            List<string> isimler = new List<string> { "Ahmet", "Ayşe", "Mehmet", "Zeynep" };

            // Count
            Console.WriteLine($"Listedeki eleman sayısı: {isimler.Count}");

            // Contains
            Console.WriteLine(isimler.Contains("Ayşe") ? "Ayşe listede var." : "Ayşe listede yok.");

            // IndexOf
            int index = isimler.IndexOf("Mehmet");
            Console.WriteLine($"Mehmet'in indeksi: {index}");

            // Insert
            isimler.Insert(2, "Ali");
            Console.WriteLine("Ali 2. indekse eklendi.");

            // Remove
            isimler.Remove("Ahmet"); // ilk bulduğunu siler
            Console.WriteLine("Ahmet listeden silindi.");

            // RemoveAt
            if (isimler.Count > 1)
            {
                isimler.RemoveAt(1); // indeks numarasına göre siler
                Console.WriteLine("1. indeksteki eleman silindi.");
            }

            // RemoveAll
            isimler.RemoveAll(x => x.StartsWith("A")); // A harfiyle başlayanları siler
            Console.WriteLine("A ile başlayan tüm isimler silindi.");

            // CopyTo
            string[] isimDizisi = new string[isimler.Count];
            isimler.CopyTo(isimDizisi);
            Console.WriteLine("Liste diziye kopyalandı:");
            foreach (var isim in isimDizisi)
            {
                Console.WriteLine(isim);
            }

            // Clear
            isimler.Clear();
            Console.WriteLine("Liste temizlendi.");
        }
    }
}
