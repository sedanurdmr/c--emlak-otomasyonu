namespace emlakotomasyonu
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btndüzelt = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ilanno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yalarmi = new System.Windows.Forms.GroupBox();
            this.yyok = new System.Windows.Forms.RadioButton();
            this.yvar = new System.Windows.Forms.RadioButton();
            this.balkon = new System.Windows.Forms.GroupBox();
            this.byok = new System.Windows.Forms.RadioButton();
            this.bvar = new System.Windows.Forms.RadioButton();
            this.isicam = new System.Windows.Forms.GroupBox();
            this.iyok = new System.Windows.Forms.RadioButton();
            this.ivar = new System.Windows.Forms.RadioButton();
            this.gdiyafon = new System.Windows.Forms.GroupBox();
            this.gyok = new System.Windows.Forms.RadioButton();
            this.gvar = new System.Windows.Forms.RadioButton();
            this.asansor = new System.Windows.Forms.GroupBox();
            this.ayok = new System.Windows.Forms.RadioButton();
            this.avar = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.yalarmi.SuspendLayout();
            this.balkon.SuspendLayout();
            this.isicam.SuspendLayout();
            this.gdiyafon.SuspendLayout();
            this.asansor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(287, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 281);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "asansor";
            this.Column1.HeaderText = "Asansör";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "yanginalarmi";
            this.Column2.HeaderText = "Yangın Alarmı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "balkon";
            this.Column3.HeaderText = "Balkon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "isicam";
            this.Column4.HeaderText = "Isıcam";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gdiyafon";
            this.Column5.HeaderText = "Görüntülü Diyafon";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btndüzelt);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 2;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(278, 36);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 37);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "    Sil";
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
            this.btndüzelt.Location = new System.Drawing.Point(172, 36);
            this.btndüzelt.Name = "btndüzelt";
            this.btndüzelt.Size = new System.Drawing.Size(75, 37);
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
            this.btnkaydet.Location = new System.Drawing.Point(59, 36);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 37);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ilanno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İÇ ÖZELLİKLER";
            // 
            // ilanno
            // 
            this.ilanno.FormattingEnabled = true;
            this.ilanno.Location = new System.Drawing.Point(76, 19);
            this.ilanno.Name = "ilanno";
            this.ilanno.Size = new System.Drawing.Size(143, 21);
            this.ilanno.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan No:";
            // 
            // yalarmi
            // 
            this.yalarmi.Controls.Add(this.yyok);
            this.yalarmi.Controls.Add(this.yvar);
            this.yalarmi.Location = new System.Drawing.Point(12, 110);
            this.yalarmi.Name = "yalarmi";
            this.yalarmi.Size = new System.Drawing.Size(256, 35);
            this.yalarmi.TabIndex = 11;
            this.yalarmi.TabStop = false;
            this.yalarmi.Text = "Yangın Alarmı";
            // 
            // yyok
            // 
            this.yyok.AutoSize = true;
            this.yyok.Location = new System.Drawing.Point(177, 12);
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
            this.yvar.Location = new System.Drawing.Point(112, 12);
            this.yvar.Name = "yvar";
            this.yvar.Size = new System.Drawing.Size(40, 17);
            this.yvar.TabIndex = 12;
            this.yvar.TabStop = true;
            this.yvar.Text = "var";
            this.yvar.UseVisualStyleBackColor = true;
            // 
            // balkon
            // 
            this.balkon.Controls.Add(this.byok);
            this.balkon.Controls.Add(this.bvar);
            this.balkon.Location = new System.Drawing.Point(12, 151);
            this.balkon.Name = "balkon";
            this.balkon.Size = new System.Drawing.Size(256, 38);
            this.balkon.TabIndex = 12;
            this.balkon.TabStop = false;
            this.balkon.Text = "Balkon";
            // 
            // byok
            // 
            this.byok.AutoSize = true;
            this.byok.Location = new System.Drawing.Point(177, 15);
            this.byok.Name = "byok";
            this.byok.Size = new System.Drawing.Size(42, 17);
            this.byok.TabIndex = 15;
            this.byok.TabStop = true;
            this.byok.Text = "yok";
            this.byok.UseVisualStyleBackColor = true;
            // 
            // bvar
            // 
            this.bvar.AutoSize = true;
            this.bvar.Location = new System.Drawing.Point(112, 15);
            this.bvar.Name = "bvar";
            this.bvar.Size = new System.Drawing.Size(40, 17);
            this.bvar.TabIndex = 14;
            this.bvar.TabStop = true;
            this.bvar.Text = "var";
            this.bvar.UseVisualStyleBackColor = true;
            // 
            // isicam
            // 
            this.isicam.Controls.Add(this.iyok);
            this.isicam.Controls.Add(this.ivar);
            this.isicam.Location = new System.Drawing.Point(12, 195);
            this.isicam.Name = "isicam";
            this.isicam.Size = new System.Drawing.Size(256, 38);
            this.isicam.TabIndex = 13;
            this.isicam.TabStop = false;
            this.isicam.Text = "Isıcam";
            // 
            // iyok
            // 
            this.iyok.AutoSize = true;
            this.iyok.Location = new System.Drawing.Point(177, 10);
            this.iyok.Name = "iyok";
            this.iyok.Size = new System.Drawing.Size(42, 17);
            this.iyok.TabIndex = 17;
            this.iyok.TabStop = true;
            this.iyok.Text = "yok";
            this.iyok.UseVisualStyleBackColor = true;
            // 
            // ivar
            // 
            this.ivar.AutoSize = true;
            this.ivar.Location = new System.Drawing.Point(112, 10);
            this.ivar.Name = "ivar";
            this.ivar.Size = new System.Drawing.Size(40, 17);
            this.ivar.TabIndex = 16;
            this.ivar.TabStop = true;
            this.ivar.Text = "var";
            this.ivar.UseVisualStyleBackColor = true;
            // 
            // gdiyafon
            // 
            this.gdiyafon.Controls.Add(this.gyok);
            this.gdiyafon.Controls.Add(this.gvar);
            this.gdiyafon.Location = new System.Drawing.Point(12, 239);
            this.gdiyafon.Name = "gdiyafon";
            this.gdiyafon.Size = new System.Drawing.Size(256, 39);
            this.gdiyafon.TabIndex = 14;
            this.gdiyafon.TabStop = false;
            this.gdiyafon.Text = "Görüntülü Diyafon";
            // 
            // gyok
            // 
            this.gyok.AutoSize = true;
            this.gyok.Location = new System.Drawing.Point(177, 8);
            this.gyok.Name = "gyok";
            this.gyok.Size = new System.Drawing.Size(42, 17);
            this.gyok.TabIndex = 19;
            this.gyok.TabStop = true;
            this.gyok.Text = "yok";
            this.gyok.UseVisualStyleBackColor = true;
            // 
            // gvar
            // 
            this.gvar.AutoSize = true;
            this.gvar.Location = new System.Drawing.Point(112, 8);
            this.gvar.Name = "gvar";
            this.gvar.Size = new System.Drawing.Size(40, 17);
            this.gvar.TabIndex = 18;
            this.gvar.TabStop = true;
            this.gvar.Text = "var";
            this.gvar.UseVisualStyleBackColor = true;
            // 
            // asansor
            // 
            this.asansor.Controls.Add(this.ayok);
            this.asansor.Controls.Add(this.avar);
            this.asansor.Location = new System.Drawing.Point(12, 67);
            this.asansor.Name = "asansor";
            this.asansor.Size = new System.Drawing.Size(256, 37);
            this.asansor.TabIndex = 15;
            this.asansor.TabStop = false;
            this.asansor.Text = "Asansor";
            // 
            // ayok
            // 
            this.ayok.AutoSize = true;
            this.ayok.Location = new System.Drawing.Point(177, 14);
            this.ayok.Name = "ayok";
            this.ayok.Size = new System.Drawing.Size(42, 17);
            this.ayok.TabIndex = 11;
            this.ayok.TabStop = true;
            this.ayok.Text = "yok";
            this.ayok.UseVisualStyleBackColor = true;
            // 
            // avar
            // 
            this.avar.AutoSize = true;
            this.avar.Location = new System.Drawing.Point(112, 14);
            this.avar.Name = "avar";
            this.avar.Size = new System.Drawing.Size(40, 17);
            this.avar.TabIndex = 10;
            this.avar.TabStop = true;
            this.avar.Text = "var";
            this.avar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::emlakotomasyonu.Properties.Resources.Smurf_House_Interior_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 116);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.asansor);
            this.Controls.Add(this.gdiyafon);
            this.Controls.Add(this.isicam);
            this.Controls.Add(this.balkon);
            this.Controls.Add(this.yalarmi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.yalarmi.ResumeLayout(false);
            this.yalarmi.PerformLayout();
            this.balkon.ResumeLayout(false);
            this.balkon.PerformLayout();
            this.isicam.ResumeLayout(false);
            this.isicam.PerformLayout();
            this.gdiyafon.ResumeLayout(false);
            this.gdiyafon.PerformLayout();
            this.asansor.ResumeLayout(false);
            this.asansor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzelt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ilanno;
        private System.Windows.Forms.GroupBox yalarmi;
        private System.Windows.Forms.RadioButton yyok;
        private System.Windows.Forms.RadioButton yvar;
        private System.Windows.Forms.GroupBox balkon;
        private System.Windows.Forms.RadioButton byok;
        private System.Windows.Forms.RadioButton bvar;
        private System.Windows.Forms.GroupBox isicam;
        private System.Windows.Forms.RadioButton iyok;
        private System.Windows.Forms.RadioButton ivar;
        private System.Windows.Forms.GroupBox gdiyafon;
        private System.Windows.Forms.RadioButton gyok;
        private System.Windows.Forms.RadioButton gvar;
        private System.Windows.Forms.GroupBox asansor;
        private System.Windows.Forms.RadioButton ayok;
        private System.Windows.Forms.RadioButton avar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}