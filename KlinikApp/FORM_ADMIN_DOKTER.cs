using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikApp
{
    public partial class FORM_ADMIN_DOKTER : Form
    {
        Timer t = new Timer();
        MysqlComponent mycom = new MysqlComponent();
        public FORM_ADMIN_DOKTER(String admin)
        {
            InitializeComponent();
            lblwelkome2.Text = "" + admin;
        }

        private void load1()
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;

            lblbelumperiksa.Visible = false;
            lbltelahperiksa.Visible = false;
            lbldiagnosis.Visible = false;

            belum_periksa.Visible = false;
            telah_periksa.Visible = false;
            diagnosis_pic.Visible = false;

            gradient_dash.Visible = true;
            shape1.Visible = true;
            shape2.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;
            panel_c.Visible = true;
            panel_c.Controls.Clear();
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

        private void PasienBelumPeriksa()
        {
            DataTable dtblm = new DataTable();
            dtblm = mycom.getsql("SELECT COUNT(nama_pasien) AS BelumPeriksa FROM t_pendaftaran");
            lblbelumperiksa.Text = dtblm.Rows[0]["BelumPeriksa"].ToString();
        }

        private void PasienSudahPeriksa()
        {
            DataTable dtsdh = new DataTable();
            dtsdh = mycom.getsql("SELECT COUNT(nama_pasien) AS SudahPeriksa FROM tb_simpan");
            lbltelahperiksa.Text = dtsdh.Rows[0]["SudahPeriksa"].ToString();
        }

        private void Diagnosis()
        {
            DataTable dtdiag = new DataTable();
            dtdiag = mycom.getsql("SELECT COUNT(diagnosa) AS Diagnosis FROM tb_simpan");
            lbldiagnosis.Text = dtdiag.Rows[0]["Diagnosis"].ToString();
        }

        private void FORM_ADMIN_DOKTER_Load(object sender, EventArgs e)
        {
            panel_c.Visible = false;

            active1.Visible = true;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;

            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            PasienBelumPeriksa();
            PasienSudahPeriksa();
            Diagnosis();
        }

        private void btnresep_Click(object sender, EventArgs e)
        {
            FORM_RESEP r = new FORM_RESEP();
            r.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void shape2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnperiksa_Click(object sender, EventArgs e)
        {
            load1();

            active1.Visible = false;
            active2.Visible = true;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;

            FORM_PEMERIKSAAN p = new FORM_PEMERIKSAAN();
            p.TopLevel = false;
            panel_c.Controls.Add(p);
            p.Show();
        }

        private void btn_resep_Click(object sender, EventArgs e)
        {
            load1();

            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = true;
            active4.Visible = false;
            active5.Visible = false;

            FORM_RESEP r = new FORM_RESEP();
            r.TopLevel = false;
            panel_c.Controls.Add(r);
            r.Show();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            active1.Visible = false;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = true;
            active5.Visible = false;

            //FORM_LAPORAN_DOKTER p = new FORM_LAPORAN_DOKTER();
            //p.TopLevel = false;
            //panel_c.Controls.Add(p);
            //p.Show();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;

            lblbelumperiksa.Visible = true;
            lbltelahperiksa.Visible = true;
            lbldiagnosis.Visible = true;

            belum_periksa.Visible = true;
            telah_periksa.Visible = true;
            diagnosis_pic.Visible = true;

            gradient_dash.Visible = true;
            shape1.Visible = true;
            shape2.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;
            panel_c.Visible = false;

            active1.Visible = true;
            active2.Visible = false;
            active3.Visible = false;
            active4.Visible = false;
            active5.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout dari Aplikasi Ini?", "Pertanyaan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FORM_LOGIN login = new FORM_LOGIN();
                login.Show();
                this.Hide();
            }
        }
    }
}
