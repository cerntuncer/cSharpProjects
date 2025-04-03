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
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(4);
            list.Add(5);
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
