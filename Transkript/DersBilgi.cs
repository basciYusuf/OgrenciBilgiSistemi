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
    public partial class DersBilgi : Form
    {
        public DersBilgi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost; port=5432; Database=ubys;user id=postgres;password=1234 ");
        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from dersler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataGridListele.DataSource = ds.Tables[0];
        }
    }
}
