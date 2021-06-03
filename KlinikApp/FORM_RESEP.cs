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
    public partial class FORM_RESEP : Form
    {
        Timer t = new Timer();
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
        public FORM_RESEP()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void FORM_RESEP_Load(object sender, EventArgs e)
        {
            add_kolom();
            txttgldaftar.Format = DateTimePickerFormat.Custom;
            txttgldaftar.CustomFormat = "dd-MM-yyyy";
        }

        private void add_kolom()
        {
            dgvobat.Columns.Add("ObatID", "ObatID");
            dgvobat.Columns.Add("Nama Obat", "Nama Obat");
            dgvobat.Columns.Add("Harga Obat", "Harga Obat");
            dgvobat.Columns.Add("QTY Obat", "QTY Obat");
            dgvobat.Columns.Add("Resep Obat", "Resep Obat");
        }

        private void txtperawatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tampil_data_periksa(String cari)
        {
            DataTable dtresep = new DataTable();
            dtresep = mycom.getsql("SELECT a.no_ktp, d.paket, b.nama_pasien, b.nama_dokter, b.keluhan, " 
            + " b.diagnosa, b.tindakan, b.perawatan FROM t_pendaftaran a INNER JOIN " 
            + " t_pemeriksaan b ON a.nama_pasien = b.nama_pasien INNER JOIN t_pasien d ON a.no_ktp = d.no_ktp "
            + "INNER JOIN t_dokter c ON b.nama_dokter = c.nama_dokter WHERE a.tgl_daftar = '" + cari + "'");
            txtdokter.Text = GV.NamaDokter;
            if (dtresep.Rows.Count == 0)
            {
                MessageBox.Show("Mohon Maaf Pasien Ini Belum Diperiksa Oleh Dokter! Silahkan Periksa Terlebih Dahulu", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                txtnoktp.Text = dtresep.Rows[0]["no_ktp"].ToString();
                txtdokter.Text = dtresep.Rows[0]["nama_dokter"].ToString();
                txtnamapasien.Text = dtresep.Rows[0]["nama_pasien"].ToString();
                txtpaket.Text = dtresep.Rows[0]["paket"].ToString();
                txtdiagnosa.Text = dtresep.Rows[0]["diagnosa"].ToString();
                txttindakan.Text = dtresep.Rows[0]["tindakan"].ToString();
                txtperawatan.Text = dtresep.Rows[0]["perawatan"].ToString();
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            DataTable dtresep = new DataTable();
            dtresep = mycom.getsql("SELECT * FROM t_resep WHERE tgl_daftar = '" + txttgldaftar.Text + "'");

            if (txttgldaftar.Text == "")
            {
                MessageBox.Show("Masukkan Tanggal Pendaftaran Pasien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtresep.Rows.Count != 0)
            {
                MessageBox.Show("Pasien Ini Sudah Diberi Resep!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tampil_data_periksa(txttgldaftar.Text);
            }
        }

        private void btncariobat_Click(object sender, EventArgs e)
        {
            if (txttgldaftar.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Tanggal Pendaftaran Pasien!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GV.LoadForm = "CARI OBAT";
                FORM_CARI_OBAT frm_cari_obat = new FORM_CARI_OBAT();
                frm_cari_obat.ShowDialog();

                //dgvobat.Rows.Add(GV.ObatID, GV.NamaObat, GV.HargaObat, GV.QTYObat, GV.HargaObat);
                if (GV.ObatID != "")
                {
                    Boolean ketemu = false;
                    int x = 0;
                    int QTY = 0;
                    QTY = int.Parse(GV.QTYObat);
                    for (x = 0; x <= dgvobat.Rows.Count - 1; x++)
                    {
                        if (dgvobat.Rows[x].Cells["ObatID"].Value.ToString() == GV.ObatID)
                        {
                            ketemu = true;
                            break;
                        }
                    }
                    //double TotalHarga;
                    if (ketemu)
                    {
                        QTY = int.Parse(dgvobat.Rows[x].Cells["QTY Obat"].Value.ToString()) + QTY;
                        dgvobat.Rows[x].Cells["QTY Obat"].Value = Double.Parse(GV.QTYObat);
                        dgvobat.Rows[x].Cells[5].Value = Double.Parse(GV.HargaObat) * QTY;
                        //dgvobat.Rows[x].Cells["Harga Obat"].Value = Double.Parse(GV.HargaObat);
                        //dgvobat.Rows[x].Cells["QTY Obat"].Value = Double.Parse(GV.QTYObat);
                        //TotalHarga = Double.Parse(GV.HargaObat) * Double.Parse(GV.QTYObat);
                        //dgvobat.Rows[x].Cells["Total Harga"].Value = TotalHarga.ToString();
                    }
                    else
                    {
                        dgvobat.Rows.Add(GV.ObatID, GV.NamaObat, GV.HargaObat, GV.QTYObat,GV.ResepObat);
                    }
                    gettotal();
                }
            }
        }

        private void gettotal()
        {
            double total = 0;
            for (int x = 0; x <= dgvobat.Rows.Count - 1; x++)
            {
                total = total + double.Parse(dgvobat.Rows[x].Cells["Total Harga"].Value.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txttgldaftar.Text == "")
            {
                MessageBox.Show("Mohon Isi No Antrian Pasien Sesuai dengan Urutan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgvobat.Rows.Count == 0)
            {
                MessageBox.Show("Silahkan Pilih Obat Resep Untuk Pasien!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean sukses = false;
                //Save To Table t_resep
                sukses = mycom.setsql("INSERT INTO t_resep VALUES('" + txtnoktp.Text + "', '" + txtnamapasien.Text + "', '" + txtpaket.Text + "', '" + txtdiagnosa.Text + "', '" + txttindakan.Text + "', '" + GV.NamaObat + "')");

                //Save To Table t_detail_pasien
                for (int i = 0; i <= dgvobat.Rows.Count - 1; i++)
                {
                    String ObatID = dgvobat.Rows[i].Cells["ObatID"].Value.ToString();
                    String HargaObat = dgvobat.Rows[i].Cells["Harga Obat"].Value.ToString();
                    String QTYObat = dgvobat.Rows[i].Cells["QTY Obat"].Value.ToString();
                    sukses = mycom.setsql("INSERT INTO t_detail_pasien VALUES('" + txtnoktp.Text + "', '" + ObatID + "', '" + HargaObat + "', '" + QTYObat + "')");

                    //Update Table t_obat
                    sukses = mycom.setsql("UPDATE t_obat SET stock = stock - " + QTYObat + " WHERE id_obat = '" + ObatID + "'");
                }
                if (sukses)
                {
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bersih();
                }
                else
                {
                    MessageBox.Show("Data Gagal Disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Bersih()
        {
            txttgldaftar.Enabled = true;
            txtnoktp.Clear();
            txtnamapasien.Clear();
            txtpaket.Clear();
            txtdiagnosa.Clear();
            txttindakan.Clear();
            txtperawatan.Clear();
            txtdokter.Clear();
            dgvobat.Rows.Clear();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void txtbayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //DGVPrinter printer = new DGVPrinter();
            //printer.PrintDataGridView(dgvobat);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void ResepPreview_Click(object sender, EventArgs e)
        {
            ResepPrintPreview.Document = ResepPrintDocument;
            ResepPrintPreview.ShowDialog();
        }

        private void ResepPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
                Bitmap bmp = Properties.Resources.KopSurat4;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 0, 15, newImage.Width, newImage.Height);
                e.Graphics.DrawString("LAPORAN RESEP DOKTER", new Font("Arial", 20, FontStyle.Bold),
                Brushes.Black, new Point(250, 240));

                e.Graphics.DrawString("No Antrian Pasien : " + txttgldaftar.Text, new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, new Point(35, 320));

                e.Graphics.DrawString("No KTP Pasien       : " + txtnoktp.Text, new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, new Point(35, 340));

                e.Graphics.DrawString("Nama Pasien          : " + txtnamapasien.Text, new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, new Point(35, 360));

                //Dokter
                e.Graphics.DrawString("Diperiksa Oleh   : " + txtdokter.Text, new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, new Point(440, 320));

                //e.Graphics.DrawString("Tarif Dokter        : " + txttarif.Text, new Font("Arial", 12, FontStyle.Bold),
                //Brushes.Black, new Point(440, 340));

                e.Graphics.DrawString("1) Detail Pasien", new Font("Arial", 15, FontStyle.Bold),
                Brushes.Black, new Point(35, 410));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 430));

                e.Graphics.DrawString("Paket", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 445));

                e.Graphics.DrawString("Diagnosa", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(200, 445));

                e.Graphics.DrawString("Tindakan", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(380, 445));

                e.Graphics.DrawString("Perawatan", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(550, 445));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 460));

                //Text Paket
                e.Graphics.DrawString(txtpaket.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 480));

                //Text Diagnosa
                e.Graphics.DrawString(txtdiagnosa.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(200, 480));

                //Text Tindakan
                e.Graphics.DrawString(txttindakan.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(380, 480));

                //Text Perawatan
                e.Graphics.DrawString(txtperawatan.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(550, 480));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 540));

                //Resep Dokter
                e.Graphics.DrawString("2) Resep Dokter", new Font("Arial", 15, FontStyle.Bold),
                Brushes.Black, new Point(35, 590));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 640));

                e.Graphics.DrawString("Nama Obat", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 655));

                e.Graphics.DrawString("Harga Obat", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(420, 655));

                e.Graphics.DrawString("QTY", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(560, 655));

                e.Graphics.DrawString("Total Harga", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(650, 655));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 670));

                //Cell DGVObat
                String NamaObat, HargaObat, QTYObat, TotalHarga;
                for (int i = 0; i <= dgvobat.Rows.Count - 1; i++)
                {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                    NamaObat = dgvobat.Rows[i].Cells["Nama Obat"].Value.ToString();
                    HargaObat = dgvobat.Rows[i].Cells["Harga Obat"].Value.ToString();
                    QTYObat = dgvobat.Rows[i].Cells["QTY Obat"].Value.ToString();
                    TotalHarga = dgvobat.Rows[i].Cells["Total Harga"].Value.ToString();

                    e.Graphics.DrawString(NamaObat, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(50, 685));

                    e.Graphics.DrawString("Rp." + HargaObat, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(420, 685));

                    e.Graphics.DrawString(QTYObat, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(560, 685));

                    e.Graphics.DrawString("Rp. " + TotalHarga, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(650, 685));

                    //e.Graphics.DrawString("Rp. " + txttotal.Text, new Font("Arial", 12, FontStyle.Regular),
                    //Brushes.Black, new Point(650, 915));
                }
                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 900));

                e.Graphics.DrawString("Total Bayar ( + Tarif Dokter )", new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 915));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 930));

                e.Graphics.DrawString(" ~ Semoga Lekas Sembuh ~ ", new Font("Arial", 17, FontStyle.Bold),
                Brushes.Black, new Point(274, 980));
            }

        private void button7_Click(object sender, EventArgs e)
        {
            FORM_LOGIN l = new FORM_LOGIN();
            l.Show();
            this.Hide();
        }

        private void btncariobat_Click_1(object sender, EventArgs e)
        {
            if (txttgldaftar.Text == "")
            {
                MessageBox.Show("Mohon Isi No Antrian Pasien Sesuai dengan Urutan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GV.LoadForm = "CARI OBAT";
                FORM_CARI_OBAT frm_cari_obat = new FORM_CARI_OBAT();
                frm_cari_obat.ShowDialog();

                //dgvobat.Rows.Add(GV.ObatID, GV.NamaObat, GV.HargaObat, GV.QTYObat, GV.HargaObat);
                if (GV.ObatID != "")
                {
                    Boolean ketemu = false;
                    int x = 0;
                    int qty = 0;
                    for (x = 0; x <= dgvobat.Rows.Count - 1; x++)
                    {
                        if (dgvobat.Rows[x].Cells["ObatID"].Value.ToString() == GV.ObatID)
                        {
                            ketemu = true;
                            break;
                        }
                    }
                    if (ketemu)
                    {
                        qty = int.Parse(dgvobat.Rows[x].Cells["QTY Obat"].Value.ToString()) + qty;
                        dgvobat.Rows[x].Cells["QTY Obat"].Value = Double.Parse(GV.QTYObat);
                        dgvobat.Rows[x].Cells[5].Value = Double.Parse(GV.HargaObat) * qty;
                        //dgvobat.Rows[x].Cells["Harga Obat"].Value = Double.Parse(GV.HargaObat);
                        //dgvobat.Rows[x].Cells["QTY Obat"].Value = Double.Parse(GV.QTYObat);
                        //TotalHarga = Double.Parse(GV.HargaObat) * Double.Parse(GV.QTYObat);
                        //dgvobat.Rows[x].Cells["Total Harga"].Value = TotalHarga.ToString();
                    }
                    else
                    {
                        dgvobat.Rows.Add(GV.ObatID, GV.NamaObat, GV.HargaObat, GV.QTYObat, GV.ResepObat);
                    }
                }
            }
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            ResepPrintPreview.Document = ResepPrintDocument;
            ResepPrintPreview.ShowDialog();
        }

        private void ResepPrintPreview_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            DataTable dtdet = new DataTable();
            dtdet = mycom.getsql("SELECT * FROM t_detail_pasien WHERE tgl_daftar = '" + txttgldaftar.Text + "'");
            DataTable dtresep = new DataTable();
            dtresep = mycom.getsql("SELECT * FROM t_resep WHERE tgl_daftar = '" + txttgldaftar.Text + "'");
            if (txttgldaftar.Text == "")
            {
                MessageBox.Show("Mohon Isi No Antrian Pasien Sesuai dengan Urutan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgvobat.Rows.Count == 0)
            {
                MessageBox.Show("Silahkan Pilih Obat Resep Untuk Pasien!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean sukses = false;
                //Save To Table t_resep

                if (dtdet.Rows.Count == 0 || dtresep.Rows.Count == 0)
                {
                    //Save To Table t_detail_pasien
                    for (int i = 0; i <= dgvobat.Rows.Count - 1; i++)
                    {
                        String ObatID = dgvobat.Rows[i].Cells["ObatID"].Value.ToString();
                        String NamaObat = dgvobat.Rows[i].Cells["Nama Obat"].Value.ToString();
                        String HargaObat = dgvobat.Rows[i].Cells["Harga Obat"].Value.ToString();
                        String QTYObat = dgvobat.Rows[i].Cells["QTY Obat"].Value.ToString();
                        String ResepObat = dgvobat.Rows[i].Cells["Resep Obat"].Value.ToString();
                        sukses = mycom.setsql("INSERT INTO t_detail_pasien VALUES('" + txtnoktp.Text + "', '" + txtnamapasien.Text + "', '" + txttgldaftar.Text + "' , '" + ObatID + "', '" + HargaObat + "', '" + QTYObat + "')");

                        sukses = mycom.setsql("INSERT INTO t_resep VALUES('" + txttgldaftar.Text + "', '" + txtnamapasien.Text + "', '" + txtpaket.Text + "', '" + txtdiagnosa.Text + "', '" + txttindakan.Text + "', '" + NamaObat + "', '" + ResepObat + "')");

                        //Update Table t_obat
                        sukses = mycom.setsql("UPDATE t_obat SET stock = stock - " + QTYObat + " WHERE id_obat = '" + ObatID + "'");

                    }
                    if (sukses)
                    {
                        MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bersih();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pasien Ini Sudah Diberi Resep!");
                }
            }
        }
    }
}
