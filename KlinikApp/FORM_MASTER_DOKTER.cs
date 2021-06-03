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
    public partial class FORM_MASTER_DOKTER : Form
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

        public FORM_MASTER_DOKTER()
        {
            //lbladmin.Text = "Welcome" + admin;
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
            txtspesialis.Clear();
            txtalamat.Clear();
            txtkota.Clear();
            txtno_telp.Clear();
            txtumur.Clear();
            cbo_jk.Text = "";
            txt_tarif.Clear();
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
        }

        private void isi_jk()
        {
            cbo_jk.Items.Clear();
            cbo_jk.Items.Add("Male");
            cbo_jk.Items.Add("Female");
        }

        private void refresh_data()
        {
            dgvmasterdokter.DataSource = mycom.getsql("SELECT * FROM t_dokter");
        }

        private void tampil_data()
        {
            int idx = dgvmasterdokter.CurrentRow.Index;
            txtid.Text = dgvmasterdokter.Rows[idx].Cells["id_dokter"].Value.ToString();
            txtnama.Text = dgvmasterdokter.Rows[idx].Cells["nama_dokter"].Value.ToString();
            txtspesialis.Text = dgvmasterdokter.Rows[idx].Cells["spesialis"].Value.ToString();
            txtalamat.Text = dgvmasterdokter.Rows[idx].Cells["alamat"].Value.ToString();
            txtkota.Text = dgvmasterdokter.Rows[idx].Cells["kota"].Value.ToString();
            txtno_telp.Text = dgvmasterdokter.Rows[idx].Cells["no_telp"].Value.ToString();
            txtumur.Text = dgvmasterdokter.Rows[idx].Cells["umur"].Value.ToString();
            cbo_jk.Text = dgvmasterdokter.Rows[idx].Cells["j_kelamin"].Value.ToString();
            txt_tarif.Text = dgvmasterdokter.Rows[idx].Cells["tarif_dokter"].Value.ToString();
        }

        private void FORM_MASTER_DOKTER_Load(object sender, EventArgs e)
        {
            isi_jk();
            refresh_data();
            tampil_data();
            locked1();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tampil_data();
            Bersih();
            locked1();
        }

        private void button4_Click(object sender, EventArgs e)
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
                berhasil = mycom.setsql("INSERT INTO t_dokter VALUES ('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtspesialis.Text + "' , '" + txtalamat.Text + "', '" + txtkota.Text + "', '" + txtno_telp.Text + "', '" + txtumur.Text + "', '" + cbo_jk.Text + "', '" + txt_tarif.Text + "')");
            }
            else
            {
                berhasil = mycom.setsql("UPDATE t_dokter SET nama_dokter = '" + txtnama.Text + "', spesialis = '" + txtspesialis.Text + "' , alamat = '" + txtalamat.Text + "', kota = '" + txtkota.Text + "', no_telp = '" + txtno_telp.Text + "', umur = '" + txtumur.Text + "', j_kelamin = '" + cbo_jk.Text + "', tarif_dokter = '" + txt_tarif.Text + "' WHERE id_dokter = '" + txtid.Text + "'");
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

        private void dgvmasterdokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvmasterdokter_MouseClick(object sender, MouseEventArgs e)
        {
            tampil_data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                mycom.setsql("DELETE FROM t_dokter WHERE id_dokter = '" + txtid.Text + "'");
                refresh_data();
                tampil_data();
            }
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            dgvmasterdokter.DataSource = mycom.getsql("SELECT * FROM t_dokter WHERE nama_dokter LIKE '%" + txt_cari.Text + "%' or spesialis LIKE '%" + txt_cari.Text + "%' or tarif_dokter LIKE '%" + txt_cari.Text + "%'");
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Daftar Dokter";
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvmasterdokter);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            Bersih();
            txtid.Focus();
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
                mycom.setsql("DELETE FROM t_dokter WHERE id_dokter = '" + txtid.Text + "'");
                refresh_data();
                tampil_data();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            if (status_proses == "Tambah")
            {
                berhasil = mycom.setsql("INSERT INTO t_dokter VALUES ('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtspesialis.Text + "' , '" + txtalamat.Text + "', '" + txtkota.Text + "', '" + txtno_telp.Text + "', '" + txtumur.Text + "', '" + cbo_jk.Text + "', '" + txt_tarif.Text + "')");
            }
            else
            {
                berhasil = mycom.setsql("UPDATE t_dokter SET nama_dokter = '" + txtnama.Text + "', spesialis = '" + txtspesialis.Text + "' , alamat = '" + txtalamat.Text + "', kota = '" + txtkota.Text + "', no_telp = '" + txtno_telp.Text + "', umur = '" + txtumur.Text + "', j_kelamin = '" + cbo_jk.Text + "', tarif_dokter = '" + txt_tarif.Text + "' WHERE id_dokter = '" + txtid.Text + "'");
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            Bersih();
            locked1();
        }

        private void btnlaporan_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Daftar Dokter";
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvmasterdokter);
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {

        }

        private void otomatis_CheckedChanged(object sender, EventArgs e)
        {
            if (otomatis.Text == "OTOMATIS")
            {
                txtid.Text = mycom.IDDokter();
                txtid.Enabled = false;
            }
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtid.Text = "";
        }
    }
}
