using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTicaretUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapTest_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Adi = ""; // boş → hata verecek
            kitap.Fiyat = 0; // hata
            kitap.ISBN = 0; // hata
            kitap.Yazar = ""; // hata

            string hata = kitap.KitapValidasyon();

            if (hata != "")
                MessageBox.Show("Hatalar:\n" + hata);
            else
                MessageBox.Show("Kitap başarıyla eklendi.");
        }

        private void btnTelefonTest_Click(object sender, EventArgs e)
        {
            Telefon tel = new Telefon();
            tel.Adi = "iPhone 14";
            tel.Fiyat = 0; // hata
            tel.Marka = ""; // hata
            tel.Model = ""; // hata

            string hata = tel.TelefonValidasyon();

            if (hata != "")
                MessageBox.Show("Hatalar:\n" + hata);
            else
                MessageBox.Show("Telefon başarıyla eklendi.");
        }
    }
}
