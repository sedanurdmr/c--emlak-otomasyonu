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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        //void getir()
        //{
        //    if (baglan.State == ConnectionState.Closed) baglan.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = baglan;
        //    cmd.CommandText = "select ilandetay.*,ilan.ilanid from ilandetay,ilan where ilandetay.ilanid=ilan.ilanid";
        //    SqlDataAdapter adpr = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter("select *, ilanid from ilan ", baglan);
        //    da.Fill(ds, "ilan");
        //    adpr.Fill(ds, "ilandetay");
        //    dataGridView1.DataSource = ds.Tables["ilandetay"];
        //}

        void listeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from ilandetay";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "ilandetay");
                dataGridView1.DataSource = ds.Tables["ilandetay"];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                baglan.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeleme();
            //SqlDataAdapter da = new SqlDataAdapter("select *, ilanid from ilan ", baglan);
            //da.Fill(ds, "ilan");
            //tbilanno.DataSource = ds.Tables["ilan"];
            //tbilanno.ValueMember = "ilanid";
            //tbilanno.DisplayMember = "ilanid";
            //getir();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "insert into ilandetay (odasayisi,fiyat,ilantipi,binakkat,esyalimi) Values(@odasayisi,@fiyat,@ilantipi,@binakkat,@esyalimi)";
                kmt.Parameters.Clear();
                kmt.Parameters.AddWithValue("@odasayisi", oda.Text);
                kmt.Parameters.AddWithValue("@fiyat", fiyat.Text);
                if (kimden.Text == "Kimden")
                {
                    string kimden = "";
                    if (sahibinden.Checked) kimden = sahibinden.Text;
                    else if (emlak.Checked) kimden = emlak.Text;
                    kmt.Parameters.AddWithValue("@ilantipi", kimden);
                }
                kmt.Parameters.AddWithValue("@binakkat", kat.Text);
                if (groupBox1.Text == "İLAN DETAY")
                {
                    string esyalimi = "";
                    if (evet.Checked) esyalimi = evet.Text;
                    else if (hayır.Checked) esyalimi = hayır.Text;
                    kmt.Parameters.AddWithValue("@esyalimi", esyalimi);
                }
                kmt.ExecuteNonQuery();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Yapılmıştır");
                oda.Clear();fiyat.Clear();kat.Clear();evet.Checked = false;hayır.Checked = false;sahibinden.Checked = false; emlak.Checked = false;
            }
        }

        private void btndüzelt_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "update ilandetay set odasayisi=@odasayisi,fiyat=@fiyat,ilantipi=@ilantipi,binakkat=@binakkat,esyalimi=@esyalimi where ilandetayid=@ilandetayid ";
                kmt.Parameters.Clear();
                kmt.Parameters.AddWithValue("@odasayisi", oda.Text);
                kmt.Parameters.AddWithValue("@fiyat", fiyat.Text);
                if (kimden.Text == "Kimden")
                {
                    string kimden = "";
                    if (sahibinden.Checked) kimden = sahibinden.Text;
                    else if (emlak.Checked) kimden = emlak.Text;
                    kmt.Parameters.AddWithValue("@ilantipi", kimden);
                }
                kmt.Parameters.AddWithValue("@binakkat", kat.Text);
                if (groupBox1.Text == "İLAN DETAY")
                {
                    string esyalimi = "";
                    if (evet.Checked) esyalimi = evet.Text;
                    else if (hayır.Checked) esyalimi = hayır.Text;
                    kmt.Parameters.AddWithValue("@esyalimi", esyalimi);
                }
                kmt.Parameters.AddWithValue("@ilandetayid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                oda.Clear(); fiyat.Clear(); kat.Clear(); evet.Checked = false; hayır.Checked = false; sahibinden.Checked = false; emlak.Checked = false;
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
                    kmt.CommandText = "delete from ilandetay where ilandetayid=@ilandetayid";
                    kmt.Parameters.AddWithValue("@ilandetayid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    baglan.Close();
                    listeleme();
                    oda.Clear(); fiyat.Clear(); kat.Clear(); evet.Checked = false; hayır.Checked = false; sahibinden.Checked = false; emlak.Checked = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oda.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (sahibinden.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                sahibinden.Checked = true;
            }
            else if (emlak.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                emlak.Checked = true;
            }
            kat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (evet.Text == dataGridView1.CurrentRow.Cells[6].Value.ToString())
            {
                evet.Checked = true;
            }
            else if (hayır.Text == dataGridView1.CurrentRow.Cells[6].Value.ToString())
            {
                hayır.Checked = true;
            }
        }

        private void dızozellik_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void icozellik_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void aranan_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select * from ilandetay where ilandetay.ilantipi like '" + aranan.Text + "%'";
            if (ds.Tables["ilandetay"] != null) ds.Tables["ilandetay"].Clear();
            SqlDataAdapter da = new SqlDataAdapter(seckomutu, baglan);
            da.Fill(ds, "ilandetay");
            dataGridView1.DataSource = ds.Tables["ilandetay"];
        }
    }
}
