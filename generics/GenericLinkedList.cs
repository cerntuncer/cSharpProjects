using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class GenericLinkedList<T>
    {
        private Node<T> bas;

        public void BasaEkle(T veri)
        {
            var yeni = new Node<T>(veri);
            yeni.Sonraki = bas;
            bas = yeni;
        }

        public void SonaEkle(T veri)
        {
            var yeni = new Node<T>(veri);
            if (bas == null)
                bas = yeni;
            else
            {
                var gecici = bas;
                while (gecici.Sonraki != null)
                    gecici = gecici.Sonraki;
                gecici.Sonraki = yeni;
            }
        }

        public void Listele()
        {
            var gecici = bas;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Veri);
                gecici = gecici.Sonraki;
            }
        }
    }
}
