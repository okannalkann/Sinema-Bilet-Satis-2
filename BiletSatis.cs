using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace Sinema_Bilet_Satis
{
    public partial class BiletSatis : Form
    {
        public BiletSatis()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=OKAN-BILGISAYAR;Initial Catalog=EnSonSinemaBiletSatis;Integrated Security=True");
        public string film_Adi = "";
        public string salon_Adi = "";
        public string seans = "";
        int filmID = 0;
        int salonID = 0;
        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();   
        void baglantiKur()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            //if (((Button)sender).BackColor != Color.Red)
            if (((Button)sender).BackColor == Color.Blue) // mavi
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if (((Button)sender).BackColor == Color.Orange) // turuncu
            {
                ((Button)sender).BackColor = Color.Blue;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else // kırmızı
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
                txtKoltukIptal.Text = koltuk;
            }
        }
        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }
            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }
            txtKoltuk.Text = koltuk;
        }
        private void BiletSatis_Load(object sender, EventArgs e)
        {
            Saat_Gosterici.Start();
            txtFilmAdi.Text = film_Adi;
            txtSalonAdi.Text = salon_Adi;
            txtSeans.Text = seans;
            filmID = Convert.ToInt32(araGetir("SELECT * FROM Filmler WHERE Film_Adi='" + film_Adi + "'"));
            salonID = Convert.ToInt32(araGetir("SELECT * FROM Salonlar WHERE Salon_Adi='" + salon_Adi + "'"));
            LogAl();
            LogAl2();
        }
        private void Saat_Gosterici_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
        }
        string araGetir(string sql)
        {
            baglantiKur();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            string deger = oku[0].ToString();
            con.Close();
            return deger;
        }

        void biletAyir()
        {
            baglantiKur();
            for (int i = 0; i < koltuklar.Count; i++)
            {
                string sql = @"insert into Bilet_Satis(Ad_Soyad,Film_ID,Salon_ID,seans,Koltuklar,Tarih,Satis_Saati,Fiyat)values(@Ad_Soyad,@Film_ID,@Salon_ID,@seans,@Koltuklar,@Tarih,@Satis_Saati,@Fiyat)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ad_Soyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Film_ID", filmID);
                cmd.Parameters.AddWithValue("@Salon_ID", salonID);
                cmd.Parameters.AddWithValue("@seans", txtSeans.Text);
                this.Controls.Find("btn" + koltuklar[i].ToString(), true)[0].BackColor = Color.Red;
                cmd.Parameters.AddWithValue("@Koltuklar", Convert.ToInt32(koltuklar[i]));
                cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Satis_Saati", lblSaat.Text);
                int Fiyat = 0;
                if (radioOgrenci.Checked == true)
                {
                    Fiyat = 10;
                }
                else if (radioTam.Checked == true)
                {
                    Fiyat = 12;   
                }
                txtFiyat.Text = Fiyat.ToString();
                cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                cmd.ExecuteNonQuery();
                
            }

            con.Close();
        }
       
        
        private void BiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltuk.Text != "")
            {
                if (txtKoltuk.Text != "" && txtAdSoyad.Text != "")
                {
                    biletAyir();
                    MessageBox.Show(txtAdSoyad.Text + " " +  " bilgili kişinin " + txtKoltuk.Text + " no'lu koltukları ayrılmıştır");
                    txtKoltuk.Text = "";
                    txtAdSoyad.Text = "";
                    koltuklar.Clear();
                }
                else
                {
                    MessageBox.Show("Tüm bilgileri eksiksiz doldurmalısınız.");
                }
            }
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz.", "Dikkat");
            }
        }

        void LogAl()
        {
            baglantiKur();
            string sql = "SELECT * FROM Bilet_Satis WHERE Film_ID=" + filmID + " AND Salon_ID=" + salonID + " AND seans='" + seans + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                string koltuk_No = oku[5].ToString();
                this.Controls.Find("btn" + koltuk_No, true)[0].BackColor = Color.Red;
            }
            con.Close();
        }
        void LogAl2()
        {
            baglantiKur();
            string sql = "SELECT * FROM Rezerve WHERE Film_ID=" + filmID + " AND Salon_ID=" + salonID + " AND seans='" + seans + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                string koltuk_No = oku[5].ToString();
                this.Controls.Find("btn" + koltuk_No, true)[0].BackColor = Color.Pink;
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rezervasyon_Click(object sender, EventArgs e)
        {
          if (txtKoltuk.Text != "")
            {
                if (txtKoltuk.Text != "" && txtAdSoyad.Text != "")
                {
                    biletRezerve();
                    MessageBox.Show(txtAdSoyad.Text + " " +  " bilgili kişinin " + txtKoltuk.Text + " no'lu koltukları Rezerve Edilmiştir.");
                    txtKoltuk.Text = "";
                    txtAdSoyad.Text = "";
                    koltuklar.Clear();
                }
                else
                {
                    MessageBox.Show("Tüm bilgileri eksiksiz doldurmalısınız.");
                }
            }
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz.", "Dikkat");
            }
        }
    
        void biletRezerve()
        {
            baglantiKur();
            for (int i = 0; i < koltuklar.Count; i++)
            {
                string sql = @"insert into Rezerve(Ad_Soyad,Film_ID,Salon_ID,seans,Koltuklar,Tarih,Satis_Saati,Fiyat)values(@Ad_Soyad,@Film_ID,@Salon_ID,@seans,@Koltuklar,@Tarih,@Satis_Saati,@Fiyat)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ad_Soyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Film_ID", filmID);
                cmd.Parameters.AddWithValue("@Salon_ID", salonID);
                cmd.Parameters.AddWithValue("@seans", txtSeans.Text);
                this.Controls.Find("btn" + koltuklar[i].ToString(), true)[0].BackColor = Color.Pink;
                cmd.Parameters.AddWithValue("@Koltuklar", Convert.ToInt32(koltuklar[i]));
                cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Satis_Saati", lblSaat.Text);
                int Fiyat = 0;
                if (radioOgrenci.Checked == true)
                {
                    Fiyat = 10;
                }
                else if (radioTam.Checked == true)
                {
                    Fiyat = 12;   
                }
                txtFiyat.Text = Fiyat.ToString();
                cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                cmd.ExecuteNonQuery();
                
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void Bilet_Iptal_Click_1(object sender, EventArgs e)
        {
            if (txtKoltukIptal.Text != "")
            {
                baglantiKur();
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    string sql = "DELETE FROM Bilet_Satis WHERE Koltuklar=" + Convert.ToInt32(iptalKoltuk[i]);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    this.Controls.Find("btn" + iptalKoltuk[i].ToString(), true)[0].BackColor = Color.Blue;
                }

                con.Close();
                iptalKoltuk.Clear();
                MessageBox.Show(txtKoltuk.Text + " koltuk numaraları bileti iptal edilmiştir.");
                txtKoltukIptal.Text = "";
                txtAdSoyad.Text = "";
                
            }
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz.");
            }
        }
    }
    
 
    }

