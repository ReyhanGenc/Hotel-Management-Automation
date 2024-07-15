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
    public partial class RezervasyonAra : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Otel_Uygulama; username=postgres; password=Ray81194!");
        public RezervasyonAra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select * from public.\"odaNo_ile_rez_getir\"(@oda_no)", baglanti);
            komut1.Parameters.AddWithValue("@oda_no", int.Parse(OdaNo.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OdaRezListele.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
