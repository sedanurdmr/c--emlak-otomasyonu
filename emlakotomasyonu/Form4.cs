using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace emlakotomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        void listeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from musteri";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "musteri");
                dataGridView1.DataSource = ds.Tables["musteri"];
                dataGridView1.Columns[0].Visible = false;
                baglan.Close();
            }
        }
      
        private void Form4_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand tcvarmi = new SqlCommand("select * from musteri where tcno=" + "'" + tc.Text + "'", baglan);
                SqlDataReader dr = tcvarmi.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Lütfen TC Değiştiriniz");
                    tc.Focus();
                }
                else
                {
                    if (tc.Text.Length != 11 || telefon.Text.Length != 11)
                    {
                        MessageBox.Show("TC veya Telefon 11 Haneli Giriniz");
                    }
                    else
                    {
                        SqlCommand kmt = new SqlCommand();
                        kmt.Connection = baglan;
                        kmt.CommandText = "insert into musteri (adi,soyadi,tcno,telefon,eposta) Values(@adi,@soyadi,@tcno,@telefon,@eposta)";
                        kmt.Parameters.Clear();
                        kmt.Parameters.AddWithValue("@adi", ad.Text);
                        kmt.Parameters.AddWithValue("@soyadi", soyad.Text);
                        kmt.Parameters.AddWithValue("@tcno", tc.Text);
                        kmt.Parameters.AddWithValue("@telefon", telefon.Text);
                        kmt.Parameters.AddWithValue("@eposta", eposta.Text);
                        kmt.ExecuteNonQuery();
                        baglan.Close();
                        listeleme();
                        MessageBox.Show("Kaydınız Yapılmıştır");
                        ad.Clear(); soyad.Clear(); tc.Clear(); telefon.Clear(); eposta.Clear();
                    }
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    SqlCommand kmt = new SqlCommand();
                    kmt.Connection = baglan;
                    kmt.CommandText = "delete from musteri where musid=@musid";
                    kmt.Parameters.AddWithValue("@musid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    baglan.Close();
                    listeleme();
                    ad.Clear(); soyad.Clear(); tc.Clear(); telefon.Clear(); eposta.Clear();
                }
            }
        }

        private void btndüzelt_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "update musteri set adi=@adi,soyadi=@soyadi,tcno=@tcno,telefon=@telefon,eposta=@eposta where musid=@musid";
                kmt.Parameters.Clear();
                kmt.Parameters.AddWithValue("@adi", ad.Text);
                kmt.Parameters.AddWithValue("@soyadi", soyad.Text);
                kmt.Parameters.AddWithValue("@tcno", tc.Text);
                kmt.Parameters.AddWithValue("@telefon", telefon.Text);
                kmt.Parameters.AddWithValue("@eposta", eposta.Text);
                kmt.Parameters.AddWithValue("@musid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                listeleme();
                ad.Clear();soyad.Clear();tc.Clear();telefon.Clear();eposta.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            eposta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Hide();
        }
    }
}
