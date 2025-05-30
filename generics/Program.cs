using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new GenericStack<string>();
            stack.Ekle("Kitap");
            stack.Ekle("Defter");
            stack.Ekle("Kalem");
            Console.WriteLine("Yığından Çıkan: " + stack.Cikar());

            var kuyruk = new GenericQueue<int>();
            kuyruk.Ekle(5);
            kuyruk.Ekle(7);
            kuyruk.Ekle(10);
            kuyruk.Ekle(20);
            Console.WriteLine("Kuyruktan Çıkan: " + kuyruk.Cikar());

            var liste = new GenericLinkedList<char>();
            liste.BasaEkle('A');
            liste.SonaEkle('B');
            liste.SonaEkle('C');
            Console.WriteLine("Bağlı Liste:");
            liste.Listele();
            
        }
    }
}
