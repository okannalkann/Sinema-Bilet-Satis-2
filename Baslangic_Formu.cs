using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sinema_Bilet_Satis
{
    public partial class Baslangic_Formu : Form
    {
        public Baslangic_Formu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=OKAN-BILGISAYAR;Initial Catalog=EnSonSinemaBiletSatis;Integrated Security=True");

        private void btnYonetımGırıs_Click(object sender, EventArgs e)
        {
            try
            {
                LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
                con.Open();
                SqlParameter prm1 = new SqlParameter("@P1", txtYonetimKullanıcıAdı.Text);
                SqlParameter prm2 = new SqlParameter("@P2", txtYonetimSifre.Text);
                string sql = "select * FROM Yonetim_Calısanı WHERE yonetim_k_adi=@P1 and yonetim_sifre=@P2";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   
                    MessageBox.Show("Giriş Başarılı.. Hoşgeldin " + txtKullaniciAdi.Text);
                    Form YonetimFormu = new YonetimFormu();
                    YonetimFormu.ShowDialog();
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnYonetımCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            try
            {

                LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
                con.Open();
                SqlParameter prm1 = new SqlParameter("@P1", txtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("@P2", TxtSifre.Text);
                string sql = "select * FROM Personeller WHERE k_adi=@P1 and sifre=@P2";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    MessageBox.Show("Giriş Başarılı.. Hoşgeldin " + txtKullaniciAdi.Text);
                    Form Filmler = new FilmSec();
                    Filmler.ShowDialog();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                } con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPersonelCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void Saat_Gosterici_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = (DateTime.Now.Hour) + ":" + (DateTime.Now.Minute) + ":" + (DateTime.Now.Second).ToString();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Saat_Gosterici.Start();
        }
    }
}
