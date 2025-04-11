namespace HaliYikamaTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grpHali = new System.Windows.Forms.GroupBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnHaliEkle = new System.Windows.Forms.Button();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.dtpAlim = new System.Windows.Forms.DateTimePicker();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.lblAlimTarihi = new System.Windows.Forms.Label();
            this.lblMetrekare = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.grpListe = new System.Windows.Forms.GroupBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.lstHalilar = new System.Windows.Forms.ListBox();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.grpMusteri.SuspendLayout();
            this.grpHali.SuspendLayout();
            this.grpListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMusteri
            // 
            this.grpMusteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMusteri.Controls.Add(this.btnMusteriEkle);
            this.grpMusteri.Controls.Add(this.txtAdres);
            this.grpMusteri.Controls.Add(this.txtTelefon);
            this.grpMusteri.Controls.Add(this.txtSoyad);
            this.grpMusteri.Controls.Add(this.txtAd);
            this.grpMusteri.Controls.Add(this.lblAdres);
            this.grpMusteri.Controls.Add(this.lblTelefon);
            this.grpMusteri.Controls.Add(this.lblSoyad);
            this.grpMusteri.Controls.Add(this.lblAd);
            this.grpMusteri.Location = new System.Drawing.Point(12, 12);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(256, 375);
            this.grpMusteri.TabIndex = 0;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Ekle";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(36, 264);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(155, 23);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(91, 158);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(91, 113);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(91, 71);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 5;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 33);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 4;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 164);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 119);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(6, 77);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 16);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // grpHali
            // 
            this.grpHali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpHali.Controls.Add(this.lblUcret);
            this.grpHali.Controls.Add(this.btnHaliEkle);
            this.grpHali.Controls.Add(this.dtpTeslim);
            this.grpHali.Controls.Add(this.dtpAlim);
            this.grpHali.Controls.Add(this.txtMetrekare);
            this.grpHali.Controls.Add(this.cmbMusteriler);
            this.grpHali.Controls.Add(this.lblTeslimTarihi);
            this.grpHali.Controls.Add(this.lblAlimTarihi);
            this.grpHali.Controls.Add(this.lblMetrekare);
            this.grpHali.Controls.Add(this.lblMusteri);
            this.grpHali.Location = new System.Drawing.Point(274, 12);
            this.grpHali.Name = "grpHali";
            this.grpHali.Size = new System.Drawing.Size(304, 375);
            this.grpHali.TabIndex = 1;
            this.grpHali.TabStop = false;
            this.grpHali.Text = "Halı Ekle";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(179, 80);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(71, 16);
            this.lblUcret.TabIndex = 9;
            this.lblUcret.Text = "Ücret: 0 TL";
            // 
            // btnHaliEkle
            // 
            this.btnHaliEkle.Location = new System.Drawing.Point(88, 264);
            this.btnHaliEkle.Name = "btnHaliEkle";
            this.btnHaliEkle.Size = new System.Drawing.Size(162, 23);
            this.btnHaliEkle.TabIndex = 8;
            this.btnHaliEkle.Text = "Halı Ekle";
            this.btnHaliEkle.UseVisualStyleBackColor = true;
            this.btnHaliEkle.Click += new System.EventHandler(this.btnHaliEkle_Click);
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Location = new System.Drawing.Point(101, 164);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(200, 22);
            this.dtpTeslim.TabIndex = 7;
            // 
            // dtpAlim
            // 
            this.dtpAlim.Location = new System.Drawing.Point(101, 119);
            this.dtpAlim.Name = "dtpAlim";
            this.dtpAlim.Size = new System.Drawing.Size(200, 22);
            this.dtpAlim.TabIndex = 6;
            // 
            // txtMetrekare
            // 
            this.txtMetrekare.Location = new System.Drawing.Point(101, 74);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(55, 22);
            this.txtMetrekare.TabIndex = 5;
            this.txtMetrekare.TextChanged += new System.EventHandler(this.txtMetrekare_TextChanged);
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(101, 28);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(197, 24);
            this.cmbMusteriler.TabIndex = 4;
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Location = new System.Drawing.Point(16, 164);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(88, 16);
            this.lblTeslimTarihi.TabIndex = 3;
            this.lblTeslimTarihi.Text = "Teslim Tarihi:";
            // 
            // lblAlimTarihi
            // 
            this.lblAlimTarihi.AutoSize = true;
            this.lblAlimTarihi.Location = new System.Drawing.Point(16, 119);
            this.lblAlimTarihi.Name = "lblAlimTarihi";
            this.lblAlimTarihi.Size = new System.Drawing.Size(73, 16);
            this.lblAlimTarihi.TabIndex = 2;
            this.lblAlimTarihi.Text = "Alım Tarihi:";
            // 
            // lblMetrekare
            // 
            this.lblMetrekare.AutoSize = true;
            this.lblMetrekare.Location = new System.Drawing.Point(16, 77);
            this.lblMetrekare.Name = "lblMetrekare";
            this.lblMetrekare.Size = new System.Drawing.Size(71, 16);
            this.lblMetrekare.TabIndex = 1;
            this.lblMetrekare.Text = "Metrekare:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(16, 36);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(53, 16);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // grpListe
            // 
            this.grpListe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpListe.Controls.Add(this.btnDurumGuncelle);
            this.grpListe.Controls.Add(this.lstHalilar);
            this.grpListe.Controls.Add(this.cmbFiltre);
            this.grpListe.Location = new System.Drawing.Point(588, 12);
            this.grpListe.Name = "grpListe";
            this.grpListe.Size = new System.Drawing.Size(529, 375);
            this.grpListe.TabIndex = 2;
            this.grpListe.TabStop = false;
            this.grpListe.Text = "Halı Listesi";
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(170, 264);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(134, 60);
            this.btnDurumGuncelle.TabIndex = 2;
            this.btnDurumGuncelle.Text = "Durumu Teslim Edildi Olarak Güncelle\n";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // lstHalilar
            // 
            this.lstHalilar.FormattingEnabled = true;
            this.lstHalilar.ItemHeight = 16;
            this.lstHalilar.Location = new System.Drawing.Point(26, 77);
            this.lstHalilar.Name = "lstHalilar";
            this.lstHalilar.Size = new System.Drawing.Size(497, 164);
            this.lstHalilar.TabIndex = 1;
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(26, 33);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(497, 24);
            this.cmbFiltre.TabIndex = 0;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 639);
            this.Controls.Add(this.grpListe);
            this.Controls.Add(this.grpHali);
            this.Controls.Add(this.grpMusteri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpHali.ResumeLayout(false);
            this.grpHali.PerformLayout();
            this.grpListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grpHali;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Label lblAlimTarihi;
        private System.Windows.Forms.Label lblMetrekare;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Button btnHaliEkle;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.DateTimePicker dtpAlim;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.GroupBox grpListe;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.ListBox lstHalilar;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label lblUcret;
    }
}

