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
    public partial class FORM_LAPORAN : Form
    {
        MysqlComponent m = new MysqlComponent();
        public FORM_LAPORAN()
        {
            InitializeComponent();
        }

        private void FORM_LAPORAN_Load(object sender, EventArgs e)
        {

        }

        private void loadcari_Click(object sender, EventArgs e)
        {
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (cbo_laporan.Text == "LAPORAN DATA PASIEN")
            {
                dgvreport.DataSource = m.getsql("SELECT * FROM t_pasien");
                //lbllapor.Text = cbo_laporan.SelectedIndex("LAPORAN DATA PASIEN");
            }
            else if (cbo_laporan.Text == "LAPORAN DATA OBAT")
            {
                dgvreport.DataSource = m.getsql("SELECT * FROM t_obat");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            //ReportPreview.Document = ReportPrintDocument;
            //ReportPreview.ShowDialog();

            DGVPrinter printer = new DGVPrinter();
            printer.Title = cbo_laporan.Text;
            printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klinik Gigi Asy - Syifa";
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvreport);
        }

        private void ReportPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //DGVPrinter printer = new DGVPrinter();
            //printer.Title = cbo_laporan.Text;
            //printer.SubTitle = string.Format("Tanggal Hari Ini : {0}", DateTime.Now.Date.ToString("dd-MM-yyyy"));
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Klinik Gigi Asy - Syifa";
            //printer.FooterSpacing = 15;
            //printer.PrintDataGridView(dgvreport);

            Bitmap bmp = Properties.Resources.KopSurat4;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 0, 15, newImage.Width, newImage.Height);
            e.Graphics.DrawString(cbo_laporan.Text, new Font("Arial", 20, FontStyle.Bold),
            Brushes.Black, new Point(250, 240));

            e.Graphics.DrawString("No Antrian Pasien : " , new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(35, 320));

            e.Graphics.DrawString("No KTP Pasien       : " , new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(35, 340));

            e.Graphics.DrawString("Nama Pasien          : " , new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(35, 360));

            //Bitmap objBmp = new Bitmap(this.dgvreport.Width, this.dgvreport.Height);
            //dgvreport.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dgvreport.Width, this.dgvreport.Height));

            //e.Graphics.DrawImage(objBmp, 50, 400);

        }
    }
}
