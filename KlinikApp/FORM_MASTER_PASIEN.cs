using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KlinikApp
{
    public partial class FORM_MASTER_PASIEN : Form
    {
        MysqlComponent mycom = new MysqlComponent();
        MySqlConnection con = new MySqlConnection();
        String status_proses;
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
        public FORM_MASTER_PASIEN()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
            
        private void locked1()
        {
            gform.Enabled = false;
            btncancel.Enabled = true;
            btndelete.Enabled = true;
            btninsert.Enabled = true;
            btnupdate.Enabled = true;
        }

        private void Bersih()
        {
            txt_noktp.Clear();
            txt_nama.Clear();
            cbopaket.Text = "";
            //dtmtgldaftar = null;
            txtalamat.Clear();
            txtkota.Clear();
            txtnotelp.Clear();
            cbojk.Text = "";
        }

        private void locked2()
        {
            gform.Enabled = true;
            btncancel.Enabled = true;
            btndelete.Enabled = false;
            btninsert.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void locked3()
        {
            btnsave.Enabled = false;
            btncancel.Enabled = false;
            //btnlaporan.Enabled = false;
        }

        private void isi_jk()
        {
            cbojk.Items.Clear();
            cbojk.Items.Add("Male");
            cbojk.Items.Add("Female");
        }

        private void tampil_data()
        {
            if (dgvmasterpasien.Rows.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                int idx = dgvmasterpasien.CurrentRow.Index;
                txt_noktp.Text = dgvmasterpasien.Rows[idx].Cells["no_ktp"].Value.ToString();
                txt_nama.Text = dgvmasterpasien.Rows[idx].Cells["nama_pasien"].Value.ToString();
                cbopaket.Text = dgvmasterpasien.Rows[idx].Cells["paket"].Value.ToString();
                //cbodokter.Text = dgvmasterpasien.Rows[idx].Cells["nama_dokter"].Value.ToString();
                txtalamat.Text = dgvmasterpasien.Rows[idx].Cells["alamat"].Value.ToString();
                txtkota.Text = dgvmasterpasien.Rows[idx].Cells["kota"].Value.ToString();
                txtnotelp.Text = dgvmasterpasien.Rows[idx].Cells["no_telp"].Value.ToString();
                //txtumur.Text = dgvmasterpasien.Rows[idx].Cells["umur"].Value.ToString();
                cbojk.Text = dgvmasterpasien.Rows[idx].Cells["j_kelamin"].Value.ToString();
            }
        }

        private void refresh_data()
        {
            //dgvmasterpasien.DataSource = mycom.getsql("SELECT no_ktp, nama_pasien, paket, alamat, kota, no_telp, umur, j_kelamin FROM t_pasien");
            dgvmasterpasien.DataSource = mycom.getsql("SELECT * FROM t_pasien ORDER BY no_ktp ASC");
        }

        private void antrian()
        {
            //txtantrian.Text = mycom.no_antrian();
        }

        

        private void FORM_MASTER_PASIEN_Load(object sender, EventArgs e)
        {
            refresh_data();
            tampil_data();
            locked1();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvmasterpasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            dgvmasterpasien.DataSource = mycom.getsql("SELECT * FROM t_pasien WHERE nama_pasien LIKE '%" + txtcari.Text + "%' OR no_ktp LIKE '%" + txtcari.Text + "%'");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Bersih();
            locked1();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); ;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            locked2();
            status_proses = "Ubah";
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            antrian();
            Bersih();
            txt_noktp.Focus();
            locked2();
            status_proses = "Tambah";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            if (status_proses == "Tambah")
            {
                berhasil = mycom.setsql("CALL input_pasien ('" + txt_noktp.Text + "', '" + txt_nama.Text + "', '" + cbopaket.Text + "', '" + txtalamat.Text + "' , '" + txtkota.Text + "', '" + txtnotelp.Text + "', '" + cbojk.Text + "')");
                //berhasil = mycom.setsql("INSERT INTO t_pasien VALUES ('" + txt_noktp.Text + "', '" + txt_nama.Text + "', '" + cbopaket.Text + "', '" + txtalamat.Text + "' , '" + txtkota.Text + "', '" + txtnotelp.Text + "', '" + cbojk.Text + "')");
            }
            else
            {
                berhasil = mycom.setsql("UPDATE t_pasien SET nama_pasien = '" + txt_nama.Text + "', paket = '" + cbopaket.Text + "', alamat = '" + txtalamat.Text + "', kota = '" + txtkota.Text + "', no_telp = '" + txtnotelp.Text + "', j_kelamin = '" + cbojk.Text + "' WHERE no_ktp = '" + txt_noktp.Text + "'");
            }
            if (berhasil)
            {
                mycom.Pesan("Data Berhasil Disimpan!");
                refresh_data();
            }
            else
            {
                mycom.Pesan("Data Gagal Disimpan!");
            }
            locked1();
        }

        private void dgvmasterpasien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tampil_data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                mycom.setsql("DELETE FROM t_pasien WHERE no_ktp = '" + txt_noktp.Text + "'");
                refresh_data();
                tampil_data();
            }
        }

        private void cbodokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void gform_Enter(object sender, EventArgs e)
        {

        }

        private void dgvdokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvdokter_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Pasien";
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvmasterpasien);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            Bersih();
            locked1();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            if (status_proses == "Tambah")
            {
                berhasil = mycom.setsql("CALL input_pasien ('" + txt_noktp.Text + "', '" + txt_nama.Text + "', '" + cbopaket.Text + "', '" + txtalamat.Text + "' , '" + txtkota.Text + "', '" + txtnotelp.Text + "', '" + cbojk.Text + "')");
                //berhasil = mycom.setsql("INSERT INTO t_pasien VALUES ('" + txt_noktp.Text + "', '" + txt_nama.Text + "', '" + cbopaket.Text + "', '" + txtalamat.Text + "' , '" + txtkota.Text + "', '" + txtnotelp.Text + "', '" + cbojk.Text + "')");
            }
            else
            {
                berhasil = mycom.setsql("UPDATE t_pasien SET nama_pasien = '" + txt_nama.Text + "', paket = '" + cbopaket.Text + "', alamat = '" + txtalamat.Text + "', kota = '" + txtkota.Text + "', no_telp = '" + txtnotelp.Text + "', j_kelamin = '" + cbojk.Text + "' WHERE no_ktp = '" + txt_noktp.Text + "'");
            }
            if (berhasil)
            {
                mycom.Pesan("Data Berhasil Disimpan!");
                refresh_data();
            }
            else
            {
                mycom.Pesan("Data Gagal Disimpan!");
            }
            locked1();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            antrian();
            Bersih();
            txt_noktp.Focus();
            locked2();
            status_proses = "Tambah";
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            locked2();
            status_proses = "Ubah";
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                mycom.setsql("DELETE FROM t_pasien WHERE no_ktp = '" + txt_noktp.Text + "'");
                refresh_data();
                tampil_data();
            }
        }

        private void btnlaporan_Click_1(object sender, EventArgs e)
        {

        }

    }
}
