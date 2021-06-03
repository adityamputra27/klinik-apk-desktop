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
    public partial class FORM_ADMINISTRASI : Form
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
        public FORM_ADMINISTRASI(String admin)
        {
            InitializeComponent();
            lblwelcome.Text = "" + admin;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += " : ";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += " : ";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            labeljam.Text = time;

        }  

        private void FORM_ADMINISTRASI_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            tgl_daftar.Format = DateTimePickerFormat.Custom;
            tgl_daftar.CustomFormat = "dd-MM-yyyy";
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Logout dari Aplikasi Ini?", "Pertanyaan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FORM_LOGIN login = new FORM_LOGIN();
                login.Show();
                this.Hide();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tampil()
        {
            DataTable dtpasien = new DataTable();
            dtpasien = mycom.getsql("SELECT p.nama_pasien, d.tarif_dokter FROM t_pemeriksaan p" 
            + " INNER JOIN t_dokter d ON p.nama_dokter = d.nama_dokter "
            + " WHERE p.tgl_daftar = '" + tgl_daftar.Text + "'");
            if (dtpasien.Rows.Count != 0)
            {
                txtnamapasien.Text = dtpasien.Rows[0]["nama_pasien"].ToString();
                txttarif.Text = dtpasien.Rows[0]["tarif_dokter"].ToString();
            }
            else
            {
                MessageBox.Show("Pasien Ini Belum Diperiksa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilPasien()
        {
            dgvpasien.DataSource = mycom.getsql("SELECT r.paket, p.nama_pasien, p.diagnosa, p.tindakan, p.perawatan, "
            + " p.nama_dokter FROM t_pemeriksaan p INNER JOIN t_resep r ON r.tgl_daftar = p.tgl_daftar "
            + " WHERE p.tgl_daftar = '" + tgl_daftar.Text + "' AND p.nama_pasien = '" + txtnamapasien.Text + "'");
        }

        private void TampilResep()
        {
            dgvresep.DataSource = mycom.getsql("SELECT obat_resep, resep_dokter FROM t_resep WHERE nama_pasien = '" + txtnamapasien.Text + "'");
        }

        private void TampilObat()
        {
            dgvobat.DataSource = mycom.getsql("SELECT harga, qty FROM t_detail_pasien WHERE nama_pasien = '" + txtnamapasien.Text + "'");
        }
            

        private void TotalBayar()
        {
            DataTable dtvalid = new DataTable();
            dtvalid = mycom.getsql("SELECT harga, qty FROM t_detail_pasien WHERE nama_pasien = '" + txtnamapasien.Text + "'");

            if (dtvalid.Rows.Count == 0)
            {
                if (tgl_daftar.Text == "")
                {
                    MessageBox.Show("Mohon Isi Tanggal Pendaftarannya!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Bersih();
                }
                else if (dgvobat.Rows.Count == 0)
                {
                    MessageBox.Show("Pasien Ini Belum Diperiksa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Clean();
                    tgl_daftar.Enabled = true;
                    tgl_daftar.Text = "";
                }
                else
                {
                    double TotalBayar, Total, Tarif;
                    DataTable dttotal = new DataTable();
                    dttotal = mycom.getsql("SELECT (SUM(harga) * SUM(qty)) AS TotalBayar FROM t_detail_pasien");
                    TotalBayar = Double.Parse(dttotal.Rows[0]["TotalBayar"].ToString());
                    Tarif = Double.Parse(txttarif.Text);
                    Total = TotalBayar + Tarif;
                    txttotalbayar.Text = Total.ToString();
                }
            }
            else
            {
                //Bersih();
            }
        }

        private void Bersih()
        {
            txtnamapasien.Clear();
            txttotalbayar.Clear();
            txtbayar.Clear();
            txtkembalian.Clear();
            dgvpasien.Rows.Clear();
            dgvobat.Rows.Clear();
            dgvresep.Rows.Clear();
        }

        private void DeletePasien()
        {
            //Boolean berhasil = false;
            mycom.setsql("DELETE FROM t_detail_pasien WHERE tgl_daftar = '" + tgl_daftar.Text + "' AND nama_pasien = '" + txtnamapasien.Text + "'");
            mycom.setsql("DELETE FROM t_pendaftaran WHERE nama_pasien = '" + txtnamapasien.Text + "'");
            mycom.setsql("DELETE FROM t_pasien WHERE nama_pasien = '" + txtnamapasien.Text + "'");
            mycom.setsql("DELETE FROM t_pemeriksaan WHERE tgl_daftar = '" + tgl_daftar.Text + "' AND nama_pasien = '" + txtnamapasien.Text + "'");
            mycom.setsql("DELETE FROM t_resep WHERE tgl_daftar = '" + tgl_daftar.Text + "' AND nama_pasien = '" + txtnamapasien.Text + "'");
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            DataTable dtsimpan = new DataTable();
            dtsimpan = mycom.getsql("SELECT * FROM t_pemeriksaan WHERE nama_pasien = '" + txtnamapasien.Text + "'");

            if (dtsimpan.Rows.Count == 0)
            {
                TampilPasien();
                TampilResep();
                Tampil();
                TampilObat();
                TotalBayar();
                if (dgvobat.Rows.Count == 0)
                {
                    tgl_daftar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Pasien Ini Sudah Melakukan Administrasi atau Pembayaran!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Bersih();
            }
        }

        private void ConfirmPrint()
        {
            StrukPrintPreview.Document = StrukPrintDocument;
            StrukPrintPreview.ShowDialog();
        }

        private void StrukPrintPreview_Load(object sender, EventArgs e)
        {
            //CetakData();

        }

        private void Clean()
        {
            tgl_daftar.Enabled = true;
            dgvpasien.Rows.Clear();
            dgvobat.Rows.Clear();
            dgvresep.Rows.Clear();
            txttotalbayar.Clear();
            txtbayar.Clear();
            txtkembalian.Clear();
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            if (txtbayar.Text == "" || tgl_daftar.Text == "")
            {
                MessageBox.Show("Mohon Isi Data Yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean berhasil = false;
                String Nama, Diagnosa, Harga, Obat, QTY, Tindakan, Perawatan;
                Nama = dgvpasien.Rows[0].Cells["nama_pasien"].Value.ToString();
                Tindakan = dgvpasien.Rows[0].Cells["tindakan"].Value.ToString();
                Perawatan = dgvpasien.Rows[0].Cells["perawatan"].Value.ToString();
                Diagnosa = dgvpasien.Rows[0].Cells["diagnosa"].Value.ToString();
                Harga = dgvobat.Rows[0].Cells["harga"].Value.ToString();
                Obat = dgvresep.Rows[0].Cells["obat_resep"].Value.ToString();
                QTY = dgvobat.Rows[0].Cells["qty"].Value.ToString();

                berhasil = mycom.setsql("INSERT INTO tb_simpan VALUES('" + Nama + "', '" + Tindakan + "','" + Perawatan + "' , '" + Diagnosa + "', '" + Obat + "', '" + Harga + "', '" + QTY + "')");
                DeletePasien();

                if (berhasil)
                {
                    if (MessageBox.Show("Data Berhasil Disimpan! Cetak Laporan Administrasi?", "INFORMASI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ConfirmPrint();
                        Clean();
                    }
                }
                else
                {
                    MessageBox.Show("Data Gagal Disimpan! Harap Perhatikan Data Yang Masih Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StrukPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.KopSurat4;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 0, 15, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Laporan Administrasi", new Font("Arial", 20, FontStyle.Bold),
            Brushes.Black, new Point(280, 240));

            e.Graphics.DrawString("Tanggal Pendaftaran : " + tgl_daftar.Text, new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(35, 320));

            e.Graphics.DrawString("Nama Pasien             : " + txtnamapasien.Text, new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(35, 340));

            String nama_dokter;
            for (int i = 0; i <= dgvpasien.Rows.Count - 1; i++)
            {
                nama_dokter = dgvpasien.Rows[i].Cells["nama_dokter"].Value.ToString();
                //Dokter
                e.Graphics.DrawString("Dokter          : " + nama_dokter, new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, new Point(490, 320));
            }

            e.Graphics.DrawString("Tarif Dokter : " + "Rp. " + txttarif.Text, new Font("Arial", 12, FontStyle.Bold),
            Brushes.Black, new Point(490, 340));

            e.Graphics.DrawString("1) Detail Pasien", new Font("Arial", 13, FontStyle.Bold),
            Brushes.Black, new Point(35, 410));

            e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 430));

            String Paket, Diagnosa, Tindakan, Perawatan;
            for (int i = 0; i <= dgvpasien.Rows.Count - 1; i++)
            {
                Paket = dgvpasien.Rows[i].Cells["paket"].Value.ToString();
                Diagnosa = dgvpasien.Rows[i].Cells["diagnosa"].Value.ToString();
                Tindakan = dgvpasien.Rows[i].Cells["tindakan"].Value.ToString();
                Perawatan = dgvpasien.Rows[i].Cells["perawatan"].Value.ToString();

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
                e.Graphics.DrawString(Paket, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 480));

                //Text Diagnosa
                e.Graphics.DrawString(Diagnosa, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(200, 480));

                //Text Tindakan
                e.Graphics.DrawString(Tindakan, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(380, 480));

                //Text Perawatan
                e.Graphics.DrawString(Perawatan, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(550, 480));

                e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(35, 560));
            }
            //Resep Dokter
            e.Graphics.DrawString("2) Resep Dokter", new Font("Arial", 15, FontStyle.Bold),
            Brushes.Black, new Point(35, 590));

            e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 640));

            e.Graphics.DrawString("Nama Obat", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(50, 655));

            e.Graphics.DrawString("Harga Obat", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(300, 655));

            e.Graphics.DrawString("QTY", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(400, 655));

            e.Graphics.DrawString("Total Harga", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(440, 655));

            e.Graphics.DrawString("Resep", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(540, 655));

            e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 670));

            //Cell DGVObat
            String NamaObat, HargaObat, QTYObat, TotalHarga, Resep;

            for (int i = 0; i <= dgvresep.Rows.Count - 1; i++)
            {
                NamaObat = dgvresep.Rows[i].Cells["obat_resep"].Value.ToString();
                Resep = dgvresep.Rows[i].Cells["resep_dokter"].Value.ToString();

                e.Graphics.DrawString(NamaObat, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(50, 685));

                e.Graphics.DrawString(Resep, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(540, 685));
            }

            for (int i = 0; i <= dgvobat.Rows.Count - 1; i++)
            {
                
                HargaObat = dgvobat.Rows[i].Cells["harga"].Value.ToString();
                QTYObat = dgvobat.Rows[i].Cells["qty"].Value.ToString();
                TotalHarga = (Double.Parse(HargaObat) * Double.Parse(QTYObat)).ToString();
                string[,] rows = new string[,] {
                                                    {""} 
                                                };

                for (int a = 0; a < rows.GetLength(0); a++)
                {
                    string[] row = new string[rows.GetLength(1)];
                    for (int b = 0; b < rows.GetLength(1); b++)
                    {
                        row[b] = rows[i, b];
                    }

                    e.Graphics.DrawString("Rp." + HargaObat, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(300, 685));

                    e.Graphics.DrawString(QTYObat, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(400, 685));

                    e.Graphics.DrawString("Rp. " + TotalHarga, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(440, 685));

                }

                e.Graphics.DrawString("Rp. " + txttotalbayar.Text, new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, new Point(650, 915));
            }
            e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 900));

            e.Graphics.DrawString("Total Bayar ( + Tarif Dokter )", new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 915));

            e.Graphics.DrawString(Garis.Text, new Font("Arial", 12, FontStyle.Regular),
            Brushes.Black, new Point(35, 930));

            e.Graphics.DrawString(" ~ Semoga Lekas Sembuh ~ ", new Font("Arial", 17, FontStyle.Bold),
            Brushes.Black, new Point(270, 980));
        }

        private void txttotalbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtbayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (txtbayar.Text == "")
                {
                    MessageBox.Show("Harap Masukkan Nominal Pembayaran", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Double.Parse(txtbayar.Text) < Double.Parse(txttotalbayar.Text))
                {
                    MessageBox.Show("Mohon Maaf Nominal Yang Anda Masukkan Kurang dari Total Bayar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    txtkembalian.Text = (Double.Parse(txtbayar.Text) - Double.Parse(txttotalbayar.Text)).ToString();
                }
            }
        }
    }
}
