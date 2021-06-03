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
    public partial class FORM_CARI_DOKTER : Form
    {
        MysqlComponent mycom = new MysqlComponent();
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
        public FORM_CARI_DOKTER()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void tampil_data()
        {
            dgvdokter.DataSource = mycom.getsql("SELECT * FROM t_dokter");
        }

        private void FORM_CARI_DOKTER_Load(object sender, EventArgs e)
        {
            tampil_data();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            int idx = dgvdokter.CurrentRow.Index;

            if (GV.LoadForm == "CARI DOKTER")
            {
                GV.NamaDokter = dgvdokter.Rows[idx].Cells["nama_dokter"].Value.ToString();
                //GV.Spesialis = dgvdokter.Rows[idx].Cells["spesialis"].Value.ToString();
                //GV.Tarif_Dokter = dgvdokter.Rows[idx].Cells["tarif_dokter"].Value.ToString();
            }
            this.Close();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            dgvdokter.DataSource = mycom.getsql("SELECT * FROM t_dokter WHERE nama_dokter LIKE '%" + txtcari.Text + "%' OR spesialis LIKE '%" + txtcari.Text + "%'");

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
