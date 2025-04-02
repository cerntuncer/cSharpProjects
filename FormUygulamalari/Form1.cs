using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birinciSayi, ikinciSayi, toplam;
            birinciSayi = Convert.ToInt32(textBox1.Text);
            ikinciSayi = Convert.ToInt32(textBox2.Text);
            toplam = birinciSayi + ikinciSayi;
            MessageBox.Show("Toplam:" + toplam);

        }
    }
}
