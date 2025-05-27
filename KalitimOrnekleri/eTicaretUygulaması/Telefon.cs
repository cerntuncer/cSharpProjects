using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretUygulaması
{
    public class Telefon : Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public string TelefonValidasyon()
        {
            string hata = "";
            if (string.IsNullOrWhiteSpace(Marka))
                hata += "Marka boş olamaz.\n";
            if (string.IsNullOrWhiteSpace(Model))
                hata += "Model boş olamaz.\n";
            return this.Validasyon() + hata;
        }
    }

}
