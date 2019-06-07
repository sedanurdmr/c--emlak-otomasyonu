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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int kacincikayit;
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
                cmd.CommandText = "select * from adres";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "adres");
                dataGridView1.DataSource = ds.Tables["adres"];
                dataGridView1.Columns[0].Visible = false;
                baglan.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "insert into adres (cadde,sokak,mahalle,il,ilçe,binano,kat) Values(@cadde,@sokak,@mahalle,@il,@ilçe,@binano,@kat)";
                kmt.Parameters.Clear();
                kmt.Parameters.AddWithValue("@cadde", cadde.Text);
                kmt.Parameters.AddWithValue("@sokak", sokak.Text);
                kmt.Parameters.AddWithValue("@mahalle", mahalle.Text);
                kmt.Parameters.AddWithValue("@il", il.Text);
                kmt.Parameters.AddWithValue("@ilçe", ilçe.Text);
                kmt.Parameters.AddWithValue("@binano", binano.Text);
                kmt.Parameters.AddWithValue("@kat", kat.Text);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kaydınız Yapılmıştır");
                bs.Position = kacincikayit;
                listeleme();
                cadde.Clear();sokak.Clear();mahalle.Clear();il.Clear();ilçe.Clear();binano.Clear();kat.Clear();
            }
        }

        private void btndüzelt_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "update adres set cadde=@cadde,sokak=@sokak,mahalle=@mahalle,il=@il,ilçe=@ilçe,binano=@binano,kat=@kat where adresid=@adresid";
                kmt.Parameters.Clear();
                kmt.Parameters.AddWithValue("@cadde", cadde.Text);
                kmt.Parameters.AddWithValue("@sokak", sokak.Text);
                kmt.Parameters.AddWithValue("@mahalle", mahalle.Text);
                kmt.Parameters.AddWithValue("@il", il.Text);
                kmt.Parameters.AddWithValue("@ilçe", ilçe.Text);
                kmt.Parameters.AddWithValue("@binano", binano.Text);
                kmt.Parameters.AddWithValue("@kat", kat.Text);
                kmt.Parameters.AddWithValue("@adresid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                bs.Position = kacincikayit;
                cadde.Clear(); sokak.Clear(); mahalle.Clear(); il.Clear(); ilçe.Clear(); binano.Clear(); kat.Clear();
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
                    kmt.CommandText = "delete from adres where adresid=@adresid";
                    kmt.Parameters.AddWithValue("@adresid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    kmt.Dispose();
                    baglan.Close();
                    listeleme();
                    cadde.Clear(); sokak.Clear(); mahalle.Clear(); il.Clear(); ilçe.Clear(); binano.Clear(); kat.Clear();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cadde.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sokak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mahalle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            il.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            binano.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ilçe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
