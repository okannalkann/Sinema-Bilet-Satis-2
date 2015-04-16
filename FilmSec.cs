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
    public partial class FilmSec : Form
    {
        public FilmSec()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=OKAN-BILGISAYAR;Initial Catalog=EnSonSinemaBiletSatis;Integrated Security=True");

        private void Bilet_Al_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (comboSalonAdi.SelectedIndex != -1 && comboFilmAdi.SelectedIndex != -1 && comboSeans.SelectedIndex != -1)
            {
                BiletSatis bilet_satisi = new BiletSatis();
                bilet_satisi.film_Adi = comboFilmAdi.Text;
                bilet_satisi.salon_Adi = comboSalonAdi.Text;
                bilet_satisi.seans = comboSeans.Text;
                bilet_satisi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen film bilgilerini eksiksiz doldurunuz.");
            }
            
        }

        private void FilmSec_Load(object sender, EventArgs e)
        {

        }
        void bilgiAl(string sql, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglantiKur();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmb.Items.Add(oku[1].ToString());
            }
            con.Close();
        }
        void baglantiKur()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void comboFilmAdi_Click(object sender, EventArgs e)
        {
            bilgiAl("SELECT * FROM Filmler", comboFilmAdi);
        }

        private void comboSalonAdi_Click(object sender, EventArgs e)
        {
            bilgiAl("SELECT * FROM Salonlar", comboSalonAdi);
        }
        private void Bilet_Al_Click_1(object sender, EventArgs e)
        {
            if (comboSalonAdi.SelectedIndex != -1 && comboFilmAdi.SelectedIndex != -1 && comboSeans.SelectedIndex != -1)
            {
                BiletSatis Bilet_Satis = new BiletSatis();
                Bilet_Satis.film_Adi = comboFilmAdi.Text;
                Bilet_Satis.salon_Adi = comboSalonAdi.Text;
                Bilet_Satis.seans = comboSeans.Text;
                Bilet_Satis.Show();
            }
            else
            {
                MessageBox.Show("Lütfen film bilgilerini eksiksiz doldurunuz.");
            }  
        }
    }
}
