namespace Sinema_Bilet_Satis
{
    partial class FilmSec
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
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboSeans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bilet_Al = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(136, 39);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(121, 21);
            this.comboFilmAdi.TabIndex = 0;
            this.comboFilmAdi.Click += new System.EventHandler(this.comboFilmAdi_Click);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(136, 66);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(80, 21);
            this.comboSalonAdi.TabIndex = 1;
            this.comboSalonAdi.Click += new System.EventHandler(this.comboSalonAdi_Click);
            // 
            // comboSeans
            // 
            this.comboSeans.FormattingEnabled = true;
            this.comboSeans.Items.AddRange(new object[] {
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00"});
            this.comboSeans.Location = new System.Drawing.Point(136, 93);
            this.comboSeans.Name = "comboSeans";
            this.comboSeans.Size = new System.Drawing.Size(80, 21);
            this.comboSeans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film Seansı";
            // 
            // Bilet_Al
            // 
            this.Bilet_Al.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilet_Al.Location = new System.Drawing.Point(263, 39);
            this.Bilet_Al.Name = "Bilet_Al";
            this.Bilet_Al.Size = new System.Drawing.Size(114, 48);
            this.Bilet_Al.TabIndex = 6;
            this.Bilet_Al.Text = "Bilet Al";
            this.Bilet_Al.UseVisualStyleBackColor = true;
            this.Bilet_Al.Click += new System.EventHandler(this.Bilet_Al_Click_1);
            // 
            // FilmSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Bilet_Satis.Properties.Resources.Gentle_breeze_1366x768_hd_laptops;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 292);
            this.Controls.Add(this.Bilet_Al);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSeans);
            this.Controls.Add(this.comboSalonAdi);
            this.Controls.Add(this.comboFilmAdi);
            this.Name = "FilmSec";
            this.Text = "FilmSec";
            this.Load += new System.EventHandler(this.FilmSec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.ComboBox comboSeans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bilet_Al;
    }
}