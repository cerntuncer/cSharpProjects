using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basiteTicaret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Urun nesnesi
            Urun urun = new Urun();
            urun.No = 1;
            urun.Adi = "Ürün 1";
            urun.Aciklama = "Açıklama 1";
            urun.Fiyat = 149.99m;

            // Kitap nesnesi
            Kitap kitap = new Kitap();
            kitap.ISBN = 1234567;
            kitap.Yazar = "Yazar 1";

            // Telefon nesnesi
            Telefon telefon = new Telefon();
            telefon.Marka = "Samsung";
            telefon.Model = "Galaxy XXX";

            // Mesaj kutusunda göster
            MessageBox.Show("Kitap: ISBN = " + kitap.ISBN + ", Yazar = " + kitap.Yazar);
            MessageBox.Show("Telefon: Marka = " + telefon.Marka + ", Model = " + telefon.Model);
            MessageBox.Show("Ürün: No = " + urun.No + ", Ad = " + urun.Adi + ", Fiyat = " + urun.Fiyat);
        }
    }
}
