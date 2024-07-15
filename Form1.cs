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
    public partial class Form1 : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Otel_Uygulama; username=postgres; password=Ray81194!");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle formaGec = new MusteriEkle();
            formaGec.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.\"rezervasyon_listele\"()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonGuncelle formaGec = new RezervasyonGuncelle();
            formaGec.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RezervasyonSil formaGec = new RezervasyonSil();
            formaGec.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.\"musteri_listele\"()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnRezAra_Click(object sender, EventArgs e)
        {
            RezervasyonAra formaGec = new RezervasyonAra();
            formaGec.Show();
        }
    }
}
