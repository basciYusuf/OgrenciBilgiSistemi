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

namespace Transkript
{
    public partial class frmEkle : Form
    {
        public frmEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432; Database=ubys;user id=postgres;password=1234 ");
        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutkaydet = new NpgsqlCommand("insert into dersler values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            
            komutkaydet.Parameters.AddWithValue("@p1",txtkod.Text);
            komutkaydet.Parameters.AddWithValue("@p2", txtad.Text);
            komutkaydet.Parameters.AddWithValue("@p3",int.Parse(txtkredi.Text));
            komutkaydet.Parameters.AddWithValue("@p4",int.Parse(txtakts.Text));
            komutkaydet.Parameters.AddWithValue("@p5",txtdonem.Text);
            komutkaydet.Parameters.AddWithValue("@p6",txtegtad.Text);
            komutkaydet.Parameters.AddWithValue("@p7", txtegtsoyad.Text);
           
            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("islem basarili", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
