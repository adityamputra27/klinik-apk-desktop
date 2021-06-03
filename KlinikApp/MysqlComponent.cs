using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KlinikApp
{
    class MysqlComponent
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter da;
        DataTable dt;
        String Text;

        public String no_antrian_otomatis()
        {
            string no_antri;
            string query = "SELECT no_antrian FROM t_pendaftaran ORDER BY no_antrian DESC";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                no_antri = id.ToString("0000");
            }
            else if (Convert.IsDBNull(dr))
            {
                no_antri = "0001";
            }
            else
            {
                no_antri = "0001";
            }
            con.Close();
            return no_antri;
        }

        public String IDPegawai()
        {
            long Hitung;
            string Urutan;
            MySqlDataReader rd;
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_pegawai FROM t_pegawai WHERE id_pegawai IN (SELECT MAX(id_pegawai) FROM t_pegawai) ORDER BY id_pegawai DESC", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_pegawai"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + Hitung;
                Urutan = "PGA-" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                Urutan = "PGA-00001";
            }
            rd.Close();
            con.Close();
            return Urutan;
        }

        public String IDDokter()
        {
            long Hitung;
            string Urutan;
            MySqlDataReader rd;
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_dokter FROM t_dokter WHERE id_dokter IN (SELECT MAX(id_dokter) FROM t_dokter) ORDER BY id_dokter DESC", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_dokter"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + Hitung;
                Urutan = "DKT-" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                Urutan = "DKT-00001";
            }
            rd.Close();
            con.Close();
            return Urutan;
        }

        public String IDObat()
        {
            long Hitung;
            string Urutan;
            MySqlDataReader rd;
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT id_obat FROM t_obat WHERE id_obat IN (SELECT MAX(id_obat) FROM t_obat) ORDER BY id_obat DESC", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_obat"].ToString().Length - 5, 5)) + 1;
                string joinstr = "00000" + Hitung;
                Urutan = "MDCN-" + joinstr.Substring(joinstr.Length - 5, 5);
            }
            else
            {
                Urutan = "MDCN-00001";
            }
            rd.Close();
            con.Close();
            return Urutan;
        }

        public String Tanggal_Pendaftaran()
        {
            try
            {
                this.BukaKoneksi();
                da = new MySqlDataAdapter("SELECT tgl_daftar FROM t_pendaftaran ORDER BY tgl_daftar DESC", con);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Text = dt.Rows[0][0].ToString();
                    if (Text.Substring(0, 8) == DateTime.Today.ToString("dd-MM-yyyy"))
                    {
                        //Text = Text.Substring(8, 3);
                        //Text = Convert.ToString(Double.Parse(Text) + 1);
                        Text = DateTime.Today.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        Text = DateTime.Today.ToString("dd-MM-yyyy");
                    }
                }
                else
                {
                    Text = DateTime.Today.ToString("dd-MM-yyyy");
                }
                this.TutupKoneksi();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }

            return Text;
        }

        public void BukaKoneksi()
        {
            try
            {
                con = new MySqlConnection("SERVER='localhost';username='root';password='';database='klinik_gigi'");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Tidak Connect ke Database : " + ex.Message, "Pemberitahuan", MessageBoxButtons.OK);
            }
        }

        public void TutupKoneksi()
        {
            con.Close();
        }

        public Boolean setsql(string str)
        {
            Boolean hasil = false;
            try
            {
                this.BukaKoneksi();
                com = new MySqlCommand(str, con);
                com.ExecuteNonQuery();
                this.TutupKoneksi();
                hasil = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }

            return hasil;

        }
        public DataTable getsql(string str)
        {
            dt = new DataTable();
            try
            {
                this.BukaKoneksi();
                da = new MySqlDataAdapter(str, con);
                // da = new MySqlDataAdapter()
                da.Fill(dt);
                this.TutupKoneksi();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
            return dt;

        }

        public void Pesan(String pesan)
        {
            MessageBox.Show(pesan, "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
