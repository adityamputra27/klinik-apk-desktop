using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikApp
{
    public partial class FORM_ADMIN : Form
    {
        MysqlComponent mycom = new MysqlComponent();
        DataTable dtdokter, dtpegawai, dtpasien, dtobat;
        Timer t = new Timer();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
            );
        public FORM_ADMIN(String admin)
        {
            InitializeComponent();
            lblwelkome2.Text = "" + admin;
            //lblwelcome2.Text = "Kamu Login Sebagai : " + admin2;
        
        }

        private void visible_dashboard()
        {
            judul.Visible = false;
            lbltotalpegawai.Visible = false;
            pegawe.Visible = false;
            lbltotalpasien.Visible = false;
            pasien.Visible = false;
            lbltotaldokter.Visible = false;
            dokter.Visible = false;
            lbltotalobat.Visible = false;
            btnpegawai.Visible = false;
            btnpasien.Visible = false;
            btndokter.Visible = false;
            btnobat.Visible = false;
            obat.Visible = false;
        }

        private void unvisible_dashboard()
        {
            judul.Visible = true;
            lbltotalpegawai.Visible = true;
            pegawe.Visible = true;
            lbltotalpasien.Visible = true;
            pasien.Visible = true;
            lbltotaldokter.Visible = true;
            dokter.Visible = true;
            lbltotalobat.Visible = true;
            btnpegawai.Visible = true;
            btnpasien.Visible = true;
            btndokter.Visible = true;
            btnobat.Visible = true;
            obat.Visible = true;
        }

        private void total_pasien()
        {
            dtpasien = new DataTable();
            dtpasien = mycom.getsql("SELECT COUNT(nama_pasien) as total_pasien FROM t_pasien");
            lbltotalpasien.Text = dtpasien.Rows[0]["total_pasien"].ToString();
        }

        private void total_obat()
        {
            dtobat = new DataTable();
            dtobat = mycom.getsql("SELECT COUNT(nama_obat) as total_obat FROM t_obat");
            lbltotalobat.Text = dtobat.Rows[0]["total_obat"].ToString();
        }

        private void total_pegawai()
        {
            dtpegawai = new DataTable();
            dtpegawai = mycom.getsql("SELECT COUNT(nama) as total_nama FROM t_pegawai");
            lbltotalpegawai.Text = dtpegawai.Rows[0]["total_nama"].ToString();
        }

        private void total_dokter()
        {
            dtdokter = new DataTable();
            dtdokter = mycom.getsql("SELECT COUNT(nama_dokter) as total_dokter FROM t_dokter");
            lbltotaldokter.Text = dtdokter.Rows[0]["total_dokter"].ToString();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += " : ";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else 
            {
                time += mm;
            }
            time += " : ";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            lbljam.Text = time;

        }   

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FORM_ADMIN_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            total_dokter();
            total_pasien();
            total_obat();
            total_pegawai();

            panel_c.Visible = false;

            active1.Visible = true;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Perhatian", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void load1()
        {
            gradient_dash.Visible = false;
            shape1.Visible = false;
            shape2.Visible = false;
            shape3.Visible = false;
            shape4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            dokter.Visible = false;
            pegawe.Visible = false;
            obat.Visible = false;
            pasien.Visible = false;
            btndokter.Visible = false;
            btnpegawai.Visible = false;
            btnpasien.Visible = false;
            btnobat.Visible = false;
            lbltotalpegawai.Visible = false;
            lbltotalpasien.Visible = false;
            lbltotaldokter.Visible = false;
            lbltotalobat.Visible = false;
            panel_c.Visible = true;
            //panel_Control.Visible = false;
            panel_c.Controls.Clear();
        }

        private void pegawai_Click(object sender, EventArgs e)
        {
            load1();
            
            FORM_MASTER_PEGAWAI pgw = new FORM_MASTER_PEGAWAI();
            pgw.TopLevel = false;
            panel_c.Controls.Add(pgw);
            pgw.Show();

            active1.Visible = false;
            active2.Visible = true;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;

        }

        private void lbltotalpegawai_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            load1();

            FORM_MASTER_DOKTER dktr = new FORM_MASTER_DOKTER();
            dktr.TopLevel = false;
            panel_c.Controls.Add(dktr);
            dktr.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = true;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout dari Aplikasi Ini?", "Pertanyaan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FORM_LOGIN login = new FORM_LOGIN();
                login.Show(); 
                this.Hide();
            }
        }

        private void lbljam_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel_info_Paint(object sender, PaintEventArgs e)
        {
            //panel_info.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            gradient_dash.Visible = true;
            shape1.Visible = true;
            shape2.Visible = true;
            shape3.Visible = true;
            shape4.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            dokter.Visible = true;
            pegawe.Visible = true;
            obat.Visible = true;
            pasien.Visible = true;
            btndokter.Visible = true;
            btnpegawai.Visible = true;
            btnpasien.Visible = true;
            btnobat.Visible = true;
            lbltotalpegawai.Visible = true;
            lbltotalpasien.Visible = true;
            lbltotaldokter.Visible = true;
            lbltotalobat.Visible = true;
            panel_c.Visible = false;

            active1.Visible = true;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout dari Aplikasi Ini?", "Pertanyaan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FORM_LOGIN login = new FORM_LOGIN();
                login.Show();
                this.Hide();
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void shape2_Click(object sender, EventArgs e)
        {

        }

        private void gradient_dash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bars_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 50)
            {
                //SideBar.Visible = false;
                SideBar.Width = 260;
            }
            else
            {
                //SideBar.Visible = false;
                SideBar.Width = 50;
            }
        }

        private void btn_pasien_Click(object sender, EventArgs e)
        {
            load1();

            FORM_MASTER_PASIEN psn = new FORM_MASTER_PASIEN();
            psn.TopLevel = false;
            panel_c.Controls.Add(psn);
            psn.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = true;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;

        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            load1();
            FORM_PENDAFTARAN dftr = new FORM_PENDAFTARAN();
            dftr.TopLevel = false;
            panel_c.Controls.Add(dftr);
            dftr.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = true;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = false;
        }

        private void btn_obat_Click(object sender, EventArgs e)
        {
            load1();
            FORM_MASTER_OBAT obt = new FORM_MASTER_OBAT();
            obt.TopLevel = false;
            panel_c.Controls.Add(obt);
            obt.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = true;
            active7.Visible = false;
            active8.Visible = false;
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            load1();
            FORM_LAPORAN lpr = new FORM_LAPORAN();
            lpr.TopLevel = false;
            panel_c.Controls.Add(lpr);
            lpr.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = true;
            active8.Visible = false;
        }

        private void panel_c_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            load1();
            FORM_SETTINGS stg = new FORM_SETTINGS();
            stg.TopLevel = false;
            panel_c.Controls.Add(stg);
            stg.Show();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
            active6.Visible = false;
            active7.Visible = false;
            active8.Visible = true;
        }

    }
}
