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
    public partial class FORM_MASTER_OBAT : Form
    {
        MysqlComponent m = new MysqlComponent();
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
        public FORM_MASTER_OBAT()
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

        private void locked2()
        {
            gform.Enabled = true;
            btncancel.Enabled = true;
            btndelete.Enabled = false;
            btninsert.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void Bersih()
        {
            txtid.Clear();
            txtnama.Clear();
            txtharga.Clear();
            txtstock.Clear();
        }

        private void refresh_data()
        {
            dgvmasterobat.DataSource = m.getsql("SELECT * FROM t_obat");
        }

        private void tampil_data_obat()
        {
            int idx = dgvmasterobat.CurrentRow.Index;
            txtid.Text = dgvmasterobat.Rows[idx].Cells["id_obat"].Value.ToString();
            txtnama.Text = dgvmasterobat.Rows[idx].Cells["nama_obat"].Value.ToString();
            txtharga.Text = dgvmasterobat.Rows[idx].Cells["harga"].Value.ToString();
            txtstock.Text = dgvmasterobat.Rows[idx].Cells["stock"].Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dgvmasterobat.DataSource = m.getsql("SELECT * FROM t_obat WHERE id_obat LIKE '%" + txt_cari.Text + "%' OR nama_obat LIKE '%" + txt_cari.Text + "%' OR harga LIKE '%" + txt_cari.Text + "%' OR stock LIKE '%" + txt_cari.Text + "%'");
        }

        private void FORM_MASTER_OBAT_Load(object sender, EventArgs e)
        {
            refresh_data();
            tampil_data_obat();
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
                Application.Exit();
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
                berhasil = m.setsql("INSERT INTO t_obat VALUES ('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtharga.Text + "' , '" + txtstock.Text + "')");
            }
            else
            {
                berhasil = m.setsql("UPDATE t_obat SET nama_obat = '" + txtnama.Text + "', harga = '" + txtharga.Text + "', stock = '" + txtstock.Text + "' WHERE id_obat = '" + txtid.Text + "'");
            }
            if (berhasil)
            {
                m.Pesan("Data Berhasil Disimpan!");
                refresh_data();
            }
            else
            {
                m.Pesan("Data Gagal Disimpan!");
            }
            locked1();
        }

        private void dgvmasterobat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampil_data_obat();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                m.setsql("DELETE FROM t_obat WHERE id_obat = '" + txtid.Text + "'");
                refresh_data();
                tampil_data_obat();
            }
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Jenis - Jenis Obat";
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvmasterobat);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN lgt = new FORM_LOGIN();
            lgt.Show();
            this.Hide();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Perhatian!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                m.setsql("DELETE FROM t_obat WHERE id_obat = '" + txtid.Text + "'");
                refresh_data();
                tampil_data_obat();
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            locked2();
            status_proses = "Ubah";
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            Bersih();
            txtid.Focus();
            locked2();
            status_proses = "Tambah";
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            Boolean berhasil = true;
            if (status_proses == "Tambah")
            {
                berhasil = m.setsql("INSERT INTO t_obat VALUES ('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtharga.Text + "' , '" + txtstock.Text + "')");
            }
            else
            {
                berhasil = m.setsql("UPDATE t_obat SET nama_obat = '" + txtnama.Text + "', harga = '" + txtharga.Text + "', stock = '" + txtstock.Text + "' WHERE id_obat = '" + txtid.Text + "'");
            }
            if (berhasil)
            {
                m.Pesan("Data Berhasil Disimpan!");
                refresh_data();
            }
            else
            {
                m.Pesan("Data Gagal Disimpan!");
            }
            locked1();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            Bersih();
            locked1();
        }

        private void otomatis_CheckedChanged(object sender, EventArgs e)
        {
            if (otomatis.Text == "OTOMATIS")
            {
                txtid.Text = m.IDObat();
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
