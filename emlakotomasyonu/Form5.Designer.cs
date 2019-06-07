namespace emlakotomasyonu
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btndüzelt = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.park = new System.Windows.Forms.GroupBox();
            this.pyok = new System.Windows.Forms.RadioButton();
            this.pvar = new System.Windows.Forms.RadioButton();
            this.alarm = new System.Windows.Forms.GroupBox();
            this.ayok = new System.Windows.Forms.RadioButton();
            this.avar = new System.Windows.Forms.RadioButton();
            this.otopark = new System.Windows.Forms.GroupBox();
            this.oyok = new System.Windows.Forms.RadioButton();
            this.ovar = new System.Windows.Forms.RadioButton();
            this.ymerdiveni = new System.Windows.Forms.GroupBox();
            this.yyok = new System.Windows.Forms.RadioButton();
            this.yvar = new System.Windows.Forms.RadioButton();
            this.guvenlik = new System.Windows.Forms.GroupBox();
            this.gyok = new System.Windows.Forms.RadioButton();
            this.gvar = new System.Windows.Forms.RadioButton();
            this.kapici = new System.Windows.Forms.GroupBox();
            this.kyok = new System.Windows.Forms.RadioButton();
            this.kvar = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilanno = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.park.SuspendLayout();
            this.alarm.SuspendLayout();
            this.otopark.SuspendLayout();
            this.ymerdiveni.SuspendLayout();
            this.guvenlik.SuspendLayout();
            this.kapici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ilanno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIŞ ÖZELLİKLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(287, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 310);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "park";
            this.Column1.HeaderText = "Park";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "alarm";
            this.Column2.HeaderText = "Alarm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "otopark";
            this.Column3.HeaderText = "Otopark";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ymerdiveni";
            this.Column4.HeaderText = "Yangın Merdiveni";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "guvenlik";
            this.Column5.HeaderText = "Güvenlik";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "kapici";
            this.Column6.HeaderText = "Kapıcı";
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btndüzelt);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 2;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(281, 24);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 36);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "     Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Folder-Home-Folder-icon.png");
            this.ımageList1.Images.SetKeyName(1, "folder-home-icon.png");
            this.ımageList1.Images.SetKeyName(2, "Recycle-Bin-Full-icon.png");
            // 
            // btndüzelt
            // 
            this.btndüzelt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndüzelt.ImageIndex = 1;
            this.btndüzelt.ImageList = this.ımageList1;
            this.btndüzelt.Location = new System.Drawing.Point(166, 24);
            this.btndüzelt.Name = "btndüzelt";
            this.btndüzelt.Size = new System.Drawing.Size(75, 36);
            this.btndüzelt.TabIndex = 16;
            this.btndüzelt.Text = "Düzelt";
            this.btndüzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndüzelt.UseVisualStyleBackColor = true;
            this.btndüzelt.Click += new System.EventHandler(this.btndüzelt_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 0;
            this.btnkaydet.ImageList = this.ımageList1;
            this.btnkaydet.Location = new System.Drawing.Point(51, 24);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 36);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // park
            // 
            this.park.Controls.Add(this.pyok);
            this.park.Controls.Add(this.pvar);
            this.park.Location = new System.Drawing.Point(12, 69);
            this.park.Name = "park";
            this.park.Size = new System.Drawing.Size(269, 29);
            this.park.TabIndex = 9;
            this.park.TabStop = false;
            this.park.Text = "Park";
            // 
            // pyok
            // 
            this.pyok.AutoSize = true;
            this.pyok.Location = new System.Drawing.Point(189, 9);
            this.pyok.Name = "pyok";
            this.pyok.Size = new System.Drawing.Size(42, 17);
            this.pyok.TabIndex = 13;
            this.pyok.TabStop = true;
            this.pyok.Text = "yok";
            this.pyok.UseVisualStyleBackColor = true;
            // 
            // pvar
            // 
            this.pvar.AutoSize = true;
            this.pvar.Location = new System.Drawing.Point(124, 9);
            this.pvar.Name = "pvar";
            this.pvar.Size = new System.Drawing.Size(40, 17);
            this.pvar.TabIndex = 12;
            this.pvar.TabStop = true;
            this.pvar.Text = "var";
            this.pvar.UseVisualStyleBackColor = true;
            // 
            // alarm
            // 
            this.alarm.Controls.Add(this.ayok);
            this.alarm.Controls.Add(this.avar);
            this.alarm.Location = new System.Drawing.Point(12, 104);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(269, 33);
            this.alarm.TabIndex = 10;
            this.alarm.TabStop = false;
            this.alarm.Text = "Alarm";
            // 
            // ayok
            // 
            this.ayok.AutoSize = true;
            this.ayok.Location = new System.Drawing.Point(189, 9);
            this.ayok.Name = "ayok";
            this.ayok.Size = new System.Drawing.Size(42, 17);
            this.ayok.TabIndex = 13;
            this.ayok.TabStop = true;
            this.ayok.Text = "yok";
            this.ayok.UseVisualStyleBackColor = true;
            // 
            // avar
            // 
            this.avar.AutoSize = true;
            this.avar.Location = new System.Drawing.Point(124, 9);
            this.avar.Name = "avar";
            this.avar.Size = new System.Drawing.Size(40, 17);
            this.avar.TabIndex = 12;
            this.avar.TabStop = true;
            this.avar.Text = "var";
            this.avar.UseVisualStyleBackColor = true;
            // 
            // otopark
            // 
            this.otopark.Controls.Add(this.oyok);
            this.otopark.Controls.Add(this.ovar);
            this.otopark.Location = new System.Drawing.Point(12, 143);
            this.otopark.Name = "otopark";
            this.otopark.Size = new System.Drawing.Size(269, 34);
            this.otopark.TabIndex = 11;
            this.otopark.TabStop = false;
            this.otopark.Text = "Otopark";
            // 
            // oyok
            // 
            this.oyok.AutoSize = true;
            this.oyok.Location = new System.Drawing.Point(189, 9);
            this.oyok.Name = "oyok";
            this.oyok.Size = new System.Drawing.Size(42, 17);
            this.oyok.TabIndex = 13;
            this.oyok.TabStop = true;
            this.oyok.Text = "yok";
            this.oyok.UseVisualStyleBackColor = true;
            // 
            // ovar
            // 
            this.ovar.AutoSize = true;
            this.ovar.Location = new System.Drawing.Point(124, 9);
            this.ovar.Name = "ovar";
            this.ovar.Size = new System.Drawing.Size(40, 17);
            this.ovar.TabIndex = 12;
            this.ovar.TabStop = true;
            this.ovar.Text = "var";
            this.ovar.UseVisualStyleBackColor = true;
            // 
            // ymerdiveni
            // 
            this.ymerdiveni.Controls.Add(this.yyok);
            this.ymerdiveni.Controls.Add(this.yvar);
            this.ymerdiveni.Location = new System.Drawing.Point(12, 183);
            this.ymerdiveni.Name = "ymerdiveni";
            this.ymerdiveni.Size = new System.Drawing.Size(269, 34);
            this.ymerdiveni.TabIndex = 12;
            this.ymerdiveni.TabStop = false;
            this.ymerdiveni.Text = "Yangın Merdiveni";
            // 
            // yyok
            // 
            this.yyok.AutoSize = true;
            this.yyok.Location = new System.Drawing.Point(189, 10);
            this.yyok.Name = "yyok";
            this.yyok.Size = new System.Drawing.Size(42, 17);
            this.yyok.TabIndex = 13;
            this.yyok.TabStop = true;
            this.yyok.Text = "yok";
            this.yyok.UseVisualStyleBackColor = true;
            // 
            // yvar
            // 
            this.yvar.AutoSize = true;
            this.yvar.Location = new System.Drawing.Point(124, 10);
            this.yvar.Name = "yvar";
            this.yvar.Size = new System.Drawing.Size(40, 17);
            this.yvar.TabIndex = 12;
            this.yvar.TabStop = true;
            this.yvar.Text = "var";
            this.yvar.UseVisualStyleBackColor = true;
            // 
            // guvenlik
            // 
            this.guvenlik.Controls.Add(this.gyok);
            this.guvenlik.Controls.Add(this.gvar);
            this.guvenlik.Location = new System.Drawing.Point(12, 223);
            this.guvenlik.Name = "guvenlik";
            this.guvenlik.Size = new System.Drawing.Size(269, 33);
            this.guvenlik.TabIndex = 13;
            this.guvenlik.TabStop = false;
            this.guvenlik.Text = "Güvenlik";
            // 
            // gyok
            // 
            this.gyok.AutoSize = true;
            this.gyok.Location = new System.Drawing.Point(190, 9);
            this.gyok.Name = "gyok";
            this.gyok.Size = new System.Drawing.Size(42, 17);
            this.gyok.TabIndex = 13;
            this.gyok.TabStop = true;
            this.gyok.Text = "yok";
            this.gyok.UseVisualStyleBackColor = true;
            // 
            // gvar
            // 
            this.gvar.AutoSize = true;
            this.gvar.Location = new System.Drawing.Point(125, 9);
            this.gvar.Name = "gvar";
            this.gvar.Size = new System.Drawing.Size(40, 17);
            this.gvar.TabIndex = 12;
            this.gvar.TabStop = true;
            this.gvar.Text = "var";
            this.gvar.UseVisualStyleBackColor = true;
            // 
            // kapici
            // 
            this.kapici.Controls.Add(this.kyok);
            this.kapici.Controls.Add(this.kvar);
            this.kapici.Location = new System.Drawing.Point(12, 262);
            this.kapici.Name = "kapici";
            this.kapici.Size = new System.Drawing.Size(269, 35);
            this.kapici.TabIndex = 14;
            this.kapici.TabStop = false;
            this.kapici.Text = "Kapıcı";
            // 
            // kyok
            // 
            this.kyok.AutoSize = true;
            this.kyok.Location = new System.Drawing.Point(189, 9);
            this.kyok.Name = "kyok";
            this.kyok.Size = new System.Drawing.Size(42, 17);
            this.kyok.TabIndex = 13;
            this.kyok.TabStop = true;
            this.kyok.Text = "yok";
            this.kyok.UseVisualStyleBackColor = true;
            // 
            // kvar
            // 
            this.kvar.AutoSize = true;
            this.kvar.Location = new System.Drawing.Point(124, 9);
            this.kvar.Name = "kvar";
            this.kvar.Size = new System.Drawing.Size(40, 17);
            this.kvar.TabIndex = 12;
            this.kvar.TabStop = true;
            this.kvar.Text = "var";
            this.kvar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::emlakotomasyonu.Properties.Resources.Smurf_House_Exterior_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 108);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ilanno
            // 
            this.ilanno.FormattingEnabled = true;
            this.ilanno.Location = new System.Drawing.Point(105, 19);
            this.ilanno.Name = "ilanno";
            this.ilanno.Size = new System.Drawing.Size(126, 21);
            this.ilanno.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kapici);
            this.Controls.Add(this.guvenlik);
            this.Controls.Add(this.ymerdiveni);
            this.Controls.Add(this.otopark);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.park);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.park.ResumeLayout(false);
            this.park.PerformLayout();
            this.alarm.ResumeLayout(false);
            this.alarm.PerformLayout();
            this.otopark.ResumeLayout(false);
            this.otopark.PerformLayout();
            this.ymerdiveni.ResumeLayout(false);
            this.ymerdiveni.PerformLayout();
            this.guvenlik.ResumeLayout(false);
            this.guvenlik.PerformLayout();
            this.kapici.ResumeLayout(false);
            this.kapici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzelt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox park;
        private System.Windows.Forms.GroupBox alarm;
        private System.Windows.Forms.GroupBox otopark;
        private System.Windows.Forms.GroupBox ymerdiveni;
        private System.Windows.Forms.GroupBox guvenlik;
        private System.Windows.Forms.GroupBox kapici;
        private System.Windows.Forms.RadioButton pyok;
        private System.Windows.Forms.RadioButton pvar;
        private System.Windows.Forms.RadioButton ayok;
        private System.Windows.Forms.RadioButton avar;
        private System.Windows.Forms.RadioButton oyok;
        private System.Windows.Forms.RadioButton ovar;
        private System.Windows.Forms.RadioButton yyok;
        private System.Windows.Forms.RadioButton yvar;
        private System.Windows.Forms.RadioButton gyok;
        private System.Windows.Forms.RadioButton gvar;
        private System.Windows.Forms.RadioButton kyok;
        private System.Windows.Forms.RadioButton kvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ilanno;
    }
}