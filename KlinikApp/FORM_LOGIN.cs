using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace KlinikApp
{
    public partial class FORM_LOGIN : Form
    {
        MysqlComponent mycom = new MysqlComponent();
        DataTable dt;

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

        public FORM_LOGIN()
        {
            InitializeComponent();
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                mycom.Pesan("Username Atau Password Harus Diisi!");
            }
            else
            {
                dt = new DataTable();
                dt = mycom.getsql("select * from t_user where username='" + txt_username.Text + "' and password ='" + txt_password.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    mycom.Pesan("Username atau Password Salah Gan!");
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["level"].ToString() == "ADMINISTRATOR")
                            {
                                this.Hide();
                                FORM_ADMIN frm_admin = new FORM_ADMIN(txt_username.Text);
                                frm_admin.Show();
                            }
                            else if (dt.Rows[i]["level"].ToString() == "DOKTER")
                            {
                                this.Hide();
                                FORM_ADMIN_DOKTER frm_admin_dokter = new FORM_ADMIN_DOKTER(txt_username.Text);
                                frm_admin_dokter.Show();
                                txt_username.Text = GV.NamaDokter;
                            }
                            else if (dt.Rows[i]["level"].ToString() == "ADMINISTRASI / PETUGAS")
                            {
                                this.Hide();
                                FORM_ADMINISTRASI frm_admin = new FORM_ADMINISTRASI(txt_username.Text);
                                frm_admin.Show();
                            }
                        }
                    }
                }
            }
        }

        private void FORM_LOGIN_Load(object sender, EventArgs e)
        {
            //txt_username.Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, txt_username.Width, txt_username.Height, 60, 60));
            //panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?","Informasi" , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void close_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORM_REGISTER_ACCOUNT frm_register = new FORM_REGISTER_ACCOUNT();
            frm_register.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                mycom.Pesan("Username Atau Password Harus Diisi!");
            }
            else
            {
                dt = new DataTable();
                dt = mycom.getsql("select * from t_user where username='" + txt_username.Text + "' and password ='" + txt_password.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    mycom.Pesan("Username atau Password Salah Gan!");
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["level"].ToString() == "ADMINISTRATOR")
                            {
                                this.Hide();
                                FORM_ADMIN frm_admin = new FORM_ADMIN(txt_username.Text);
                                frm_admin.Show();
                            }
                            else if (dt.Rows[i]["level"].ToString() == "DOKTER")
                            {
                                this.Hide();
                                FORM_ADMIN_DOKTER frm_admin_dokter = new FORM_ADMIN_DOKTER(txt_username.Text);
                                frm_admin_dokter.Show();
                                txt_username.Text = GV.NamaDokter;
                            }
                            else if (dt.Rows[i]["level"].ToString() == "ADMINISTRASI / PETUGAS")
                            {
                                this.Hide();
                                FORM_ADMINISTRASI frm_admin = new FORM_ADMINISTRASI(txt_username.Text);
                                frm_admin.Show();
                            }
                        }
                    }
                }
            }
        }

        private void register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORM_REGISTER_ACCOUNT frm_register = new FORM_REGISTER_ACCOUNT();
            frm_register.Show();
            this.Hide();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
