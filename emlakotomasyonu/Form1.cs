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
    public partial class Form1 : Form
    {
        SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        void getir()
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
            if (baglan1.State == ConnectionState.Closed)
            {
                baglan1.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan1;
                cmd.CommandText = "select ilan.*,adres.il from ilan,adres where ilan.adresid=adres.adresid";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select *, il from adres ", baglan1);
                da.Fill(ds, "adres");
                ilanil.DataSource = ds.Tables["adres"];
                ilanil.ValueMember = "adresid";
                ilanil.DisplayMember = "il";
                adpr.Fill(ds, "ilan");
                dataGridView1.DataSource = ds.Tables["ilan"];
            }
        }

        void listeleme()
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
            if (baglan1.State == ConnectionState.Closed)
            {
                baglan1.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan1;
                cmd.CommandText = @"select ilan.*,adres.il from ilan,adres where ilan.ilanid=adres.adresid";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "ilan");
                dataGridView1.DataSource = ds.Tables["ilan"];
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                baglan1.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeleme();
            SqlDataAdapter da = new SqlDataAdapter("select *, il from adres ", baglan1);
            da.Fill(ds, "adres");
            ilanil.DataSource = ds.Tables["adres"];
            ilanil.ValueMember = "adresid";
            ilanil.DisplayMember = "il";
            getir();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
            if (baglan1.State == ConnectionState.Closed)
            {
                baglan1.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan1;
                kmt.CommandText = "insert into ilan (ilanbaslik,ilanfiyat,ilanaciklama,ilantarih,adresid) Values (@ilanbaslik,@ilanfiyat,@ilanaciklama,@ilantarih,@adresid)";
                if (groupBox1.Text == "İLAN")
                {
                    string ilanturu = "";
                    if (satilik.Checked) ilanturu = satilik.Text;
                    else if (kiralik.Checked) ilanturu = kiralik.Text;
                    kmt.Parameters.AddWithValue("@ilanbaslik", ilanturu);
                }
                kmt.Parameters.AddWithValue("@ilanfiyat", fiyat.Text);
                kmt.Parameters.AddWithValue("@ilanaciklama", aciklama.Text);
                kmt.Parameters.AddWithValue("@ilantarih", itarih.Text);
                kmt.Parameters.AddWithValue("@adresid", ilanil.SelectedValue);
                kmt.ExecuteNonQuery();
                baglan1.Close();
                listeleme();
                getir();
                MessageBox.Show("Kaydınız Yapılmıştır");
                satilik.Checked = false; kiralik.Checked = false; ilanil.SelectedItem = null; fiyat.Clear();aciklama.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ilanno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            aciklama.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            itarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (satilik.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                satilik.Checked = true;
            }
            else if (kiralik.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                kiralik.Checked = true;
            }

            ilanil.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void ilandetay_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void adresbilgileri_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void arananil_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select * from ilan where ilan.ilanbaslik like '" + aranan.Text + "%'";
            if (ds.Tables["ilan"] != null) ds.Tables["ilan"].Clear();
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, baglan1);
            da.Fill(ds, "ilan");
            dataGridView1.DataSource = ds.Tables["ilan"];
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
            DialogResult cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (baglan1.State == ConnectionState.Closed)
                {
                    baglan1.Open();
                    SqlCommand kmt = new SqlCommand();
                    kmt.Connection = baglan1;
                    kmt.CommandText = "delete from ilan where ilanid=@ilanid";
                    kmt.Parameters.AddWithValue("@ilanid", dataGridView1.CurrentRow.Cells[0].Value);
                    kmt.ExecuteNonQuery();
                    baglan1.Close();
                    MessageBox.Show("Kayıt Silindi");
                    listeleme();
                    getir();
                    satilik.Checked = false; kiralik.Checked = false; ilanil.SelectedItem = null; fiyat.Clear();aciklama.Clear();
                }
            }
        }
      
        private void btndüzelt_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=True");
            if (baglan1.State == ConnectionState.Closed)
            {
                baglan1.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan1;
                kmt.CommandText = "update ilan set ilanbaslik=@ilanbaslik,ilanfiyat=@ilanfiyat,ilanaciklama=@ilanaciklama,ilantarih=@ilantarih,adresid=@adresid where ilanid=@ilanid";
                kmt.Parameters.Clear();
                string ilanturu = "";
                if (satilik.Checked) ilanturu = satilik.Text;
                else if (kiralik.Checked) ilanturu = kiralik.Text;
                kmt.Parameters.AddWithValue("@ilanbaslik", ilanturu);
                kmt.Parameters.AddWithValue("@ilanfiyat", fiyat.Text);
                kmt.Parameters.AddWithValue("@ilanaciklama", aciklama.Text);
                kmt.Parameters.AddWithValue("@ilantarih", itarih.Text);
                kmt.Parameters.AddWithValue("@adresid", ilanil.SelectedValue);
                kmt.Parameters.AddWithValue("@ilanid", ilanno.Text);
                kmt.ExecuteNonQuery();
                baglan1.Close();
                listeleme();
                getir();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                satilik.Checked = false; kiralik.Checked = false; ilanil.SelectedItem = null; fiyat.Clear();aciklama.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Hide(); 
        }
    }
 }
    
    