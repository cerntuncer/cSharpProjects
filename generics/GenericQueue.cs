using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class GenericQueue<T>
    {
        private Node<T> bas;
        private Node<T> son;

        public void Ekle(T veri) // Enqueue
        {
            var yeni = new Node<T>(veri);
            if (BosMu())
                bas = son = yeni;
            else
            {
                son.Sonraki = yeni;
                son = yeni;
            }
        }

        public T Cikar() // Dequeue
        {
            if (BosMu()) throw new Exception("Kuyruk boş!");
            var veri = bas.Veri;
            bas = bas.Sonraki;
            if (bas == null) son = null;
            return veri;
        }

        public T Bak()
        {
            if (BosMu()) throw new Exception("Kuyruk boş!");
            return bas.Veri;
        }

        public bool BosMu()
        {
            return bas == null;
        }
    }

}