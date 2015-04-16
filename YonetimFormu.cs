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
    public partial class YonetimFormu : Form
    {
        public YonetimFormu()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source=OKAN-BILGISAYAR;Initial Catalog=EnSonSinemaBiletSatis;Integrated Security=True");
        void baglantiKur()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string sql = "INSERT INTO Filmler(Film_Adi,Film_Suresi,Kategori) VALUES('" + txtFilmAdi.Text + "','" + txtFilmSuresi.Text + "','" + txtFilmKategori.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(txtFilmAdi.Text + " / " + txtFilmSuresi.Text + " / " + txtFilmKategori.Text + " filmi eklendi");
            txtFilmAdi.Text = "";
            txtFilmKategori.Text = "";
            txtFilmSuresi.Text = "";
        }
        private void YonetimKayitGetir()
        {
            baglantiKur();
            string kayit = "SELECT * from Yonetim_Calisani";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Silinen_Personel_KayitGetir()
        {
            baglantiKur();
            string kayit = "SELECT * from Silinen_Personeller";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
        private void Silinen_yonetim_KayitGetir()
        {
            baglantiKur();
            string kayit = "SELECT * from Silinen_Personeller";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }
        private void PersonelKayitGetir()
        {
            baglantiKur();
            string kayit = "SELECT * from Personeller";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void YonetimFormu_Load(object sender, EventArgs e)
        {
            YonetimKayitGetir();
            PersonelKayitGetir();
            Silinen_Personel_KayitGetir();
            Silinen_yonetim_KayitGetir();
        }


        private void PersonelEkle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string sql = "INSERT INTO Personeller(k_adi,sifre,Calisma_Saati,maas,Adi,Soyadi,Yetki) VALUES('" + txtPersonelK_adi.Text + "','" + txtPersonelSifre.Text + "','" + txtPersonelCalisma_Saati.Text + "','"+txtPersonelMaas.Text+"','"+txtPersonelAdi.Text+"','"+txtPersonelSoyadi.Text+"','"+txtPersonelYetki.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(txtPersonelAdi.Text + txtPersonelSoyadi.Text +" Personellere kişi eklendi");
            txtFilmAdi.Text = "";
            txtFilmKategori.Text = "";
            txtFilmSuresi.Text = "";
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Personeller", con);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet, "Personeller");
            dataGridView2.DataSource = dtSet.Tables["Personeller"];
        }

        private void personel_kadrosu_Click(object sender, EventArgs e)
        {

        }
        void Silinen_Personel_ara()
        {
            baglantiKur();
            string kayit = "SELECT * from Silinen_Personeller where Adi=@isim";

            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@isim", txt_Silinen_Per_Arama.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();

        }
        void Personel_ara()
        {
            baglantiKur();
            string kayit = "SELECT * from Personeller where Adi=@isim";

            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@isim", txtPersonel_Ara.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }
        void silinen_personel_veri_cek()
        {
            baglantiKur();

            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "Select * from Silinen_Personeller";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Dispose();
                komut.Dispose();
                con.Close();
                    txtSilinen_Per_ID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                    txt_Silinen_Per_K_adi.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                    txt_Silinen_Per_sifre.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                    txt_Silinen_Per_Calisma_saati.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                    txt_Silinen_Per_Maas.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
                    txt_Silinen_Per_Adi.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
                    txt_Silinen_Per_Soyadi.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
                    txt_Silinen_Per_Yetki.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
                    txtPersonelSilinmeTarihi.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();
            }
            else
            {
                komut.Dispose();
                con.Close();
                dr.Dispose();
            }
            }
            


        void personel_veri_cek()
        {
            baglantiKur();

            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "Select * from Personeller";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Dispose();
                komut.Dispose();
                con.Close();
                txtGuncellePersonel_ID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtGuncelleK_Adi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtGuncelleSifre.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtGuncelleCalismaSaati.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtGuncelleMaas.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                txtGuncelleAdi.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                txtGuncelleSoyadi.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                txtGuncelleYetki.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

            }
            else
            {
                 MessageBox.Show("veri cekilemedi");
                komut.Dispose();
                con.Close();
                dr.Dispose();
            }

        }
        void yonetim_veri_cek()
        {
            baglantiKur();

            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "Select * from Yonetim_Calisani";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Dispose();
                komut.Dispose();
                con.Close();
                txtGuncelle_YonetimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtGuncelle_K_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtGuncelle_Sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtGuncelle_Adi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGuncelle_Soyadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtGuncelle_Yetki.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtGuncelle_Maas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("veri cekilemedi");
                komut.Dispose();
                con.Close();
                dr.Dispose();
            }
        }
        void silinmis_yonetim_veri_cek()
        {
            baglantiKur();

            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "Select * from Yonetim_Calisani";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Dispose();
                komut.Dispose();
                con.Close();
                Silinmis_Yonetim_ID.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                Silinmis_Yonetim_K_adi.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                Silinmis_Yonetim_Sifre.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
                Silinmis_Yonetim_Adi.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
                Silinmis_Yonetim_Soyadi.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
                Silinmis_Yonetim_Yetki.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
                Silinmis_Yonetim_Maas .Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("veri cekilemedi");
                komut.Dispose();
                con.Close();
                dr.Dispose();
            }
        }
        private void Personel_Ara_Click(object sender, EventArgs e)
        {
            Personel_ara();
            personel_veri_cek();

        }

        void YonetimArama()
        {
            baglantiKur();
            string kayit = "SELECT * from Yonetim_Calisani where Adi=@isim";

            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@isim", txtYonetimAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Personel_Guncelle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string kayit = "update Personeller set k_adi=@k_adi,sifre=@sifre,Calisma_Saati=@Calisma_Saati,maas=@maas,Adi=@Adi,Soyadi=@Soyadi,Yetki=@Yetki where Personel_ID='"+txtGuncellePersonel_ID.Text+"'";
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@k_adi", txtGuncelleK_Adi.Text);
            komut.Parameters.AddWithValue("@sifre", txtGuncelleSifre.Text);
            komut.Parameters.AddWithValue("@Calisma_Saati", txtGuncelleCalismaSaati.Text);
            komut.Parameters.AddWithValue("@maas", txtGuncelleMaas.Text);
            komut.Parameters.AddWithValue("@Adi", txtGuncelleAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", txtGuncelleSoyadi.Text);
            komut.Parameters.AddWithValue("@Yetki", txtGuncelleYetki.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Personeller", con);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet, "Personeller");
            dataGridView2.DataSource = dtSet.Tables["Personeller"];
        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            personel_veri_cek();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            yonetim_veri_cek();
        }
        void yonetim_ekle()
        {
            baglantiKur();
            string kayit = "update Yonetim_Calisani set k_adi=@k_adi,sifre=@sifre,Adi=@Adi,Soyadi=@Soyadi,Yetki=@Yetki,Maas=@Maas where Yonetim_ID='" + txtGuncelle_YonetimID.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@k_adi", txtGuncelle_K_Adi.Text);
            komut.Parameters.AddWithValue("@sifre", txtGuncelle_Sifre.Text);
            komut.Parameters.AddWithValue("@Adi", txtGuncelle_Adi.Text);
            komut.Parameters.AddWithValue("@Soyadi", txtGuncelle_Soyadi.Text);
            komut.Parameters.AddWithValue("@Yetki", txtGuncelle_Yetki.Text);
            komut.Parameters.AddWithValue("@Maas", txtGuncelle_Maas.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Yonetim_Calisani", con);
            DataSet dtSet = new DataSet();

            dtAdapter.Fill(dtSet, "Yonetim_Calisani");
            dataGridView1.DataSource = dtSet.Tables["Yonetim_Calisani"];
        }
        private void Yonetim_Guncelle_Click(object sender, EventArgs e)
        {
            yonetim_ekle();   
        }

        private void Datagridview_Guncelle_Tick(object sender, EventArgs e)
        {

        }

        private void BtnYonetimAra_Click(object sender, EventArgs e)
        {
            YonetimArama();
            yonetim_veri_cek();
        }
        void personel_sil()
        {
            baglantiKur();
            string kayit = "Delete From Personeller where Personel_ID='" + txtGuncellePersonel_ID.Text + "'";
            string sql = "INSERT INTO Silinen_Personeller(k_adi,sifre,Calisma_Saati,maas,Adi,Soyadi,Yetki,Silinme_Tarihi) VALUES('" + txtGuncelleK_Adi.Text + "','" + txtGuncelleSifre.Text + "','" + txtGuncelleCalismaSaati.Text + "','" + txtGuncelleMaas.Text + "','" + txtGuncelleAdi.Text + "','" + txtGuncelleSoyadi.Text + "','" + txtGuncelleYetki.Text + "','" + DateTime.Now.ToShortDateString() + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel Silindi");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Personeller", con);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet, "Personeller");
            dataGridView2.DataSource = dtSet.Tables["Personeller"];
        }
        void yonetim_sil()
        {
            baglantiKur();
            string kayit = "Delete From Yonetim_Calisani where Personel_ID='" + txtGuncelle_YonetimID.Text + "'";
            string sql = "INSERT INTO Silinen_Personeller(k_adi,sifre,Adi,Soyadi,Yetki,Maas,Silinme_Tarihi) VALUES('" + txtGuncelleK_Adi.Text + "','" + txtGuncelleSifre.Text + "','" + txtGuncelleAdi.Text + "','" + txtGuncelleSoyadi.Text + "','" + txtGuncelleYetki.Text + "','" + txtGuncelle_Maas.Text+"','"+ DateTime.Now.ToShortDateString() + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Başarıyla Silindi");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Yonetim_Calisani", con);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet, "Yonetim_Calisani");
            dataGridView3.DataSource = dtSet.Tables["Yonetim_Calisani"];
        }
        private void button8_Click(object sender, EventArgs e)
        {
            personel_sil();
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            silinen_personel_veri_cek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string kayit = "Delete From Silinen_Personeller where Personel_ID='" + txtSilinen_Per_ID.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Personel kökten Silindi");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Silinen_Personeller", con);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet, "Silinen_Personeller");
            dataGridView3.DataSource = dtSet.Tables["Silinen_Personeller"];
        }

        private void btnSilinenPer_Ara_Click(object sender, EventArgs e)
        {
            Silinen_Personel_ara();
            silinen_personel_veri_cek();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yonetim_sil();
        }

        private void Btn_Silinmis_Yonetım_Ekle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string kayit2 = "Delete From Silinen_Personeller where Personel_ID='" + txtSilinen_Per_ID.Text + "'";
            SqlCommand komut2 = new SqlCommand(kayit2, con);
            komut2.ExecuteNonQuery();
            string kayit = "INSERT INTO Yonetim_Calisani(k_adi,sifre,Adi,Soyadi,Yetki,Maas) VALUES('" + Silinmis_Yonetim_K_adi.Text + "','" + Silinmis_Yonetim_Sifre.Text + "','" + Silinmis_Yonetim_Adi.Text + "','" + Silinmis_Yonetim_Soyadi.Text + "','" + Silinmis_Yonetim_Yetki.Text + "','" + Silinmis_Yonetim_Maas.Text + "')";
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bilgiler Güncellendi.");
            SqlDataAdapter dtAdapter = new SqlDataAdapter("select * from Silinmis_Personeller", con);
            DataSet dtSet = new DataSet();

            dtAdapter.Fill(dtSet, "Silinmis_Personeller");
            dataGridView1.DataSource = dtSet.Tables["Silinmis_Personeller"];
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            silinmis_yonetim_veri_cek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

    }
}
