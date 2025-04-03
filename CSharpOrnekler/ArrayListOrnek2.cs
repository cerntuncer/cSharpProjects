using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class ArrayListOrnek2
    {
        public static void ArrayList2()
        {
            ArrayList list = new ArrayList();//ArrayList in namespace i System.Collections eklenmeli
            list.Add(1);
            list.Add(2);
            list.Add(7);
            int toplam = 0;
            for (int i = 0; i < list.Count; i++)
            {
                toplam += (int)list[i];
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
