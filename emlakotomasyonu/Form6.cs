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
    public partial class Form6 : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VRF0VSK; Initial Catalog=emlak; Integrated Security=true;");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        public Form6()
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
                cmd.CommandText = "select * from icozellik";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "icozellik");
                dataGridView1.DataSource = ds.Tables["icozellik"];
                dataGridView1.Columns[0].Visible = false;
                baglan.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
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
                kmt.CommandText = "insert into icozellik (asansor,yanginalarmi,balkon,isicam,gdiyafon) Values(@asansor,@yanginalarmi,@balkon,@isicam,@gdiyafon)";
                kmt.Parameters.Clear();
                //if (avar.Checked) kmt.Parameters.AddWithValue("@asansor", avar.Text);
                //else if (ayok.Checked) kmt.Parameters.AddWithValue("@asansor", ayok.Text);
                if (asansor.Text == "Asansor")
                {
                    string asansor = "";
                    if (avar.Checked) asansor = avar.Text;
                    else if (ayok.Checked) asansor = ayok.Text;
                    kmt.Parameters.AddWithValue("@asansor", asansor);
                }

                if (yalarmi.Text == "Yangın Alarmı")
                {
                    string yanginalarmi = "";
                    if (yvar.Checked) yanginalarmi = yvar.Text;
                    else if (yyok.Checked) yanginalarmi = yyok.Text;
                    kmt.Parameters.AddWithValue("@yanginalarmi", yanginalarmi);
                }

                if (balkon.Text == "Balkon")
                {
                    string balkon = "";
                    if (bvar.Checked) balkon = bvar.Text;
                    else if (byok.Checked) balkon = byok.Text;
                    kmt.Parameters.AddWithValue("@balkon", balkon);

                }

                if (isicam.Text == "Isıcam")
                {
                    string isicam = "";
                    if (ivar.Checked) isicam = ivar.Text;
                    else if (iyok.Checked) isicam = iyok.Text;
                    kmt.Parameters.AddWithValue("@isicam", isicam);
                }

                if (gdiyafon.Text == "Görüntülü Diyafon")
                {
                    string gdiyafon = "";
                    if (gvar.Checked) gdiyafon = gvar.Text;
                    else if (gyok.Checked) gdiyafon = gyok.Text;
                    kmt.Parameters.AddWithValue("@gdiyafon", gdiyafon);
                }
                kmt.ExecuteNonQuery();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydınız Yapılmıştır");
                avar.Checked = false;
                ayok.Checked = false;
                yvar.Checked = false;
                yyok.Checked = false;
                bvar.Checked = false;
                byok.Checked = false;
                ivar.Checked = false;
                iyok.Checked = false;
                gvar.Checked = false;
                gyok.Checked = false;
            }
        }

        private void btndüzelt_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "update icozellik set asansor=@asansor,yanginalarmi=@yanginalarmi,balkon=@balkon,isicam=@isicam,gdiyafon=@gdiyafon where icoid=@icoid";
                kmt.Parameters.Clear();
                if (asansor.Text == "Asansor")
                {
                    string asansor = "";
                    if (avar.Checked) asansor = avar.Text;
                    else if (ayok.Checked) asansor = ayok.Text;
                    kmt.Parameters.AddWithValue("@asansor", asansor);
                }

                if (yalarmi.Text == "Yangın Alarmı")
                {
                    string yanginalarmi = "";
                    if (yvar.Checked) yanginalarmi = yvar.Text;
                    else if (yyok.Checked) yanginalarmi = yyok.Text;
                    kmt.Parameters.AddWithValue("@yanginalarmi", yanginalarmi);
                }

                if (balkon.Text == "Balkon")
                {
                    string balkon = "";
                    if (bvar.Checked) balkon = bvar.Text;
                    else if (byok.Checked) balkon = byok.Text;
                    kmt.Parameters.AddWithValue("@balkon", balkon);

                }

                if (isicam.Text == "Isıcam")
                {
                    string isicam = "";
                    if (ivar.Checked) isicam = ivar.Text;
                    else if (iyok.Checked) isicam = iyok.Text;
                    kmt.Parameters.AddWithValue("@isicam", isicam);
                }

                if (gdiyafon.Text == "Görüntülü Diyafon")
                {
                    string gdiyafon = "";
                    if (gvar.Checked) gdiyafon = gvar.Text;
                    else if (gyok.Checked) gdiyafon = gyok.Text;
                    kmt.Parameters.AddWithValue("@gdiyafon", gdiyafon);
                }
                kmt.Parameters.AddWithValue("@icoid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                baglan.Close();
                listeleme();
                MessageBox.Show("Kaydnız Düzeltilmiştir");
                avar.Checked = false;
                ayok.Checked = false;
                yvar.Checked = false;
                yyok.Checked = false;
                bvar.Checked = false;
                byok.Checked = false;
                ivar.Checked = false;
                iyok.Checked = false;
                gvar.Checked = false;
                gyok.Checked = false;
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
                    kmt.CommandText = "delete from icozellik where icoid=@icoid";
                    kmt.Parameters.AddWithValue("@icoid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi");
                    baglan.Close();
                    listeleme();
                    avar.Checked = false;
                    ayok.Checked = false;
                    yvar.Checked = false;
                    yyok.Checked = false;
                    bvar.Checked = false;
                    byok.Checked = false;
                    ivar.Checked = false;
                    iyok.Checked = false;
                    gvar.Checked = false;
                    gyok.Checked = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (avar.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                avar.Checked = true;
            }
            else if (ayok.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                ayok.Checked = true;
            }

            if (yvar.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString())
            {
                yvar.Checked = true;
            }
            else if (yyok.Text == dataGridView1.CurrentRow.Cells[2].Value.ToString())
            {
                yyok.Checked = true;
            }

            if (bvar.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                bvar.Checked = true;
            }
            else if (byok.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                byok.Checked = true;
            }

            if (ivar.Text == dataGridView1.CurrentRow.Cells[4].Value.ToString())
            {
                ivar.Checked = true;
            }
            else if (iyok.Text == dataGridView1.CurrentRow.Cells[4].Value.ToString())
            {
                iyok.Checked = true;
            }

            if (gvar.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
                gvar.Checked = true;
            }
            else if (gyok.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
            {
                gyok.Checked = true;
            }
        }
    }
}
