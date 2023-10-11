using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transkript
{
    public partial class ogrGuncelle : Form
    {
        public ogrGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432; Database=ubys;user id=postgres;password=1234 ");

        

        private void btnekle_Click(object sender, EventArgs e)
        {
            int DersNotu = Convert.ToInt32(txtnot.Text);

            if (DersNotu >= 90)
            {
                txtharfnot.Text = "aa";
            }
            else if (DersNotu >= 80 && DersNotu < 90)
            {
                txtharfnot.Text = "ab";
            }
            else if (DersNotu >= 70 && DersNotu < 80)
            {
                txtharfnot.Text = "bb";
            }
            else if (DersNotu >= 80 && DersNotu < 90)
            {
                txtharfnot.Text = "ab";
            }
            else if (DersNotu >= 60 && DersNotu < 70)
            {
                txtharfnot.Text = "bc";
            }
            else if (DersNotu >= 50 && DersNotu < 60)
            {
                txtharfnot.Text = "cc";
            }
            else if (DersNotu < 50)
            {
                txtharfnot.Text = "ff";
            }

            baglanti.Open();
            NpgsqlCommand komutkaydet = new NpgsqlCommand("insert into ogrenci values (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komutkaydet.Parameters.AddWithValue("@p0", int.Parse(txtid.Text));
            komutkaydet.Parameters.AddWithValue("@p1", int.Parse(txtno.Text));
            komutkaydet.Parameters.AddWithValue("@p2", txtad.Text);
            komutkaydet.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komutkaydet.Parameters.AddWithValue("@p4", txtkod.Text);
            komutkaydet.Parameters.AddWithValue("@p5", int.Parse(txtkredi.Text));
            komutkaydet.Parameters.AddWithValue("@p6", int.Parse(txtnot.Text));
            komutkaydet.Parameters.AddWithValue("@p7", txtharfnot.Text);
            komutkaydet.Parameters.AddWithValue("@p8", int.Parse(txtakts.Text));
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("islem basarili", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }


    }
}
