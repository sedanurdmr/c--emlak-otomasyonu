namespace emlakotomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kimden = new System.Windows.Forms.GroupBox();
            this.emlak = new System.Windows.Forms.RadioButton();
            this.sahibinden = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hayır = new System.Windows.Forms.RadioButton();
            this.evet = new System.Windows.Forms.RadioButton();
            this.kat = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.oda = new System.Windows.Forms.TextBox();
            this.esyalimi = new System.Windows.Forms.Label();
            this.kacincikat = new System.Windows.Forms.Label();
            this.idfiyat = new System.Windows.Forms.Label();
            this.odasayisi = new System.Windows.Forms.Label();
            this.dızozellik = new System.Windows.Forms.Button();
            this.icozellik = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btndüzelt = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aranan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.kimden.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kimden);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.hayır);
            this.groupBox1.Controls.Add(this.evet);
            this.groupBox1.Controls.Add(this.kat);
            this.groupBox1.Controls.Add(this.fiyat);
            this.groupBox1.Controls.Add(this.oda);
            this.groupBox1.Controls.Add(this.esyalimi);
            this.groupBox1.Controls.Add(this.kacincikat);
            this.groupBox1.Controls.Add(this.idfiyat);
            this.groupBox1.Controls.Add(this.odasayisi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İLAN DETAY";
            // 
            // kimden
            // 
            this.kimden.Controls.Add(this.emlak);
            this.kimden.Controls.Add(this.sahibinden);
            this.kimden.Location = new System.Drawing.Point(332, 65);
            this.kimden.Name = "kimden";
            this.kimden.Size = new System.Drawing.Size(252, 45);
            this.kimden.TabIndex = 11;
            this.kimden.TabStop = false;
            this.kimden.Text = "Kimden";
            // 
            // emlak
            // 
            this.emlak.AutoSize = true;
            this.emlak.Location = new System.Drawing.Point(119, 20);
            this.emlak.Name = "emlak";
            this.emlak.Size = new System.Drawing.Size(101, 17);
            this.emlak.TabIndex = 1;
            this.emlak.TabStop = true;
            this.emlak.Text = "Emlak Ofisinden";
            this.emlak.UseVisualStyleBackColor = true;
            // 
            // sahibinden
            // 
            this.sahibinden.AutoSize = true;
            this.sahibinden.Location = new System.Drawing.Point(21, 20);
            this.sahibinden.Name = "sahibinden";
            this.sahibinden.Size = new System.Drawing.Size(78, 17);
            this.sahibinden.TabIndex = 0;
            this.sahibinden.TabStop = true;
            this.sahibinden.Text = "Sahibinden";
            this.sahibinden.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // hayır
            // 
            this.hayır.AutoSize = true;
            this.hayır.Location = new System.Drawing.Point(503, 30);
            this.hayır.Name = "hayır";
            this.hayır.Size = new System.Drawing.Size(49, 17);
            this.hayır.TabIndex = 13;
            this.hayır.TabStop = true;
            this.hayır.Text = "Hayır\r\n";
            this.hayır.UseVisualStyleBackColor = true;
            // 
            // evet
            // 
            this.evet.AutoSize = true;
            this.evet.Location = new System.Drawing.Point(422, 30);
            this.evet.Name = "evet";
            this.evet.Size = new System.Drawing.Size(47, 17);
            this.evet.TabIndex = 12;
            this.evet.TabStop = true;
            this.evet.Text = "Evet\r\n";
            this.evet.UseVisualStyleBackColor = true;
            // 
            // kat
            // 
            this.kat.Location = new System.Drawing.Point(117, 78);
            this.kat.Name = "kat";
            this.kat.Size = new System.Drawing.Size(146, 20);
            this.kat.TabIndex = 8;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(117, 52);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(146, 20);
            this.fiyat.TabIndex = 6;
            // 
            // oda
            // 
            this.oda.Location = new System.Drawing.Point(117, 23);
            this.oda.Name = "oda";
            this.oda.Size = new System.Drawing.Size(146, 20);
            this.oda.TabIndex = 5;
            // 
            // esyalimi
            // 
            this.esyalimi.AutoSize = true;
            this.esyalimi.Location = new System.Drawing.Point(345, 32);
            this.esyalimi.Name = "esyalimi";
            this.esyalimi.Size = new System.Drawing.Size(37, 13);
            this.esyalimi.TabIndex = 4;
            this.esyalimi.Text = "Eşyalı:";
            // 
            // kacincikat
            // 
            this.kacincikat.AutoSize = true;
            this.kacincikat.Location = new System.Drawing.Point(44, 81);
            this.kacincikat.Name = "kacincikat";
            this.kacincikat.Size = new System.Drawing.Size(26, 13);
            this.kacincikat.TabIndex = 3;
            this.kacincikat.Text = "Kat:";
            // 
            // idfiyat
            // 
            this.idfiyat.AutoSize = true;
            this.idfiyat.Location = new System.Drawing.Point(44, 55);
            this.idfiyat.Name = "idfiyat";
            this.idfiyat.Size = new System.Drawing.Size(32, 13);
            this.idfiyat.TabIndex = 1;
            this.idfiyat.Text = "Fiyat:";
            // 
            // odasayisi
            // 
            this.odasayisi.AutoSize = true;
            this.odasayisi.Location = new System.Drawing.Point(39, 30);
            this.odasayisi.Name = "odasayisi";
            this.odasayisi.Size = new System.Drawing.Size(60, 13);
            this.odasayisi.TabIndex = 0;
            this.odasayisi.Text = "Oda Sayısı:";
            // 
            // dızozellik
            // 
            this.dızozellik.Location = new System.Drawing.Point(503, 332);
            this.dızozellik.Name = "dızozellik";
            this.dızozellik.Size = new System.Drawing.Size(142, 22);
            this.dızozellik.TabIndex = 5;
            this.dızozellik.Text = "Dış Özellik";
            this.dızozellik.UseVisualStyleBackColor = true;
            this.dızozellik.Click += new System.EventHandler(this.dızozellik_Click);
            // 
            // icozellik
            // 
            this.icozellik.Location = new System.Drawing.Point(651, 331);
            this.icozellik.Name = "icozellik";
            this.icozellik.Size = new System.Drawing.Size(142, 23);
            this.icozellik.TabIndex = 6;
            this.icozellik.Text = "İç Özellik";
            this.icozellik.UseVisualStyleBackColor = true;
            this.icozellik.Click += new System.EventHandler(this.icozellik_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btndüzelt);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(503, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 11;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(199, 34);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 34);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "   Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
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
            // 
            // btndüzelt
            // 
            this.btndüzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndüzelt.ImageIndex = 3;
            this.btndüzelt.ImageList = this.ımageList1;
            this.btndüzelt.Location = new System.Drawing.Point(110, 34);
            this.btndüzelt.Name = "btndüzelt";
            this.btndüzelt.Size = new System.Drawing.Size(75, 34);
            this.btndüzelt.TabIndex = 16;
            this.btndüzelt.Text = "Düzelt";
            this.btndüzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndüzelt.UseVisualStyleBackColor = true;
            this.btndüzelt.Click += new System.EventHandler(this.btndüzelt_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 2;
            this.btnkaydet.ImageList = this.ımageList1;
            this.btnkaydet.Location = new System.Drawing.Point(18, 34);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 34);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kimden:";
            // 
            // aranan
            // 
            this.aranan.Location = new System.Drawing.Point(93, 142);
            this.aranan.Name = "aranan";
            this.aranan.Size = new System.Drawing.Size(145, 20);
            this.aranan.TabIndex = 9;
            this.aranan.TextChanged += new System.EventHandler(this.aranan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 182);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::emlakotomasyonu.Properties.Resources._2_Hot_Home_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(627, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 145);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ilantipi";
            this.Column6.HeaderText = "Kimden";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "esyalimi";
            this.Column4.HeaderText = "Eşyalı mı";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "odasayisi";
            this.Column1.HeaderText = "Oda Sayısı";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "binakkat";
            this.Column3.HeaderText = "Kat";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fiyat";
            this.Column2.HeaderText = "Fiyat";
            this.Column2.Name = "Column2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aranan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.icozellik);
            this.Controls.Add(this.dızozellik);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kimden.ResumeLayout(false);
            this.kimden.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.TextBox oda;
        private System.Windows.Forms.Label esyalimi;
        private System.Windows.Forms.Label kacincikat;
        private System.Windows.Forms.Label idfiyat;
        private System.Windows.Forms.Label odasayisi;
        private System.Windows.Forms.Button dızozellik;
        private System.Windows.Forms.Button icozellik;
        private System.Windows.Forms.TextBox kat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzelt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton hayır;
        private System.Windows.Forms.RadioButton evet;
        private System.Windows.Forms.GroupBox kimden;
        private System.Windows.Forms.RadioButton emlak;
        private System.Windows.Forms.RadioButton sahibinden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}