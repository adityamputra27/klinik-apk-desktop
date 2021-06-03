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
    public partial class FORM_PEMERIKSAAN : Form
    {
        MysqlComponent mycom = new MysqlComponent();
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
        public FORM_PEMERIKSAAN()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void tampil_data()
        {
            //dgvperiksa.DataSource = mycom.getsql("SELECT * FROM t_pendaftaran WHERE tgl_daftar = '" + txttgldaftar.Text + "' AND nama_pasien LIKE '%" + txtnamapasien.Text + "%' ORDER BY no_antrian ASC");
        }

        private void FORM_PEMERIKSAAN_Load(object sender, EventArgs e)
        {
            //tampil_data();
            txttgldaftar.Format = DateTimePickerFormat.Custom;
            txttgldaftar.CustomFormat = "dd-MM-yyyy";
        }

        private void data_periksa(String cari)
        {
            DataTable dtperiksa = new DataTable();
            dtperiksa = mycom.getsql("SELECT nama_pasien, r_penyakit FROM t_pendaftaran WHERE tgl_daftar = '" + cari + "'");
            if (dtperiksa.Rows.Count != 0)
            {
                txtnamapasien.Text = dtperiksa.Rows[0]["nama_pasien"].ToString();
                txtriwayat.Text = dtperiksa.Rows[0]["r_penyakit"].ToString();
                tampil_data();
            }
            else
            {
                MessageBox.Show("Maaf Pasien Ini Belum Terdaftar! Silahkan Untuk Daftar Terlebih Dahulu!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttgldaftar.Text = "";
            }
            //txtdokter.Text = dtperiksa.Rows[0]["nama_dokter"].ToString();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            DataTable dtcek = new DataTable();
            dtcek = mycom.getsql("SELECT * FROM t_pendaftaran WHERE tgl_daftar = '" + txttgldaftar.Text + "' ORDER BY no_antrian DESC");
            //if (dtcek.Rows.Count != 0)
            //{
                //MessageBox.Show("Pasien Ini Sudah Diperiksa! Silahkan Masukkan No Antrian Pasien Yang Belum Diperiksa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            data_periksa(txttgldaftar.Text);
            //}
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {

        }

        private void refresh_data()
        {
            dgvperiksa.DataSource = mycom.getsql("SELECT * FROM t_pendaftaran WHERE tgl_daftar = '" + txttgldaftar.Text + "'");
            txttgldaftar.Enabled = true;
            txtdokter.Clear();
            txtnamapasien.Clear();
            txtkeluhan.Clear();
            txtdiagnosa.Clear();
            txtperawatan.Items.Clear();
            txttindakan.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            berhasil = mycom.setsql("INSERT INTO t_pemeriksaan VALUES ('" + txttgldaftar.Text + "', '" + txtnamapasien.Text + "', '" + txtkeluhan.Text + "', '" + txtdiagnosa.Text + "', '" + txttindakan.Text + "',  '" + txtperawatan.Text + "', '" + txtdokter.Text + "')");
            if (berhasil)
            {
                mycom.Pesan("Data Berhasil Disimpan!");
                refresh_data();
            }
            else
            {
                mycom.Pesan("Data Gagal Disimpan!");
            }
        }

        private void btnperiksa_Click(object sender, EventArgs e)
        {
            FORM_PEMERIKSAAN p = new FORM_PEMERIKSAAN();
            p.Show();
            this.Hide();
        }

        private void btnresep_Click(object sender, EventArgs e)
        {
            FORM_RESEP r = new FORM_RESEP();
            r.Show();
            this.Hide();
        }

        private void btncaridokter_Click(object sender, EventArgs e)
        {
            FORM_CARI_DOKTER dktr = new FORM_CARI_DOKTER();
            dktr.ShowDialog();
            GV.LoadForm = "CARI DOKTER";
            txtdokter.Text = GV.NamaDokter;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void dgvperiksa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txttgldaftar.Text == "" || txtdokter.Text == "" ||
                txtdiagnosa.Text == "" || txtkeluhan.Text == "" || txtperawatan.Text == ""
                || txttindakan.Text == "")
            {
                MessageBox.Show("Mohon Isi Data Yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean berhasil = true;
                berhasil = mycom.setsql("INSERT INTO t_pemeriksaan VALUES ('" + txttgldaftar.Text + "', '" + txtnamapasien.Text + "', '" + txtkeluhan.Text + "', '" + txtdiagnosa.Text + "', '" + txttindakan.Text + "',  '" + txtperawatan.Text + "', '" + txtdokter.Text + "')");
                if (berhasil)
                {
                    mycom.Pesan("Data Berhasil Disimpan!");
                    refresh_data();
                }
                else
                {
                    mycom.Pesan("Data Gagal Disimpan!");
                }
            }
        }
    }
}
