using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliYikamaTakipSistemi
{
    public class MusteriBilgileri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public List<HaliBilgileri> Halilar { get; set; } = new List<HaliBilgileri>();

        public string TamAd => $"{Ad} {Soyad}";
        public override string ToString()
        {
            return TamAd;
        }
    }
}
