using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakipSistemi
{
    public class Uye
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public List<Kitap> OduncKitaplar { get; set; } = new List<Kitap>();

        public Uye(int id, string adSoyad, string telefon)
        {
            Id = id;
            AdSoyad = adSoyad;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{Id} - {AdSoyad} | {Telefon} | Ödünç Kitap Sayısı: {OduncKitaplar.Count}";
        }
    }

}
