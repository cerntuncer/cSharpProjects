using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class DirectoryInfoOrnegi
    {
        public static void Calistir()
        {
            // Kullanılacak dizin tanımlama
            DirectoryInfo NewDir = new DirectoryInfo(@"C:\Test\TestDizini");

            // Dizin var mı kontrolü
            if (NewDir.Exists)
            {
                Console.WriteLine("Dizin Mevcut.");
                NewDir.Delete(true); // true: alt dizinlerle birlikte sil
                Console.WriteLine("Dizin Silindi.");
            }

            // Yeni dizin oluşturma
            NewDir.Create();
            Console.WriteLine("Klasör oluşturuldu.");
            Console.WriteLine("Oluşturulma Tarihi: " + NewDir.CreationTime);
            Console.WriteLine("Bulunduğu Dizin: " + NewDir.Parent);
            Console.WriteLine("Dizin Adı: " + NewDir.Name);
            Console.WriteLine("Tam Adı: " + NewDir.FullName);
            Console.WriteLine("Son Erişim Tarihi: " + NewDir.LastAccessTime);
            Console.WriteLine("Son Değiştirilme Tarihi: " + NewDir.LastWriteTime);

            // Alt dizin oluşturma
            DirectoryInfo SubDir = NewDir.CreateSubdirectory("AltDizin");

            // Alt dizine dosya oluşturma
            File.CreateText(SubDir.FullName + @"\YeniDosya.txt");

            // Dizin içindeki dosyaları sayma
            Console.WriteLine("'{0}' dizinindeki dosya sayısı: {1}",
                NewDir.FullName, NewDir.GetFiles().Length);

            // Dizin içindeki klasörleri sayma
            Console.WriteLine("'{0}' dizinindeki klasör sayısı: {1}",
                NewDir.FullName, NewDir.GetDirectories().Length);

            Console.ReadLine();
        }
    }
}
