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
    public partial class FORM_CARI_OBAT : Form
    {
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
        MysqlComponent m = new MysqlComponent();
        //DataTable dtobat;
        public FORM_CARI_OBAT()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            int idx = dgvobat.CurrentRow.Index;
            if (GV.LoadForm == "CARI OBAT")
            {
                GV.ObatID = dgvobat.Rows[idx].Cells["id_obat"].Value.ToString();
                GV.NamaObat = txtnamaobat.Text;
                GV.HargaObat = dgvobat.Rows[idx].Cells["harga"].Value.ToString();
                GV.StockObat = dgvobat.Rows[idx].Cells["stock"].Value.ToString();
                GV.QTYObat = txtqty.Text;
                GV.ResepObat = txtresep.Text;
            }
            this.Close();
        }

        private void tampil_data_obat()
        {
            dgvobat.DataSource = m.getsql("SELECT * FROM t_obat");
        }

        private void tampil_text_obat()
        { 
            int idx = dgvobat.CurrentRow.Index;
            txtnamaobat.Text = dgvobat.Rows[idx].Cells["nama_obat"].Value.ToString();
        }

        private void FORM_CARI_OBAT_Load(object sender, EventArgs e)
        {
            tampil_data_obat();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (txtnamaobat.Text == "" || txtresep.Text == "")
            {
                MessageBox.Show("Isi terlebih dahulu Data yang masih kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Close();
            }
        }

        private void dgvobat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampil_text_obat();
        }
    }
}
