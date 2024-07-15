using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vt_proje
{
    public partial class RezervasyonGuncelle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Otel_Uygulama; username=postgres; password=Ray81194!");

        public RezervasyonGuncelle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RezervasyonGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT * FROM public.rezervasyon_oda_guncelle(@rez_no, @oda_no)", baglanti);
            komut1.Parameters.AddWithValue("@rez_no", int.Parse(rezNo.Text));
            komut1.Parameters.AddWithValue("@oda_no", int.Parse(odaNo.Text));

            komut1.ExecuteNonQuery();
            baglanti.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
