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
    public partial class frmSil : Form
    {
        public frmSil()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1();
            this.Hide();
            frm.Show();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432; Database=ubys;user id=postgres;password=1234 ");
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutsil = new NpgsqlCommand("delete from dersler where \"derskodu\" =@k1 ", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtderskodu.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("islem basarili", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
