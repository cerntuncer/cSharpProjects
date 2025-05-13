using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemelOrnek
{
    public class Tasit
    {
        public int TekerlekSayisi;
    }

    public class Otomobil : Tasit
    {
        public Otomobil()
        {
            TekerlekSayisi = 4;
        }
    }

    public class Motorsiklet : Tasit
    {
        public Motorsiklet()
        {
            TekerlekSayisi = 2;
        }
    }
}

