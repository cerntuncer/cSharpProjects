using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class DirectoryIslemleri
    {
        public static void Calistir()
        {
            // 🔧 Klasör yollarını belirliyoruz
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";

            // ❌ path dizini yoksa, oluştur
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);  // klasörü oluştur
                Console.WriteLine("Oluşturulma Tarihi: " + Directory.GetCreationTime(path));
                Console.WriteLine("Son Erişim Tarihi: " + Directory.GetLastAccessTime(path));
                Console.WriteLine("Son Değiştirilme Tarihi: " + Directory.GetLastWriteTime(path));
                Console.WriteLine("Bulunduğu Dizin Adı: " + Directory.GetParent(path));
                Console.ReadLine();
            }

            // ✔️ Eğer hedef klasör varsa, onu sil
            if (Directory.Exists(target))
            {
                Directory.Delete(target, true);  // true: içindeki alt klasör ve dosyaları da siler
            }

            // 🚚 TestDizini'ni hedef klasöre taşı
            Directory.Move(path, target);

            // 📁 C:\Test altındaki klasörleri bul
            string[] directories = Directory.GetDirectories(@"C:\Test\");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);  // her klasörün adını yazdır
            }

            // 📝 Yeni bir dosya oluştur
            File.CreateText(target + @"\NewFile.txt");

            // 📄 hedef klasörde kaç dosya var yaz
            Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", target, Directory.GetFiles(target).Length);

            Console.ReadLine();  // Konsol hemen kapanmasın diye

        }
    }
}
