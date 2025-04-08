using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class FileInfoOrnek
    {
        public static void Calistir()
        {
            FileInfo NewFile = new FileInfo(@"C:\Test\HedefDizini\NewFile.txt");

            if (NewFile.Exists)
            {
                NewFile.Delete();
            }

            NewFile.CreateText();
            Console.WriteLine("Oluşturulma Tarihi: " + NewFile.CreationTime);
            Console.WriteLine("Son Erişim Tarihi: " + NewFile.LastAccessTime);
            Console.WriteLine("Son Değiştirilme Tarihi: " + NewFile.LastWriteTime);
            Console.WriteLine("Bulunduğu Dizinin Adı: " + NewFile.DirectoryName);
            Console.WriteLine("Dosyanın Adı: " + NewFile.Name);
            Console.WriteLine("Dosyanın Tam Adı: " + NewFile.FullName);
            Console.WriteLine("Dosyanın Uzantısı: " + NewFile.Extension);

            NewFile.CopyTo(@"C:\Test\NewFile_Kopya.txt");

            Console.ReadLine();
        }
    }
}
