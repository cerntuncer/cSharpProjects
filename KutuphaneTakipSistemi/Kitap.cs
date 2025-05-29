using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakipSistemi
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public bool OduncVerildiMi { get; set; } = false;

        public Kitap(int id, string ad, string yazar, string tur)
        {
            Id = id;
            Ad = ad;
            Yazar = yazar;
            Tur = tur;
        }

        public override string ToString()
        {
            return $"{Id} - {Ad} | {Yazar} | {Tur} | {(OduncVerildiMi ? "Ödünçte" : "Rafta")}";
        }
    }

}
