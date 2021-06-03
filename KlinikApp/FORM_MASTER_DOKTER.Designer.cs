namespace KlinikApp
{
    partial class FORM_MASTER_DOKTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MASTER_DOKTER));
            this.gform = new System.Windows.Forms.GroupBox();
            this.manual = new System.Windows.Forms.RadioButton();
            this.otomatis = new System.Windows.Forms.RadioButton();
            this.txtspesialis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tarif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtno_telp = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.cbo_jk = new System.Windows.Forms.ComboBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtkota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtumur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.dgvmasterdokter = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.garis = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.circularButton4 = new KlinikApp.CircularButton();
            this.gform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasterdokter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gform
            // 
            this.gform.Controls.Add(this.manual);
            this.gform.Controls.Add(this.otomatis);
            this.gform.Controls.Add(this.txtspesialis);
            this.gform.Controls.Add(this.label10);
            this.gform.Controls.Add(this.txt_tarif);
            this.gform.Controls.Add(this.label1);
            this.gform.Controls.Add(this.label8);
            this.gform.Controls.Add(this.txtno_telp);
            this.gform.Controls.Add(this.txtid);
            this.gform.Controls.Add(this.txtnama);
            this.gform.Controls.Add(this.cbo_jk);
            this.gform.Controls.Add(this.txtalamat);
            this.gform.Controls.Add(this.txtkota);
            this.gform.Controls.Add(this.label7);
            this.gform.Controls.Add(this.txtumur);
            this.gform.Controls.Add(this.label6);
            this.gform.Controls.Add(this.label2);
            this.gform.Controls.Add(this.label5);
            this.gform.Controls.Add(this.label3);
            this.gform.Controls.Add(this.label4);
            this.gform.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gform.Location = new System.Drawing.Point(45, 265);
            this.gform.Name = "gform";
            this.gform.Size = new System.Drawing.Size(454, 378);
            this.gform.TabIndex = 27;
            this.gform.TabStop = false;
            this.gform.Text = "FORM";
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual.Location = new System.Drawing.Point(378, 26);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(74, 17);
            this.manual.TabIndex = 181;
            this.manual.TabStop = true;
            this.manual.Text = "MANUAL";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.CheckedChanged += new System.EventHandler(this.manual_CheckedChanged);
            // 
            // otomatis
            // 
            this.otomatis.AutoSize = true;
            this.otomatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otomatis.Location = new System.Drawing.Point(290, 26);
            this.otomatis.Name = "otomatis";
            this.otomatis.Size = new System.Drawing.Size(85, 17);
            this.otomatis.TabIndex = 180;
            this.otomatis.TabStop = true;
            this.otomatis.Text = "OTOMATIS";
            this.otomatis.UseVisualStyleBackColor = true;
            this.otomatis.CheckedChanged += new System.EventHandler(this.otomatis_CheckedChanged);
            // 
            // txtspesialis
            // 
            this.txtspesialis.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtspesialis.Location = new System.Drawing.Point(172, 96);
            this.txtspesialis.Name = "txtspesialis";
            this.txtspesialis.Size = new System.Drawing.Size(249, 27);
            this.txtspesialis.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(1, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Spesialis";
            // 
            // txt_tarif
            // 
            this.txt_tarif.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txt_tarif.Location = new System.Drawing.Point(172, 324);
            this.txt_tarif.Name = "txt_tarif";
            this.txt_tarif.Size = new System.Drawing.Size(249, 27);
            this.txt_tarif.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tarif Dokter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(3, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Jenis Kelamin";
            // 
            // txtno_telp
            // 
            this.txtno_telp.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtno_telp.Location = new System.Drawing.Point(172, 209);
            this.txtno_telp.Name = "txtno_telp";
            this.txtno_telp.Size = new System.Drawing.Size(249, 27);
            this.txtno_telp.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtid.Location = new System.Drawing.Point(172, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 27);
            this.txtid.TabIndex = 6;
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtnama.Location = new System.Drawing.Point(172, 59);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(249, 27);
            this.txtnama.TabIndex = 7;
            // 
            // cbo_jk
            // 
            this.cbo_jk.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.cbo_jk.FormattingEnabled = true;
            this.cbo_jk.Location = new System.Drawing.Point(172, 285);
            this.cbo_jk.Name = "cbo_jk";
            this.cbo_jk.Size = new System.Drawing.Size(249, 27);
            this.cbo_jk.TabIndex = 22;
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtalamat.Location = new System.Drawing.Point(172, 133);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(249, 27);
            this.txtalamat.TabIndex = 8;
            // 
            // txtkota
            // 
            this.txtkota.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtkota.Location = new System.Drawing.Point(172, 171);
            this.txtkota.Name = "txtkota";
            this.txtkota.Size = new System.Drawing.Size(249, 27);
            this.txtkota.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(3, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Umur";
            // 
            // txtumur
            // 
            this.txtumur.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.txtumur.Location = new System.Drawing.Point(172, 247);
            this.txtumur.Name = "txtumur";
            this.txtumur.Size = new System.Drawing.Size(249, 27);
            this.txtumur.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(1, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "No Telepon / WA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Dokter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(1, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(1, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(165, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 37);
            this.label9.TabIndex = 36;
            this.label9.Text = "Daftar Dokter";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Myriad Pro", 16F);
            this.txt_cari.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cari.Location = new System.Drawing.Point(642, 194);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(446, 33);
            this.txt_cari.TabIndex = 35;
            this.txt_cari.TextChanged += new System.EventHandler(this.txt_cari_TextChanged);
            // 
            // dgvmasterdokter
            // 
            this.dgvmasterdokter.AllowUserToAddRows = false;
            this.dgvmasterdokter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvmasterdokter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvmasterdokter.BackgroundColor = System.Drawing.Color.White;
            this.dgvmasterdokter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmasterdokter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvmasterdokter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmasterdokter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvmasterdokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmasterdokter.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvmasterdokter.EnableHeadersVisualStyles = false;
            this.dgvmasterdokter.Location = new System.Drawing.Point(520, 252);
            this.dgvmasterdokter.Name = "dgvmasterdokter";
            this.dgvmasterdokter.ReadOnly = true;
            this.dgvmasterdokter.Size = new System.Drawing.Size(568, 446);
            this.dgvmasterdokter.TabIndex = 30;
            this.dgvmasterdokter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmasterdokter_CellContentClick);
            this.dgvmasterdokter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvmasterdokter_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(516, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 38;
            this.label11.Text = "Search Data :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(208, 194);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(123, 44);
            this.btnupdate.TabIndex = 107;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(364, 194);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btndelete.Size = new System.Drawing.Size(123, 44);
            this.btndelete.TabIndex = 106;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btninsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btninsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(54, 194);
            this.btninsert.Name = "btninsert";
            this.btninsert.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btninsert.Size = new System.Drawing.Size(123, 44);
            this.btninsert.TabIndex = 105;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
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
            this.btncancel.Location = new System.Drawing.Point(186, 654);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btncancel.Size = new System.Drawing.Size(123, 44);
            this.btncancel.TabIndex = 104;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
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
            this.btnsave.Location = new System.Drawing.Point(45, 654);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnsave.Size = new System.Drawing.Size(123, 44);
            this.btnsave.TabIndex = 103;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(169, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(418, 17);
            this.label14.TabIndex = 115;
            this.label14.Text = "Tambah, Update dan Hapus serta Tetapkan Tarif Dokter";
            // 
            // garis
            // 
            this.garis.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.garis.Name = "garis";
            this.garis.X1 = 185;
            this.garis.X2 = 1118;
            this.garis.Y1 = 154;
            this.garis.Y2 = 154;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.garis});
            this.shapeContainer1.Size = new System.Drawing.Size(1127, 715);
            this.shapeContainer1.TabIndex = 116;
            this.shapeContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(192, 662);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(50, 661);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(369, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 32);
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(211, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 32);
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(59, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 32);
            this.pictureBox5.TabIndex = 108;
            this.pictureBox5.TabStop = false;
            // 
            // circularButton4
            // 
            this.circularButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.circularButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton4.BackgroundImage")));
            this.circularButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton4.FlatAppearance.BorderSize = 0;
            this.circularButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.circularButton4.Location = new System.Drawing.Point(43, 31);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(111, 117);
            this.circularButton4.TabIndex = 37;
            this.circularButton4.UseVisualStyleBackColor = false;
            this.circularButton4.Click += new System.EventHandler(this.circularButton4_Click);
            // 
            // FORM_MASTER_DOKTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1127, 715);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.circularButton4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cari);
            this.Controls.Add(this.dgvmasterdokter);
            this.Controls.Add(this.gform);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_MASTER_DOKTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FORM_MASTER_DOKTER";
            this.Load += new System.EventHandler(this.FORM_MASTER_DOKTER_Load);
            this.gform.ResumeLayout(false);
            this.gform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasterdokter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.ComboBox cbo_jk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tarif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView dgvmasterdokter;
        private CircularButton circularButton4;
        private System.Windows.Forms.TextBox txtspesialis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtno_telp;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtkota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtumur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label14;
        private Microsoft.VisualBasic.PowerPacks.LineShape garis;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.RadioButton otomatis;

    }
}