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
    public partial class FORM_REGISTER_ACCOUNT : Form
    {
        MysqlComponent mycom = new MysqlComponent();
        DataTable dtregister = new DataTable();
        String status;

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

        public FORM_REGISTER_ACCOUNT()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void FORM_REGISTER_ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORM_LOGIN frm_login = new FORM_LOGIN();
            frm_login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "input new username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.DimGray;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "input new username";
                txt_username.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "input new password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_Leave_1(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "input new password";
                txt_password.ForeColor = Color.DimGray;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            dtregister = mycom.getsql("SELECT * FROM t_user");
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_password.Text, "[^a-z]"))
            {
                MessageBox.Show("Mohon Maaf Password Tidak Boleh Ada Caps Lock dan Karakter Unik!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Text = "";
                txt_username.Text = "";
            }
            else if (txt_username.Text == "input new username" || txt_password.Text == "input new password" || cbolevel.Text == "select here")
            {
                MessageBox.Show("Mohon Isi Terlebih Dahulu Data yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_username.Text == "" || txt_password.Text == "" || cbolevel.Text == "")
            {
                MessageBox.Show("Mohon Isi Terlebih Dahulu Data yang Kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (dtregister.Rows.Count != 0)
            //{
            //    mycom.Pesan("Username atau Password atau Level Sudah Ada!");
            //}
            else
            {
                status = "Register";
                Boolean berhasil = true;
                if (status == "Register")
                {
                    berhasil = mycom.setsql("INSERT INTO t_user (username, password, level) VALUES ('" + txt_username.Text + "', '" + txt_password.Text + "', '" + cbolevel.Text + "')");
                }
                if (berhasil)
                {
                    mycom.Pesan("Registrasi Sukses! Please Login.");
                    FORM_LOGIN frm_login = new FORM_LOGIN();
                    frm_login.Show();
                    this.Hide();
                }
                else
                {
                    mycom.Pesan("Registrasi Gagal! Mohon Ulang Kembali.");
                }
            }
            
        }

        private void cbolevel_Enter(object sender, EventArgs e)
        {
            if (cbolevel.Text == "select here")
            {
                cbolevel.Text = "";
                cbolevel.ForeColor = Color.DimGray;
            }
        }

        private void cbolevel_Leave(object sender, EventArgs e)
        {
            if (cbolevel.Text == "")
            {
                cbolevel.Text = "select here";
                cbolevel.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exit_Paint(object sender, PaintEventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
