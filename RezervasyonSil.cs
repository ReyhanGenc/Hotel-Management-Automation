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
    public partial class RezervasyonSil : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Otel_Uygulama; username=postgres; password=Ray81194!");

        public RezervasyonSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select * from public.\"rezervasyon_sil\"(@rez_no)", baglanti);
            komut1.Parameters.AddWithValue("@rez_no",int.Parse(rezNo.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
