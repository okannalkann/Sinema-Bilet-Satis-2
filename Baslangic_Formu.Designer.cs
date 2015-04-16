namespace Sinema_Bilet_Satis
{
    partial class Baslangic_Formu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic_Formu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPersonelKullanıcıAdı = new System.Windows.Forms.Label();
            this.btnPersonelCıkıs = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.lblPersonelSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LblSaat = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYonetımCıkıs = new System.Windows.Forms.Button();
            this.lblYonetımSıfre = new System.Windows.Forms.Label();
            this.lblYonetımKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtYonetimSifre = new System.Windows.Forms.TextBox();
            this.txtYonetimKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btnYonetımGırıs = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Saat_Gosterici = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblPersonelKullanıcıAdı);
            this.groupBox1.Controls.Add(this.btnPersonelCıkıs);
            this.groupBox1.Controls.Add(this.btnPersonelGiris);
            this.groupBox1.Controls.Add(this.lblPersonelSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 199);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Giriş";
            // 
            // lblPersonelKullanıcıAdı
            // 
            this.lblPersonelKullanıcıAdı.AutoSize = true;
            this.lblPersonelKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKullanıcıAdı.Location = new System.Drawing.Point(6, 39);
            this.lblPersonelKullanıcıAdı.Name = "lblPersonelKullanıcıAdı";
            this.lblPersonelKullanıcıAdı.Size = new System.Drawing.Size(101, 20);
            this.lblPersonelKullanıcıAdı.TabIndex = 10;
            this.lblPersonelKullanıcıAdı.Text = "Kullanıcı Adı :";
            // 
            // btnPersonelCıkıs
            // 
            this.btnPersonelCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelCıkıs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonelCıkıs.Location = new System.Drawing.Point(137, 124);
            this.btnPersonelCıkıs.Name = "btnPersonelCıkıs";
            this.btnPersonelCıkıs.Size = new System.Drawing.Size(101, 32);
            this.btnPersonelCıkıs.TabIndex = 12;
            this.btnPersonelCıkıs.Text = "Çıkış";
            this.btnPersonelCıkıs.UseVisualStyleBackColor = true;
            this.btnPersonelCıkıs.Click += new System.EventHandler(this.btnPersonelCıkıs_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonelGiris.Location = new System.Drawing.Point(20, 124);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(101, 32);
            this.btnPersonelGiris.TabIndex = 7;
            this.btnPersonelGiris.Text = "Giriş";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // lblPersonelSifre
            // 
            this.lblPersonelSifre.AutoSize = true;
            this.lblPersonelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSifre.Location = new System.Drawing.Point(6, 78);
            this.lblPersonelSifre.Name = "lblPersonelSifre";
            this.lblPersonelSifre.Size = new System.Drawing.Size(98, 20);
            this.lblPersonelSifre.TabIndex = 11;
            this.lblPersonelSifre.Text = "Şifre             :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(122, 39);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(116, 25);
            this.txtKullaniciAdi.TabIndex = 8;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(122, 78);
            this.TxtSifre.Multiline = true;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(116, 25);
            this.TxtSifre.TabIndex = 9;
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.BackColor = System.Drawing.Color.Transparent;
            this.LblSaat.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSaat.Location = new System.Drawing.Point(440, 27);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(85, 40);
            this.LblSaat.TabIndex = 24;
            this.LblSaat.Text = "Saat";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(160, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 47);
            this.button6.TabIndex = 22;
            this.button6.Text = "Personel Girişi İçin Tıklayın";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(286, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 47);
            this.button5.TabIndex = 21;
            this.button5.Text = "Yönetim Girişi İçin Tıklayın";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnYonetımCıkıs);
            this.groupBox2.Controls.Add(this.lblYonetımSıfre);
            this.groupBox2.Controls.Add(this.lblYonetımKullanıcıAdı);
            this.groupBox2.Controls.Add(this.txtYonetimSifre);
            this.groupBox2.Controls.Add(this.txtYonetimKullanıcıAdı);
            this.groupBox2.Controls.Add(this.btnYonetımGırıs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(283, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 196);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetim Girişi";
            this.groupBox2.Visible = false;
            // 
            // btnYonetımCıkıs
            // 
            this.btnYonetımCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetımCıkıs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYonetımCıkıs.Location = new System.Drawing.Point(141, 124);
            this.btnYonetımCıkıs.Name = "btnYonetımCıkıs";
            this.btnYonetımCıkıs.Size = new System.Drawing.Size(101, 32);
            this.btnYonetımCıkıs.TabIndex = 19;
            this.btnYonetımCıkıs.Text = "Çıkış";
            this.btnYonetımCıkıs.UseVisualStyleBackColor = true;
            this.btnYonetımCıkıs.Click += new System.EventHandler(this.btnYonetımCıkıs_Click);
            // 
            // lblYonetımSıfre
            // 
            this.lblYonetımSıfre.AutoSize = true;
            this.lblYonetımSıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetımSıfre.Location = new System.Drawing.Point(10, 78);
            this.lblYonetımSıfre.Name = "lblYonetımSıfre";
            this.lblYonetımSıfre.Size = new System.Drawing.Size(98, 20);
            this.lblYonetımSıfre.TabIndex = 18;
            this.lblYonetımSıfre.Text = "Şifre             :";
            // 
            // lblYonetımKullanıcıAdı
            // 
            this.lblYonetımKullanıcıAdı.AutoSize = true;
            this.lblYonetımKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYonetımKullanıcıAdı.Location = new System.Drawing.Point(10, 39);
            this.lblYonetımKullanıcıAdı.Name = "lblYonetımKullanıcıAdı";
            this.lblYonetımKullanıcıAdı.Size = new System.Drawing.Size(101, 20);
            this.lblYonetımKullanıcıAdı.TabIndex = 17;
            this.lblYonetımKullanıcıAdı.Text = "Kullanıcı Adı :";
            // 
            // txtYonetimSifre
            // 
            this.txtYonetimSifre.Location = new System.Drawing.Point(126, 78);
            this.txtYonetimSifre.Multiline = true;
            this.txtYonetimSifre.Name = "txtYonetimSifre";
            this.txtYonetimSifre.PasswordChar = '*';
            this.txtYonetimSifre.Size = new System.Drawing.Size(116, 25);
            this.txtYonetimSifre.TabIndex = 16;
            // 
            // txtYonetimKullanıcıAdı
            // 
            this.txtYonetimKullanıcıAdı.Location = new System.Drawing.Point(126, 39);
            this.txtYonetimKullanıcıAdı.Multiline = true;
            this.txtYonetimKullanıcıAdı.Name = "txtYonetimKullanıcıAdı";
            this.txtYonetimKullanıcıAdı.Size = new System.Drawing.Size(116, 25);
            this.txtYonetimKullanıcıAdı.TabIndex = 15;
            // 
            // btnYonetımGırıs
            // 
            this.btnYonetımGırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYonetımGırıs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYonetımGırıs.Location = new System.Drawing.Point(24, 124);
            this.btnYonetımGırıs.Name = "btnYonetımGırıs";
            this.btnYonetımGırıs.Size = new System.Drawing.Size(101, 32);
            this.btnYonetımGırıs.TabIndex = 14;
            this.btnYonetımGırıs.Text = "Giriş";
            this.btnYonetımGırıs.UseVisualStyleBackColor = true;
            this.btnYonetımGırıs.Click += new System.EventHandler(this.btnYonetımGırıs_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(9, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(107, 89);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 23;
            this.PictureBox1.TabStop = false;
            // 
            // Saat_Gosterici
            // 
            this.Saat_Gosterici.Interval = 50;
            this.Saat_Gosterici.Tick += new System.EventHandler(this.Saat_Gosterici_Tick);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Bilet_Satis.Properties.Resources.Gentle_breeze_1366x768_hd_laptops;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblSaat);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPersonelKullanıcıAdı;
        private System.Windows.Forms.Button btnPersonelCıkıs;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Label lblPersonelSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label LblSaat;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYonetımCıkıs;
        private System.Windows.Forms.Label lblYonetımSıfre;
        private System.Windows.Forms.Label lblYonetımKullanıcıAdı;
        private System.Windows.Forms.TextBox txtYonetimSifre;
        private System.Windows.Forms.TextBox txtYonetimKullanıcıAdı;
        private System.Windows.Forms.Button btnYonetımGırıs;
        private System.Windows.Forms.Timer Saat_Gosterici;
    }
}