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
    public partial class Form5 : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        public Form5()
        {
            InitializeComponent();
        }

        void listeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglan;
                cmd.CommandText = "select * from dısozellik";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "dısozellik");
                dataGridView1.DataSource = ds.Tables["dısozellik"];
                dataGridView1.Columns[0].Visible = false;
                baglan.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
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
                kmt.CommandText = "insert into dısozellik (park,alarm,otopark,ymerdiveni,guvenlik,kapici) Values(@park,@alarm,@otopark,@ymerdiveni,@guvenlik,@kapici)";
                kmt.Parameters.Clear();
                //if (pvar.Checked) kmt.Parameters.AddWithValue("@park", pvar.Text);
                //else if (pyok.Checked) kmt.Parameters.AddWithValue("@park", pyok.Text);
                if (park.Text == "Park")
                {
                    string park = "";
                    if (pvar.Checked) park = pvar.Text;
                    else if (pyok.Checked) park = pyok.Text;
                    kmt.Parameters.AddWithValue("@park", park);
                }

                if (alarm.Text == "Alarm")
                {
                    string alarm = "";
                    if (avar.Checked) alarm = avar.Text;
                    else if (ayok.Checked) alarm = ayok.Text;
                    kmt.Parameters.AddWithValue("@alarm", alarm);
                }
                if (otopark.Text == "Otopark")
                {
                    string otopark = "";
                    if (ovar.Checked) otopark = ovar.Text;
                    else if (oyok.Checked) otopark = oyok.Text;
                    kmt.Parameters.AddWithValue("@otopark", otopark);

                }

                if (ymerdiveni.Text == "Yangın Merdiveni")
                {
                    string ymerdiveni = "";
                    if (yvar.Checked) ymerdiveni = yvar.Text;
                    else if (yyok.Checked) ymerdiveni = yyok.Text;
                    kmt.Parameters.AddWithValue("@ymerdiveni", ymerdiveni);
                }

                if (guvenlik.Text == "Güvenlik")
                {
                    string guvenlik = "";
                    if (gvar.Checked) guvenlik = gvar.Text;
                    else if (gyok.Checked) guvenlik = gyok.Text;
                    kmt.Parameters.AddWithValue("@guvenlik", guvenlik);
                }

                if (kapici.Text == "Kapıcı")
                {
                    string kapici = "";
                    if (kvar.Checked) kapici = kvar.Text;
                    else if (kyok.Checked) kapici = kyok.Text;
                    kmt.Parameters.AddWithValue("@kapici", kapici);
                }

                kmt.ExecuteNonQuery();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Yapılmıştır");
                pvar.Checked = false;
                pyok.Checked = false;
                avar.Checked = false;
                ayok.Checked = false;
                ovar.Checked = false;
                oyok.Checked = false;
                yvar.Checked = false;
                yyok.Checked = false;
                gvar.Checked = false;
                gyok.Checked = false;
                kvar.Checked = false;
                kyok.Checked = false;
            }
        }

        private void btndüzelt_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "update dısozellik set park=@park,alarm=@alarm,otopark=@otopark,ymerdiveni=@ymerdiveni,guvenlik=@guvenlik,kapici=@kapici where dısoid=@dısoid";
                kmt.Parameters.Clear();
                if (park.Text == "Park")
                {
                    string park = "";
                    if (pvar.Checked) park = pvar.Text;
                    else if (pyok.Checked) park = pyok.Text;
                    kmt.Parameters.AddWithValue("@park", park);
                }

                if (alarm.Text == "Alarm")
                {
                    string alarm = "";
                    if (avar.Checked) alarm = avar.Text;
                    else if (ayok.Checked) alarm = ayok.Text;
                    kmt.Parameters.AddWithValue("@alarm", alarm);
                }

                if (otopark.Text == "Otopark")
                {
                    string otopark = "";
                    if (ovar.Checked) otopark = ovar.Text;
                    else if (oyok.Checked) otopark = oyok.Text;
                    kmt.Parameters.AddWithValue("@otopark", otopark);

                }

                if (ymerdiveni.Text == "Yangın Merdiveni")
                {
                    string ymerdiveni = "";
                    if (yvar.Checked) ymerdiveni = yvar.Text;
                    else if (yyok.Checked) ymerdiveni = yyok.Text;
                    kmt.Parameters.AddWithValue("@ymerdiveni", ymerdiveni);
                }

                if (guvenlik.Text == "Güvenlik")
                {
                    string guvenlik = "";
                    if (gvar.Checked) guvenlik = gvar.Text;
                    else if (gyok.Checked) guvenlik = gyok.Text;
                    kmt.Parameters.AddWithValue("@guvenlik", guvenlik);
                }

                if (kapici.Text == "Kapıcı")
                {
                    string kapici = "";
                    if (kvar.Checked) kapici = kvar.Text;
                    else if (kyok.Checked) kapici = kyok.Text;
                    kmt.Parameters.AddWithValue("@kapici", kapici);
                }
                kmt.Parameters.AddWithValue("@dısoid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Düzeltilmiştir");
                pvar.Checked = false;
                pyok.Checked = false;
                avar.Checked = false;
                ayok.Checked = false;
                ovar.Checked = false;
                oyok.Checked = false;
                yvar.Checked = false;
                yyok.Checked = false;
                gvar.Checked = false;
                gyok.Checked = false;
                kvar.Checked = false;
                kyok.Checked = false;
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
                    kmt.CommandText = "delete from dısozellik where dısoid=@dısoid";
                    kmt.Parameters.AddWithValue("@dısoid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    baglan.Close();
                    listeleme();
                    pvar.Checked = false;
                    pyok.Checked = false;
                    avar.Checked = false;
                    ayok.Checked = false;
                    ovar.Checked = false;
                    oyok.Checked = false;
                    yvar.Checked = false;
                    yyok.Checked = false;
                    gvar.Checked = false;
                    gyok.Checked = false;
                    kvar.Checked = false;
                    kyok.Checked = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pvar.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                pvar.Checked = true;
            }
            else if (pyok.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                pyok.Checked = true;
            }

            if (avar.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString())
            {
                avar.Checked = true;
            }
            else if (ayok.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString())
            {
                ayok.Checked = true;
            }

            if (ovar.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                ovar.Checked = true;
            }
            else if (oyok.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                oyok.Checked = true;
            }

            if (yvar.Text == dataGridView1.CurrentRow.Cells[4].Value.ToString())
            {
                yvar.Checked = true;
            }
            else if (yyok.Text == dataGridView1.CurrentRow.Cells[4].Value.ToString())
            {
                yyok.Checked = true;
            }

            if (gvar.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
                gvar.Checked = true;
            }
            else if (gyok.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
                gyok.Checked = true;
            }

            if (kvar.Text == dataGridView1.CurrentRow.Cells[6].Value.ToString())
            {
                kvar.Checked = true;
            }
            else if (kyok.Text == dataGridView1.CurrentRow.Cells[6].Value.ToString())
            {
                kyok.Checked = true;
            }
        }
    }
}
