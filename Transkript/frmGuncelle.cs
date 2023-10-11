using Npgsql;
using NpgsqlTypes;
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
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutgiris = new NpgsqlCommand("select * from dersler where \"derskodu\" like '" + txtkod.Text + "' ",baglanti);
            NpgsqlDataReader reader = komutgiris.ExecuteReader();
             
           
            while (reader.Read())
            {
                txtad.Text = reader[1].ToString();
                txtkredi.Text = reader[2].ToString();
                txtakts.Text = reader[3].ToString();
                txtdonem.Text = reader[4].ToString();
                txtegtad.Text = reader[5].ToString();
                txtegtsoyad.Text = reader[6].ToString();

                 if (reader[1] != null) {
                    txtad.Enabled = true;
                    txtkredi.Enabled = true;
                    txtakts.Enabled = true;
                    txtdonem.Enabled = true;
                    txtegtad.Enabled = true;
                    txtegtsoyad.Enabled = true;

                }
            }
            baglanti.Close(); 
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komutguncelle = new NpgsqlCommand("update dersler set \"dersadi\" = @g2,\"derskredisi\" = @g3,\"dersakts\" = @g4,\"dersdonem\" = @g5,\"dersogretmenadi\" = @g6,\"dersogretmensoyadi\" = @g7 where \"derskodu\" = @g1 " , baglanti);

            komutguncelle.Parameters.AddWithValue("@g1", txtkod.Text);
            komutguncelle.Parameters.AddWithValue("@g2", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@g3", int.Parse(txtkredi.Text));
            komutguncelle.Parameters.AddWithValue("@g4", int.Parse(txtakts.Text));
            komutguncelle.Parameters.AddWithValue("@g5", txtdonem.Text);
            komutguncelle.Parameters.AddWithValue("@g6", txtegtad.Text);
            komutguncelle.Parameters.AddWithValue("@g7", txtegtsoyad.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("islem basarili");


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
