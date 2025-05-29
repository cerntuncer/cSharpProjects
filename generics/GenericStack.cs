using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class GenericStack<T>
    {
        private Node<T> tepe;

        public void Ekle(T veri) // Push
        {
            var yeni = new Node<T>(veri);
            yeni.Sonraki = tepe;
            tepe = yeni;
        }

        public T Cikar() // Pop
        {
            if (BosMu()) throw new Exception("Yığın boş!");
            var veri = tepe.Veri;
            tepe = tepe.Sonraki;
            return veri;
        }

        public T Bak() // Peek
        {
            if (BosMu()) throw new Exception("Yığın boş!");
            return tepe.Veri;
        }

        public bool BosMu()
        {
            return tepe == null;
        }
    }
}
