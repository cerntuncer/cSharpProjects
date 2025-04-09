using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliYikamaTakipSistemi
{
    public class HaliBilgileri
    {
        public double Metrekare { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public string Durum { get; set; } // "Yıkamada" veya "Teslim Edildi"

        public double Ucret => Metrekare * 20;
    }
}
