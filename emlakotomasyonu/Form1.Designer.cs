namespace emlakotomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kiralik = new System.Windows.Forms.RadioButton();
            this.satilik = new System.Windows.Forms.RadioButton();
            this.ilanil = new System.Windows.Forms.ComboBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.itarih = new System.Windows.Forms.DateTimePicker();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.ilanno = new System.Windows.Forms.TextBox();
            this.il = new System.Windows.Forms.Label();
            this.ilantarih = new System.Windows.Forms.Label();
            this.ilanaciklama = new System.Windows.Forms.Label();
            this.ilanfiyat = new System.Windows.Forms.Label();
            this.ilanbaslik = new System.Windows.Forms.Label();
            this.ilanid = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btndüzelt = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.ilandetay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresbilgileri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aranan = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kiralik);
            this.groupBox1.Controls.Add(this.satilik);
            this.groupBox1.Controls.Add(this.ilanil);
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Controls.Add(this.itarih);
            this.groupBox1.Controls.Add(this.fiyat);
            this.groupBox1.Controls.Add(this.ilanno);
            this.groupBox1.Controls.Add(this.il);
            this.groupBox1.Controls.Add(this.ilantarih);
            this.groupBox1.Controls.Add(this.ilanaciklama);
            this.groupBox1.Controls.Add(this.ilanfiyat);
            this.groupBox1.Controls.Add(this.ilanbaslik);
            this.groupBox1.Controls.Add(this.ilanid);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İLAN";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 14;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(699, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Çıkış";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2-Hot-Home-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Actions-go-home-icon.png");
            this.ımageList1.Images.SetKeyName(2, "Folder-Home-Folder-icon.png");
            this.ımageList1.Images.SetKeyName(3, "folder-home-icon.png");
            this.ımageList1.Images.SetKeyName(4, "home-4-icon.png");
            this.ımageList1.Images.SetKeyName(5, "Home-alt-icon.png");
            this.ımageList1.Images.SetKeyName(6, "home-blue-icon.png");
            this.ımageList1.Images.SetKeyName(7, "home-icon (1).png");
            this.ımageList1.Images.SetKeyName(8, "Home-icon (2).png");
            this.ımageList1.Images.SetKeyName(9, "Home-icon.png");
            this.ımageList1.Images.SetKeyName(10, "House-icon.png");
            this.ımageList1.Images.SetKeyName(11, "Recycle-Bin-Full-icon.png");
            this.ımageList1.Images.SetKeyName(12, "Smurf-House-Exterior-icon.png");
            this.ımageList1.Images.SetKeyName(13, "Smurf-House-Interior-icon.png");
            this.ımageList1.Images.SetKeyName(14, "close.png");
            // 
            // kiralik
            // 
            this.kiralik.AutoSize = true;
            this.kiralik.Location = new System.Drawing.Point(169, 44);
            this.kiralik.Name = "kiralik";
            this.kiralik.Size = new System.Drawing.Size(53, 17);
            this.kiralik.TabIndex = 21;
            this.kiralik.TabStop = true;
            this.kiralik.Text = "Kiralık";
            this.kiralik.UseVisualStyleBackColor = true;
            // 
            // satilik
            // 
            this.satilik.AutoSize = true;
            this.satilik.Location = new System.Drawing.Point(94, 44);
            this.satilik.Name = "satilik";
            this.satilik.Size = new System.Drawing.Size(53, 17);
            this.satilik.TabIndex = 20;
            this.satilik.TabStop = true;
            this.satilik.Text = "Satılık";
            this.satilik.UseVisualStyleBackColor = true;
            // 
            // ilanil
            // 
            this.ilanil.FormattingEnabled = true;
            this.ilanil.Items.AddRange(new object[] {
            "istanbul",
            "ankara",
            "izmir"});
            this.ilanil.Location = new System.Drawing.Point(75, 65);
            this.ilanil.Name = "ilanil";
            this.ilanil.Size = new System.Drawing.Size(199, 21);
            this.ilanil.TabIndex = 15;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(327, 15);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(336, 114);
            this.aciklama.TabIndex = 12;
            // 
            // itarih
            // 
            this.itarih.Location = new System.Drawing.Point(75, 120);
            this.itarih.Name = "itarih";
            this.itarih.Size = new System.Drawing.Size(200, 20);
            this.itarih.TabIndex = 11;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(75, 92);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(199, 20);
            this.fiyat.TabIndex = 9;
            // 
            // ilanno
            // 
            this.ilanno.Enabled = false;
            this.ilanno.Location = new System.Drawing.Point(75, 15);
            this.ilanno.Name = "ilanno";
            this.ilanno.Size = new System.Drawing.Size(200, 20);
            this.ilanno.TabIndex = 7;
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Location = new System.Drawing.Point(17, 76);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(15, 13);
            this.il.TabIndex = 6;
            this.il.Text = "İl:";
            // 
            // ilantarih
            // 
            this.ilantarih.AutoSize = true;
            this.ilantarih.Location = new System.Drawing.Point(17, 124);
            this.ilantarih.Name = "ilantarih";
            this.ilantarih.Size = new System.Drawing.Size(56, 13);
            this.ilantarih.TabIndex = 4;
            this.ilantarih.Text = "İlan Tarihi:";
            // 
            // ilanaciklama
            // 
            this.ilanaciklama.AutoSize = true;
            this.ilanaciklama.Location = new System.Drawing.Point(281, 18);
            this.ilanaciklama.Name = "ilanaciklama";
            this.ilanaciklama.Size = new System.Drawing.Size(53, 13);
            this.ilanaciklama.TabIndex = 3;
            this.ilanaciklama.Text = "Açıklama:";
            // 
            // ilanfiyat
            // 
            this.ilanfiyat.AutoSize = true;
            this.ilanfiyat.Location = new System.Drawing.Point(17, 99);
            this.ilanfiyat.Name = "ilanfiyat";
            this.ilanfiyat.Size = new System.Drawing.Size(32, 13);
            this.ilanfiyat.TabIndex = 2;
            this.ilanfiyat.Text = "Fiyat:";
            // 
            // ilanbaslik
            // 
            this.ilanbaslik.AutoSize = true;
            this.ilanbaslik.Location = new System.Drawing.Point(17, 49);
            this.ilanbaslik.Name = "ilanbaslik";
            this.ilanbaslik.Size = new System.Drawing.Size(52, 13);
            this.ilanbaslik.TabIndex = 1;
            this.ilanbaslik.Text = "İlan Türü:";
            // 
            // ilanid
            // 
            this.ilanid.AutoSize = true;
            this.ilanid.Location = new System.Drawing.Point(17, 22);
            this.ilanid.Name = "ilanid";
            this.ilanid.Size = new System.Drawing.Size(44, 13);
            this.ilanid.TabIndex = 0;
            this.ilanid.Text = "İlan No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btndüzelt);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 11;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(184, 19);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 43);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "     Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btndüzelt
            // 
            this.btndüzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndüzelt.ImageIndex = 3;
            this.btndüzelt.ImageList = this.ımageList1;
            this.btndüzelt.Location = new System.Drawing.Point(95, 19);
            this.btndüzelt.Name = "btndüzelt";
            this.btndüzelt.Size = new System.Drawing.Size(83, 43);
            this.btndüzelt.TabIndex = 9;
            this.btndüzelt.Text = "Düzelt";
            this.btndüzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndüzelt.UseVisualStyleBackColor = true;
            this.btndüzelt.Click += new System.EventHandler(this.btndüzelt_Click_1);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 2;
            this.btnkaydet.ImageList = this.ımageList1;
            this.btnkaydet.Location = new System.Drawing.Point(6, 19);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(83, 43);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // ilandetay
            // 
            this.ilandetay.Location = new System.Drawing.Point(12, 345);
            this.ilandetay.Name = "ilandetay";
            this.ilandetay.Size = new System.Drawing.Size(160, 23);
            this.ilandetay.TabIndex = 15;
            this.ilandetay.Text = "İlan Detay";
            this.ilandetay.UseVisualStyleBackColor = true;
            this.ilandetay.Click += new System.EventHandler(this.ilandetay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(330, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ilanid";
            this.Column1.HeaderText = "İlan No";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ilanbaslik";
            this.Column5.HeaderText = "İlan Türü";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "il";
            this.Column2.HeaderText = "İl";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ilanfiyat";
            this.Column3.HeaderText = "İlan Fiyatı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ilantarih";
            this.Column4.HeaderText = "İlan Tarihi";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ilanaciklama";
            this.Column6.HeaderText = "Açıklama";
            this.Column6.Name = "Column6";
            // 
            // adresbilgileri
            // 
            this.adresbilgileri.Location = new System.Drawing.Point(12, 302);
            this.adresbilgileri.Name = "adresbilgileri";
            this.adresbilgileri.Size = new System.Drawing.Size(160, 23);
            this.adresbilgileri.TabIndex = 18;
            this.adresbilgileri.Text = "Adres Bilgileri";
            this.adresbilgileri.UseVisualStyleBackColor = true;
            this.adresbilgileri.Click += new System.EventHandler(this.adresbilgileri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "İlan Arama:";
            // 
            // aranan
            // 
            this.aranan.Location = new System.Drawing.Point(121, 251);
            this.aranan.Name = "aranan";
            this.aranan.Size = new System.Drawing.Size(166, 20);
            this.aranan.TabIndex = 20;
            this.aranan.TextChanged += new System.EventHandler(this.arananil_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::emlakotomasyonu.Properties.Resources.House_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(195, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 109);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adresbilgileri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ilandetay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.DateTimePicker itarih;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.TextBox ilanno;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Label ilantarih;
        private System.Windows.Forms.Label ilanaciklama;
        private System.Windows.Forms.Label ilanfiyat;
        private System.Windows.Forms.Label ilanbaslik;
        private System.Windows.Forms.Label ilanid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzelt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button ilandetay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ilanil;
        private System.Windows.Forms.Button adresbilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton kiralik;
        private System.Windows.Forms.RadioButton satilik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox aranan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}

