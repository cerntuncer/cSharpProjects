using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakipSistemi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private List<Uye> uyeler = new List<Uye>();
        private int kitapIdSayac = 1;
        private int uyeIdSayac = 1;

        public void KitapEkle()
        {
            Console.Write("Kitap Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Yazar: ");
            string yazar = Console.ReadLine();

            Console.Write("Tür: ");
            string tur = Console.ReadLine();

            Kitap yeniKitap = new Kitap(kitapIdSayac++, ad, yazar, tur);
            kitaplar.Add(yeniKitap);

            Console.WriteLine("✅ Kitap başarıyla eklendi!");
        }
        public void KitapListele()
        {
            if (kitaplar.Count == 0)
            {
                Console.WriteLine("📭 Kütüphanede hiç kitap yok.");
                return;
            }

            Console.WriteLine("\n📚 Kitap Listesi:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
        public void UyeEkle()
        {
            Console.Write("Üye Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();

            Uye yeniUye = new Uye(uyeIdSayac++, adSoyad, telefon);
            uyeler.Add(yeniUye);

            Console.WriteLine("✅ Üye başarıyla eklendi!");
        }
        public void UyeListele()
        {
            if (uyeler.Count == 0)
            {
                Console.WriteLine("👥 Hiç üye kaydı yok.");
                return;
            }

            Console.WriteLine("\n👤 Üye Listesi:");
            foreach (var uye in uyeler)
            {
                Console.WriteLine(uye);
            }
        }
        public void KitapOduncVer()
        {
            KitapListele();
            Console.Write("\nÖdünç verilecek kitap ID: ");
            if (!int.TryParse(Console.ReadLine(), out int kitapId))
            {
                Console.WriteLine("Geçersiz kitap ID.");
                return;
            }

            Kitap secilenKitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);

            if (secilenKitap == null)
            {
                Console.WriteLine("❌ Kitap bulunamadı.");
                return;
            }

            if (secilenKitap.OduncVerildiMi)
            {
                Console.WriteLine("❗ Bu kitap zaten ödünç verilmiş.");
                return;
            }

            UyeListele();
            Console.Write("\nKitabı alacak üye ID: ");
            if (!int.TryParse(Console.ReadLine(), out int uyeId))
            {
                Console.WriteLine("Geçersiz üye ID.");
                return;
            }

            Uye secilenUye = uyeler.FirstOrDefault(u => u.Id == uyeId);

            if (secilenUye == null)
            {
                Console.WriteLine("❌ Üye bulunamadı.");
                return;
            }

            secilenKitap.OduncVerildiMi = true;
            secilenUye.OduncKitaplar.Add(secilenKitap);

            Console.WriteLine($"✅ {secilenKitap.Ad} kitabı {secilenUye.AdSoyad} adlı üyeye ödünç verildi.");
        }
        public void KitapIadeEt()
        {
            KitapListele();
            Console.Write("\nİade edilecek kitap ID: ");
            if (!int.TryParse(Console.ReadLine(), out int kitapId))
            {
                Console.WriteLine("Geçersiz kitap ID.");
                return;
            }

            Kitap secilenKitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);

            if (secilenKitap == null)
            {
                Console.WriteLine("❌ Kitap bulunamadı.");
                return;
            }

            if (!secilenKitap.OduncVerildiMi)
            {
                Console.WriteLine("❗ Bu kitap zaten rafta.");
                return;
            }

            // Kitabı ödünç almış üyeyi bul ve listeden çıkar
            Uye alanUye = uyeler.FirstOrDefault(u => u.OduncKitaplar.Contains(secilenKitap));
            if (alanUye != null)
            {
                alanUye.OduncKitaplar.Remove(secilenKitap);
            }

            secilenKitap.OduncVerildiMi = false;
            Console.WriteLine($"✅ {secilenKitap.Ad} kitabı iade edildi.");
        }

    }

}
