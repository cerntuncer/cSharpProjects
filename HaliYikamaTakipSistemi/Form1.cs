using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliYikamaTakipSistemi
{
    public partial class Form1 : Form
    {
        private List<MusteriBilgileri> musteriler = new List<MusteriBilgileri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            // Girişler boş mu kontrol et
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Lütfen tüm müşteri bilgilerini doldurun.");
                return;
            }

            // Yeni müşteri nesnesi oluştur
            MusteriBilgileri musteri = new MusteriBilgileri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Adres = txtAdres.Text
            };

            musteriler.Add(musteri);
            cmbMusteriler.Items.Add(musteri); // Combobox'a ekle

            MessageBox.Show("Müşteri başarıyla eklendi!");

            // Temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
        }

        private void btnHaliEkle_Click(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            if (!double.TryParse(txtMetrekare.Text, out double metrekare) || metrekare <= 0)
            {
                MessageBox.Show("Geçerli bir metrekare değeri girin.");
                return;
            }

            // Yeni halı nesnesi oluştur
            HaliBilgileri hali = new HaliBilgileri
            {
                Metrekare = metrekare,
                AlimTarihi = dtpAlim.Value,
                TeslimTarihi = dtpTeslim.Value,
                Durum = "Yıkamada"
            };

            // Seçilen müşteriye halıyı ekle
            MusteriBilgileri seciliMusteri = (MusteriBilgileri)cmbMusteriler.SelectedItem;
            seciliMusteri.Halilar.Add(hali);

            MessageBox.Show("Halı başarıyla eklendi!");

            // ✅ Hemen listeye ekle (durum dahil)
            string bilgi = $"{seciliMusteri.Ad} {seciliMusteri.Soyad} - {hali.Metrekare} m² - {hali.AlimTarihi.ToShortDateString()} → {hali.TeslimTarihi.ToShortDateString()} - Durum: {hali.Durum} - Ücret: {hali.Ucret} TL";
            lstHalilar.Items.Add(new ListViewItemData { Musteri = seciliMusteri, Hali = hali, Gosterim = bilgi });
            lstHalilar.DisplayMember = "Gosterim";

            // Alanları temizle
            txtMetrekare.Clear();
            dtpAlim.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now.AddDays(3);

        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHalilar.Items.Clear();

            if (cmbFiltre.SelectedItem == null)
                return;

            string secilenDurum = cmbFiltre.SelectedItem.ToString();

            foreach (var musteri in musteriler)
            {
                foreach (var hali in musteri.Halilar)
                {
                    if (hali.Durum == secilenDurum)
                    {
                        string bilgi = $"{musteri.Ad} {musteri.Soyad} - {hali.Metrekare} m² - {hali.AlimTarihi.ToShortDateString()} → {hali.TeslimTarihi.ToShortDateString()} - Ücret: {hali.Ucret} TL";
                        lstHalilar.Items.Add(new ListViewItemData { Musteri = musteri, Hali = hali, Gosterim = bilgi });
                    }
                }
            }

            lstHalilar.DisplayMember = "Gosterim";
        }
        private class ListViewItemData
        {
            public MusteriBilgileri Musteri { get; set; }
            public HaliBilgileri Hali { get; set; }
            public string Gosterim { get; set; }

            public override string ToString()
            {
                return Gosterim;
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHalilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen listeden bir halı seçin.");
                return;
            }

            // Seçili nesneyi al
            ListViewItemData secili = (ListViewItemData)lstHalilar.SelectedItem;

            // Durumu güncelle
            secili.Hali.Durum = "Teslim Edildi";

            MessageBox.Show("Halı durumu güncellendi!");

            // Listeyi yenile
            cmbFiltre_SelectedIndexChanged(null, null);
        }
    }
}
