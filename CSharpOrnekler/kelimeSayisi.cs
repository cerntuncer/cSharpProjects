using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class kelimeSayisi
    {
        public static void kelimeSayisiBul()
        {
            string sentence;
            Console.WriteLine("Stringi gir:");
            sentence = Console.ReadLine();
            string[] words=sentence.Split(' ');
            Console.WriteLine("Kelime sayısı:" + words.Length);
            Console.ReadKey();
        }
    }
}
