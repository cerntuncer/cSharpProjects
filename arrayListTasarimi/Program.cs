using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayListTasarimi
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyArrayList liste = new MyArrayList();

            liste.Add("Merhaba");
            liste.Add(123);
            liste.Add(3.14);
            liste.Insert(1, "Ceren");
            liste.RemoveAt(0);

            Console.WriteLine("Liste: " + liste.ToString());
            Console.WriteLine("2. indeks: " + liste.Get(2));
            Console.WriteLine("Toplam eleman: " + liste.Count);
        }
    }
}
