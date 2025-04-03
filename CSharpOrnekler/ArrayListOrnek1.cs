using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOrnekler
{
    public class ArrayListOrnek1
    {
        public static void ArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("numaralı");
            list.Add("oyuncu");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}