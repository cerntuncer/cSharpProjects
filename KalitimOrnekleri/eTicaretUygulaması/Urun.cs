using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretUygulaması
{
    public class Urun
    {
        public int No { get; private set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }

        public Urun()
        {
            Random rnd = new Random();
            No = rnd.Next(1, 10000);
        }

        public string Validasyon()
        {
            string hata = "";
            if (string.IsNullOrWhiteSpace(Adi))
                hata += "Ad boş olamaz.\n";
            if (Fiyat <= 0)
                hata += "Fiyat 0'dan büyük olmalı.\n";
            return hata;
        }
    }

}
