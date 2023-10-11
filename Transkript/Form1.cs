using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Transkript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432; Database=ubys;user id=postgres;password=1234 ");
        private void btnDersBilgiGoster_Click(object sender, EventArgs e)
        {
            DersBilgi dersbilgi = new DersBilgi();
            this.Hide();
            dersbilgi.Show();

        }

        private void btnOgrenciBilgiGoster_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ogrenci where no::text like  '"+txtOgrNo.Text+"'" ,baglanti);
            DataSet ds = new DataSet();
             da.Fill(ds);
            dataGridogrenci.DataSource = ds.Tables[0];

            
        }

        private void btnogrkaydet_Click(object sender, EventArgs e)
        {
            ogrGuncelle ogrguncelle = new ogrGuncelle();
            this.Hide();
            ogrguncelle.Show();



        }

        private void txtOgrNo_TextChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            //NpgsqlCommand komutgiris = new NpgsqlCommand("select * from ogr where \"no\" like '" + txtOgrNo.Text + "' ", baglanti);
            //NpgsqlDataReader reader = komutgiris.ExecuteReader();


            //while (reader.Read())
            //{
              
            //    txtvsbl1.Text = reader[5].ToString();
            //    txtvsbl2.Text = reader[6].ToString();

             
            //}
            //baglanti.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmGuncelle frmGuncelle = new frmGuncelle();
            this.Hide();
            frmGuncelle.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            frmSil frmSil = new frmSil();
            this.Hide();
            frmSil.Show();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            frmEkle frmEkle = new frmEkle();
            this.Hide();
            frmEkle.Show();
        }
    }
}
