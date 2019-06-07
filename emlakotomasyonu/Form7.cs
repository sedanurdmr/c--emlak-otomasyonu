using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace emlakotomasyonu
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlCommand kmd;
        SqlConnection kon;
        SqlDataReader sr;
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");

        private void btngiris_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            kon = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");
            kmd = new SqlCommand();
            kon.Open();
            kmd.Connection = kon;
            kmd.CommandText = "select * from kullanici where kadi='" + textBox1.Text + "'and ksifre='" + textBox2.Text + "'";
            sr = kmd.ExecuteReader();
            if (sr.Read())
            {
                Form8 f8 = new Form8();
                f8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış Girildi");
            }
            kon.Close();
        }

        
    }
}
