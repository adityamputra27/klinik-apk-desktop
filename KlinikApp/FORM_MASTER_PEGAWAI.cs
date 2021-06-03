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
    public partial class FORM_MASTER_PEGAWAI : Form
    {
        MysqlComponent mycom = new MysqlComponent();
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
        public FORM_MASTER_PEGAWAI()
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
            txtid.Clear();
            txtnama.Clear();
            txtalamat.Clear();
            txtkota.Clear();
            txtnotelp.Clear();
            txtumur.Clear();
            cbojk.Text = "";
            txtjabatan.Clear();
            txttarif.Clear();
        }

        private void locked2()
        {
            gform.Enabled = true;
            btncancel.Enabled = true;
            btndelete.Enabled = false;
            btninsert.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void isi_jk()
        {
            cbojk.Items.Clear();
            cbojk.Items.Add("Male");
            cbojk.Items.Add("Female");
        }

        private void tampil_data()
        {
            int idx = dgvmasterpegawai.CurrentRow.Index;
            txtid.Text = dgvmasterpegawai.Rows[idx].Cells["id_pegawai"].Value.ToString();
            txtnama.Text = dgvmasterpegawai.Rows[idx].Cells["nama"].Value.ToString();
            txtalamat.Text = dgvmasterpegawai.Rows[idx].Cells["alamat"].Value.ToString();
            txtkota.Text = dgvmasterpegawai.Rows[idx].Cells["kota"].Value.ToString();
            txtnotelp.Text = dgvmasterpegawai.Rows[idx].Cells["no_telp"].Value.ToString();
            txtumur.Text = dgvmasterpegawai.Rows[idx].Cells["umur"].Value.ToString();
            cbojk.Text = dgvmasterpegawai.Rows[idx].Cells["j_kelamin"].Value.ToString();
            txtjabatan.Text = dgvmasterpegawai.Rows[idx].Cells["jabatan"].Value.ToString();
            txttarif.Text = dgvmasterpegawai.Rows[idx].Cells["tarif_pegawai"].Value.ToString();
        }

        private void refresh_data()
        {
            dgvmasterpegawai.DataSource = mycom.getsql("SELECT * FROM t_pegawai");
        }

        private void FORM_MASTER_PEGAWAI_Load(object sender, EventArgs e)
        {
            isi_jk();
            refresh_data();
            tampil_data();
            locked1();
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
            Bersih();
            txtid.Focus();
            locked2();
            status_proses = "Tambah";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            if (status_proses == "Tambah")
            {
                berhasil = mycom.setsql("INSERT INTO t_pegawai VALUES ('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtalamat.Text + "', '" + txtkota.Text + "', '" + txtnotelp.Text + "', '" + txtumur.Text + "', '" + cbojk.Text + "', '" + txtjabatan.Text + "' , '" + txttarif.Text + "')");
            }
            else
            {
                berhasil = mycom.setsql("UPDATE t_pegawai SET nama = '" + txtnama.Text + "', alamat = '" + txtalamat.Text + "', kota = '" + txtkota.Text + "', no_telp = '" + txtnotelp.Text + "', umur = '" + txtumur.Text + "', j_kelamin = '" + cbojk.Text + "', jabatan = '" + txtjabatan.Text + "' , tarif_pegawai = '" + txttarif.Text + "' WHERE id_pegawai = '" + txtid.Text + "'");
            }
            if (berhasil)
            {
                mycom.Pesan("Data Berhasil Disimpan!");
                refresh_data();
                Bersih();
            }
            else
            {
                mycom.Pesan("Data Gagal Disimpan!");
            }
            locked1();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                mycom.setsql("DELETE FROM t_pegawai WHERE id_pegawai = '" + txtid.Text + "'");
                refresh_data();
                tampil_data();
            }
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            dgvmasterpegawai.DataSource = mycom.getsql("SELECT * FROM t_pegawai WHERE nama LIKE '%" + txtcari.Text + "%' OR jabatan LIKE '%" + txtcari.Text + "%' OR tarif_pegawai LIKE '%" + txtcari.Text + "%'");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Data Pegawai";
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvmasterpegawai);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN login = new FORM_LOGIN();
            login.Show();
            this.Hide();
        }

        private void dgvmasterpegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvmasterpegawai.CurrentRow.Index;
            txtid.Text = dgvmasterpegawai.Rows[idx].Cells["id_pegawai"].Value.ToString();
            txtnama.Text = dgvmasterpegawai.Rows[idx].Cells["nama"].Value.ToString();
            txtalamat.Text = dgvmasterpegawai.Rows[idx].Cells["alamat"].Value.ToString();
            txtkota.Text = dgvmasterpegawai.Rows[idx].Cells["kota"].Value.ToString();
            txtnotelp.Text = dgvmasterpegawai.Rows[idx].Cells["no_telp"].Value.ToString();
            txtumur.Text = dgvmasterpegawai.Rows[idx].Cells["umur"].Value.ToString();
            cbojk.Text = dgvmasterpegawai.Rows[idx].Cells["j_kelamin"].Value.ToString();
            txtjabatan.Text = dgvmasterpegawai.Rows[idx].Cells["jabatan"].Value.ToString();
            txttarif.Text = dgvmasterpegawai.Rows[idx].Cells["tarif_pegawai"].Value.ToString();
        }

        private void otomatis_CheckedChanged(object sender, EventArgs e)
        {
            if (otomatis.Text == "OTOMATIS")
            {
                txtid.Text = mycom.IDPegawai();
                txtid.Enabled = false;
            }
            //manual.Enabled = false;
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtid.Text = "";
        }
    }
}
