namespace KlinikApp
{
    partial class FORM_PEMERIKSAAN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_PEMERIKSAAN));
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdokter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtriwayat = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnamapasien = new System.Windows.Forms.TextBox();
            this.txttindakan = new System.Windows.Forms.RichTextBox();
            this.txtdiagnosa = new System.Windows.Forms.RichTextBox();
            this.txtkeluhan = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvperiksa = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.garis = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtperawatan = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btncari = new System.Windows.Forms.Button();
            this.btncaridokter = new System.Windows.Forms.Button();
            this.txttgldaftar = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvperiksa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(33, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 24);
            this.label14.TabIndex = 103;
            this.label14.Text = "Cari Tanggal Pendaftaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 37);
            this.label2.TabIndex = 101;
            this.label2.Text = "PEMERIKSAAN PASIEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(589, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 121;
            this.label3.Text = "Diperiksa Oleh : ";
            // 
            // txtdokter
            // 
            this.txtdokter.Enabled = false;
            this.txtdokter.Font = new System.Drawing.Font("Myriad Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdokter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdokter.Location = new System.Drawing.Point(737, 139);
            this.txtdokter.Name = "txtdokter";
            this.txtdokter.Size = new System.Drawing.Size(274, 33);
            this.txtdokter.TabIndex = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtriwayat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnamapasien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 157);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 141;
            this.label1.Text = "Riwayat Penyakit";
            // 
            // txtriwayat
            // 
            this.txtriwayat.Enabled = false;
            this.txtriwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtriwayat.Location = new System.Drawing.Point(155, 77);
            this.txtriwayat.Name = "txtriwayat";
            this.txtriwayat.Size = new System.Drawing.Size(287, 57);
            this.txtriwayat.TabIndex = 140;
            this.txtriwayat.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 125;
            this.label4.Text = "Nama Pasien";
            // 
            // txtnamapasien
            // 
            this.txtnamapasien.Enabled = false;
            this.txtnamapasien.Font = new System.Drawing.Font("Myriad Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamapasien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnamapasien.Location = new System.Drawing.Point(155, 24);
            this.txtnamapasien.Name = "txtnamapasien";
            this.txtnamapasien.Size = new System.Drawing.Size(287, 33);
            this.txtnamapasien.TabIndex = 124;
            // 
            // txttindakan
            // 
            this.txttindakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttindakan.Location = new System.Drawing.Point(195, 177);
            this.txttindakan.Name = "txttindakan";
            this.txttindakan.Size = new System.Drawing.Size(287, 57);
            this.txttindakan.TabIndex = 138;
            this.txttindakan.Text = "";
            // 
            // txtdiagnosa
            // 
            this.txtdiagnosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnosa.Location = new System.Drawing.Point(195, 105);
            this.txtdiagnosa.Name = "txtdiagnosa";
            this.txtdiagnosa.Size = new System.Drawing.Size(287, 57);
            this.txtdiagnosa.TabIndex = 137;
            this.txtdiagnosa.Text = "";
            // 
            // txtkeluhan
            // 
            this.txtkeluhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkeluhan.Location = new System.Drawing.Point(195, 29);
            this.txtkeluhan.Name = "txtkeluhan";
            this.txtkeluhan.Size = new System.Drawing.Size(287, 57);
            this.txtkeluhan.TabIndex = 136;
            this.txtkeluhan.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(48, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 135;
            this.label7.Text = "Perawatan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(48, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 133;
            this.label8.Text = "Tindakan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(48, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 129;
            this.label6.Text = "Diagnosa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(48, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 127;
            this.label5.Text = "Keluhan";
            // 
            // dgvperiksa
            // 
            this.dgvperiksa.AllowUserToAddRows = false;
            this.dgvperiksa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvperiksa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvperiksa.BackgroundColor = System.Drawing.Color.White;
            this.dgvperiksa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvperiksa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvperiksa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvperiksa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvperiksa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvperiksa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvperiksa.EnableHeadersVisualStyles = false;
            this.dgvperiksa.Location = new System.Drawing.Point(554, 202);
            this.dgvperiksa.Name = "dgvperiksa";
            this.dgvperiksa.ReadOnly = true;
            this.dgvperiksa.Size = new System.Drawing.Size(518, 108);
            this.dgvperiksa.TabIndex = 123;
            this.dgvperiksa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvperiksa_CellContentClick);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(37, 552);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btncancel.Size = new System.Drawing.Size(459, 51);
            this.btncancel.TabIndex = 138;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(37, 482);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnsave.Size = new System.Drawing.Size(458, 51);
            this.btnsave.TabIndex = 137;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // garis
            // 
            this.garis.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.garis.Name = "garis";
            this.garis.X1 = 35;
            this.garis.X2 = 1067;
            this.garis.Y1 = 107;
            this.garis.Y2 = 107;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.garis});
            this.shapeContainer1.Size = new System.Drawing.Size(1127, 715);
            this.shapeContainer1.TabIndex = 141;
            this.shapeContainer1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtperawatan);
            this.groupBox2.Controls.Add(this.txttindakan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdiagnosa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtkeluhan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(554, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 325);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pemeriksaan";
            // 
            // txtperawatan
            // 
            this.txtperawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperawatan.FormattingEnabled = true;
            this.txtperawatan.Items.AddRange(new object[] {
            "RAWAT JALAN",
            "RAWAT INAP",
            "ISTIRAHAT DI RUMAH / PULANG"});
            this.txtperawatan.Location = new System.Drawing.Point(195, 248);
            this.txtperawatan.Name = "txtperawatan";
            this.txtperawatan.Size = new System.Drawing.Size(287, 32);
            this.txtperawatan.TabIndex = 139;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(193, 560);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(192, 488);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(42, 39);
            this.pictureBox10.TabIndex = 139;
            this.pictureBox10.TabStop = false;
            // 
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.Color.White;
            this.btncari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncari.BackgroundImage")));
            this.btncari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncari.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(171)))));
            this.btncari.FlatAppearance.BorderSize = 0;
            this.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncari.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btncari.Location = new System.Drawing.Point(512, 127);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(55, 51);
            this.btncari.TabIndex = 106;
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // btncaridokter
            // 
            this.btncaridokter.BackColor = System.Drawing.Color.White;
            this.btncaridokter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncaridokter.BackgroundImage")));
            this.btncaridokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncaridokter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncaridokter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(88)))), ((int)(((byte)(171)))));
            this.btncaridokter.FlatAppearance.BorderSize = 0;
            this.btncaridokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncaridokter.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaridokter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btncaridokter.Location = new System.Drawing.Point(1017, 127);
            this.btncaridokter.Name = "btncaridokter";
            this.btncaridokter.Size = new System.Drawing.Size(55, 51);
            this.btncaridokter.TabIndex = 142;
            this.btncaridokter.UseVisualStyleBackColor = false;
            this.btncaridokter.Click += new System.EventHandler(this.btncaridokter_Click);
            // 
            // txttgldaftar
            // 
            this.txttgldaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttgldaftar.Location = new System.Drawing.Point(256, 139);
            this.txttgldaftar.Name = "txttgldaftar";
            this.txttgldaftar.Size = new System.Drawing.Size(240, 29);
            this.txttgldaftar.TabIndex = 190;
            // 
            // FORM_PEMERIKSAAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1127, 715);
            this.Controls.Add(this.txttgldaftar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncaridokter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvperiksa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdokter);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_PEMERIKSAAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FORM_PEMERIKSAAN";
            this.Load += new System.EventHandler(this.FORM_PEMERIKSAAN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvperiksa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdokter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamapasien;
        private System.Windows.Forms.DataGridView dgvperiksa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private Microsoft.VisualBasic.PowerPacks.LineShape garis;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.RichTextBox txttindakan;
        private System.Windows.Forms.RichTextBox txtdiagnosa;
        private System.Windows.Forms.RichTextBox txtkeluhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtriwayat;
        private System.Windows.Forms.ComboBox txtperawatan;
        private System.Windows.Forms.Button btncaridokter;
        private System.Windows.Forms.DateTimePicker txttgldaftar;
    }
}