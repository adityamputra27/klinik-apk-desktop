namespace KlinikApp
{
    partial class FORM_PENDAFTARAN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_PENDAFTARAN));
            this.label14 = new System.Windows.Forms.Label();
            this.txtktp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnoantri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtjk = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtriwayat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdaftar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcarinamapasien = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tgldaftar = new System.Windows.Forms.TextBox();
            this.garis = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btncari = new System.Windows.Forms.Button();
            this.otomatis = new System.Windows.Forms.RadioButton();
            this.manual = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(36, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 62;
            this.label14.Text = "No KTP";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtktp
            // 
            this.txtktp.Font = new System.Drawing.Font("Myriad Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtktp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtktp.Location = new System.Drawing.Point(116, 128);
            this.txtktp.Name = "txtktp";
            this.txtktp.Size = new System.Drawing.Size(350, 33);
            this.txtktp.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "PENDAFTARAN PASIEN";
            // 
            // txtnoantri
            // 
            this.txtnoantri.Enabled = false;
            this.txtnoantri.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoantri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnoantri.Location = new System.Drawing.Point(217, 521);
            this.txtnoantri.Name = "txtnoantri";
            this.txtnoantri.Size = new System.Drawing.Size(87, 30);
            this.txtnoantri.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(28, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 22);
            this.label10.TabIndex = 74;
            this.label10.Text = "Tanggal Pendaftaran";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(32, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 22);
            this.label11.TabIndex = 75;
            this.label11.Text = "No Antrian Pasien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtjk);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtriwayat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 255);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Pasien";
            // 
            // txtjk
            // 
            this.txtjk.Enabled = false;
            this.txtjk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjk.Location = new System.Drawing.Point(171, 125);
            this.txtjk.Name = "txtjk";
            this.txtjk.Size = new System.Drawing.Size(202, 29);
            this.txtjk.TabIndex = 79;
            // 
            // txtno
            // 
            this.txtno.Enabled = false;
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(170, 88);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(202, 29);
            this.txtno.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(13, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 22);
            this.label13.TabIndex = 77;
            this.label13.Text = "Jenis Kelamin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 76;
            this.label9.Text = "No Telp / WA";
            // 
            // txtriwayat
            // 
            this.txtriwayat.Location = new System.Drawing.Point(171, 165);
            this.txtriwayat.Name = "txtriwayat";
            this.txtriwayat.Size = new System.Drawing.Size(202, 83);
            this.txtriwayat.TabIndex = 75;
            this.txtriwayat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Riwayat Penyakit";
            // 
            // txtnama
            // 
            this.txtnama.Enabled = false;
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(170, 48);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(202, 29);
            this.txtnama.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nama Pasien";
            // 
            // dgvdaftar
            // 
            this.dgvdaftar.AllowUserToAddRows = false;
            this.dgvdaftar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvdaftar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdaftar.BackgroundColor = System.Drawing.Color.White;
            this.dgvdaftar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdaftar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdaftar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdaftar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdaftar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdaftar.EnableHeadersVisualStyles = false;
            this.dgvdaftar.Location = new System.Drawing.Point(457, 249);
            this.dgvdaftar.Name = "dgvdaftar";
            this.dgvdaftar.ReadOnly = true;
            this.dgvdaftar.Size = new System.Drawing.Size(628, 427);
            this.dgvdaftar.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(453, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 100;
            this.label6.Text = "Cari Nama Pasien";
            // 
            // txtcarinamapasien
            // 
            this.txtcarinamapasien.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarinamapasien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcarinamapasien.Location = new System.Drawing.Point(614, 201);
            this.txtcarinamapasien.Name = "txtcarinamapasien";
            this.txtcarinamapasien.Size = new System.Drawing.Size(471, 30);
            this.txtcarinamapasien.TabIndex = 99;
            this.txtcarinamapasien.TextChanged += new System.EventHandler(this.txtcarinamapasien_TextChanged);
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
            this.btncancel.Location = new System.Drawing.Point(246, 635);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btncancel.Size = new System.Drawing.Size(123, 44);
            this.btncancel.TabIndex = 169;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
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
            this.btnsave.Location = new System.Drawing.Point(105, 635);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnsave.Size = new System.Drawing.Size(123, 44);
            this.btnsave.TabIndex = 168;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // tgldaftar
            // 
            this.tgldaftar.Enabled = false;
            this.tgldaftar.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgldaftar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tgldaftar.Location = new System.Drawing.Point(217, 482);
            this.tgldaftar.Name = "tgldaftar";
            this.tgldaftar.Size = new System.Drawing.Size(192, 30);
            this.tgldaftar.TabIndex = 174;
            // 
            // garis
            // 
            this.garis.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.garis.Name = "garis";
            this.garis.X1 = 42;
            this.garis.X2 = 1097;
            this.garis.Y1 = 86;
            this.garis.Y2 = 86;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.garis});
            this.shapeContainer1.Size = new System.Drawing.Size(1127, 715);
            this.shapeContainer1.TabIndex = 175;
            this.shapeContainer1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(252, 643);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.TabIndex = 171;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(110, 642);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 32);
            this.pictureBox7.TabIndex = 170;
            this.pictureBox7.TabStop = false;
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
            this.btncari.Location = new System.Drawing.Point(475, 118);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(55, 51);
            this.btncari.TabIndex = 73;
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // otomatis
            // 
            this.otomatis.AutoSize = true;
            this.otomatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otomatis.Location = new System.Drawing.Point(310, 523);
            this.otomatis.Name = "otomatis";
            this.otomatis.Size = new System.Drawing.Size(130, 26);
            this.otomatis.TabIndex = 176;
            this.otomatis.TabStop = true;
            this.otomatis.Text = "OTOMATIS";
            this.otomatis.UseVisualStyleBackColor = true;
            this.otomatis.CheckedChanged += new System.EventHandler(this.otomatis_CheckedChanged);
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual.Location = new System.Drawing.Point(310, 555);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(108, 26);
            this.manual.TabIndex = 177;
            this.manual.TabStop = true;
            this.manual.Text = "MANUAL";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.CheckedChanged += new System.EventHandler(this.manual_CheckedChanged);
            // 
            // FORM_PENDAFTARAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1127, 715);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.otomatis);
            this.Controls.Add(this.tgldaftar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcarinamapasien);
            this.Controls.Add(this.dgvdaftar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtnoantri);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtktp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_PENDAFTARAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_PENDAFTARAN";
            this.Load += new System.EventHandler(this.FORM_PENDAFTARAN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaftar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtktp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnoantri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.DataGridView dgvdaftar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcarinamapasien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tgldaftar;
        private System.Windows.Forms.RichTextBox txtriwayat;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape garis;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtjk;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton otomatis;
        private System.Windows.Forms.RadioButton manual;

    }
}