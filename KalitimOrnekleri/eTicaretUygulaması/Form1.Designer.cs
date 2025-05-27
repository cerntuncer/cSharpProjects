namespace eTicaretUygulaması
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
            this.btnKitapTest = new System.Windows.Forms.Button();
            this.btnTelefonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitapTest
            // 
            this.btnKitapTest.Location = new System.Drawing.Point(108, 56);
            this.btnKitapTest.Name = "btnKitapTest";
            this.btnKitapTest.Size = new System.Drawing.Size(75, 54);
            this.btnKitapTest.TabIndex = 0;
            this.btnKitapTest.Text = "Kitap Test Et";
            this.btnKitapTest.UseVisualStyleBackColor = true;
            this.btnKitapTest.Click += new System.EventHandler(this.btnKitapTest_Click);
            // 
            // btnTelefonTest
            // 
            this.btnTelefonTest.Location = new System.Drawing.Point(108, 116);
            this.btnTelefonTest.Name = "btnTelefonTest";
            this.btnTelefonTest.Size = new System.Drawing.Size(75, 58);
            this.btnTelefonTest.TabIndex = 1;
            this.btnTelefonTest.Text = "Telefon Test Et";
            this.btnTelefonTest.UseVisualStyleBackColor = true;
            this.btnTelefonTest.Click += new System.EventHandler(this.btnTelefonTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelefonTest);
            this.Controls.Add(this.btnKitapTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitapTest;
        private System.Windows.Forms.Button btnTelefonTest;
    }
}

