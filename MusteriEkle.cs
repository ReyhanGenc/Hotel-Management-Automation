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
    public partial class MusteriEkle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Otel_Uygulama; username=postgres; password=Ray81194!");
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select * from public.\"musteri_ekle\"(@k_adi, @k_soyadi , @otel_no )",baglanti);
            komut1.Parameters.AddWithValue("@k_adi", mustAdi.Text);
            komut1.Parameters.AddWithValue("@k_soyadi", mustSoyadi.Text);
            komut1.Parameters.AddWithValue("@otel_no", int.Parse(mustOtelNo.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
