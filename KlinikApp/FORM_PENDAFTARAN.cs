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
    public partial class FORM_PENDAFTARAN : Form
    {
        MysqlComponent mycom = new MysqlComponent();
        DataTable dtpasien;
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
        public FORM_PENDAFTARAN()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void tampil_data()
        {
            dgvdaftar.DataSource = mycom.getsql("SELECT * FROM t_pendaftaran");
        }

        private void no_antrian()
        {
            txtnoantri.Text = mycom.no_antrian_otomatis();
        }

        private void tgl_pendaftaran()
        {
            tgldaftar.Text = mycom.Tanggal_Pendaftaran();
        }


        private void FORM_PENDAFTARAN_Load(object sender, EventArgs e)
        {
            tampil_data();
            //antrian();
        }

        private void data_pasien(String cari)
        {
            dtpasien = new DataTable();
            dtpasien = mycom.getsql("SELECT nama_pasien, paket, alamat, no_telp, j_kelamin FROM t_pasien WHERE no_ktp = '" + cari + "'");
            txtnama.Text = dtpasien.Rows[0]["nama_pasien"].ToString();
            txtno.Text = dtpasien.Rows[0]["no_telp"].ToString();
            txtjk.Text = dtpasien.Rows[0]["j_kelamin"].ToString();
        }
  
        private void dgvpendaftaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Clean()
        {
            txtktp.Clear();
            txtnama.Clear();
            txtno.Clear();
            txtjk.Clear();
            txtnoantri.Clear();
            txtcarinamapasien.Clear();
            txtriwayat.Clear();
            tgldaftar.Clear();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            //DataTable Pasien
            dtpasien = new DataTable();
            dtpasien = mycom.getsql("SELECT nama_pasien, paket, alamat, no_telp, j_kelamin FROM t_pasien WHERE no_ktp = '" + txtktp.Text + "'");

            //DataTable Pendaftaran
            DataTable dtdaftar = new DataTable();
            dtdaftar = mycom.getsql("SELECT * FROM t_pendaftaran WHERE no_ktp = '" + txtktp.Text + "'");

            //DataTable Pendaftaran 2
            DataTable dtdaftar2 = new DataTable();
            dtdaftar2 = mycom.getsql("SELECT * FROM t_pendaftaran");
            if (txtktp.Text == "")
            {
                MessageBox.Show("Mohon Isi No KTP Pasien Untuk Pendaftaran Pasien!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpasien.Rows.Count == 0)
            {
                MessageBox.Show("Mohon Maaf! Data Pasien Tidak Ada! Silahkan Input Data Pasien Terlebih Dahulu!", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (dtdaftar.Rows.Count != 0)
            {
                MessageBox.Show("Mohon Maaf! No KTP Pasien Ini Sudah Mendaftar Untuk Berobat! Dan Sudah Masuk No Antrian!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtktp.Text, "[^0-9]"))
            {
                MessageBox.Show("Error! Masukkan Nomor E-KTP Yang Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtktp.Text = "";
            }
            else if (txtktp.Enabled == false)
            {
                MessageBox.Show("JANGAN KLIK AKU AH");
            }
            else
            {
                data_pasien(txtktp.Text);
                //no_antrian();
                tgl_pendaftaran();
                txtktp.Enabled = false;
            }
        }

        private void btncaridokter_Click_1(object sender, EventArgs e)
        {
          
        }

        private void refresh_data()
        {
            dgvdaftar.DataSource = mycom.getsql("SELECT * FROM t_pendaftaran");
            txtktp.Clear();
            txtnama.Clear();
            txtno.Clear();
            txtjk.Clear();
            txtnoantri.Clear();
            txtcarinamapasien.Clear();
            txtriwayat.Clear();
            tgldaftar.Clear();
            txtktp.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Keluar Dari Pendaftaran Pasien Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtktp.Text == "")
            {
                MessageBox.Show("Mohon Isi No KTP Pasien Untuk Pendaftaran Pasien!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if  (txtnama.Text == "" || txtno.Text == "" || txtjk.Text == "")
            {
                MessageBox.Show("Mohon Isi Data Yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean berhasil = true;
                string status = "Tambah";
                if (status == "Tambah")
                {
                    berhasil = mycom.setsql("INSERT INTO t_pendaftaran VALUES ('" + txtktp.Text + "' ,'" + txtnama.Text + "', '" + tgldaftar.Text + "', '" + txtnoantri.Text + "',  '" + txtno.Text + "', '" + txtjk.Text + "')");
                }
                if (berhasil)
                {
                    mycom.Pesan("Data Berhasil Disimpan!");
                    refresh_data();
                }
            }

        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtktp.Text == "")
            {
                MessageBox.Show("Mohon Isi No KTP Pasien Untuk Pendaftaran Pasien!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnama.Text == "" || txtno.Text == "" || txtjk.Text == "")
            {
                MessageBox.Show("Mohon Isi Data Yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "PENDAFTARAN PASIEN";
                printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Klinik Gigi Asy - Syifa";
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvdaftar);
            }
        }

        private void txtcarinamapasien_TextChanged(object sender, EventArgs e)
        {
            dgvdaftar.DataSource = mycom.getsql("SELECT * FROM t_pendaftaran WHERE no_ktp LIKE '%" + txtcarinamapasien.Text + "%' OR nama_pasien LIKE '%" + txtcarinamapasien.Text + "%'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtktp.Text == "")
            {
                MessageBox.Show("Mohon Isi No KTP Pasien Untuk Pendaftaran Pasien!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnama.Text == "" || txtno.Text == "" || txtjk.Text == "" || txtriwayat.Text == "" || txtnoantri.Text == "")
            {
                MessageBox.Show("Mohon Isi Data Yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean berhasil = true;
                string status = "Tambah";
                if (status == "Tambah")
                {
                    berhasil = mycom.setsql("INSERT INTO t_pendaftaran VALUES ('" + txtktp.Text + "' ,'" + txtnama.Text + "' ,'" + txtriwayat.Text + "' , '" + tgldaftar.Text + "', '" + txtnoantri.Text + "',  '" + txtno.Text + "', '" + txtjk.Text + "')");
                }
                if (berhasil)
                {
                    mycom.Pesan("Data Berhasil Disimpan!");
                    refresh_data();
                }
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            Clean();
            txtktp.Enabled = true;
        }

        private void otomatis_CheckedChanged(object sender, EventArgs e)
        {
            if (otomatis.Text == "OTOMATIS")
            {
                txtnoantri.Text = mycom.no_antrian_otomatis();
                txtnoantri.Enabled = false;
            }
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {
            txtnoantri.Enabled = true;
            txtnoantri.Text = "";
        }

    }
}
