using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretUygulaması
{
    public class Kitap : Urun
    {
        public int ISBN { get; set; }
        public string Yazar { get; set; }

        public string KitapValidasyon()
        {
            string hata = "";
            if (ISBN == 0)
                hata += "ISBN boş olamaz.\n";
            if (string.IsNullOrWhiteSpace(Yazar))
                hata += "Yazar boş olamaz.\n";
            return this.Validasyon() + hata;
        }
    }

}
