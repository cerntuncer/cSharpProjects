using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{

    public class Node<T>
    {
        public T Veri { get; set; }
        public Node<T> Sonraki { get; set; }

        public Node(T veri)
        {
            Veri = veri;
            Sonraki = null;
        }
    }
}
