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

namespace seteguk
{
    public partial class FormStok : Form
    {
        private static string dbconn = "server=localhost;port=3306;username=root;password=;database=seteguk;";
        private MySqlConnection databaseConn = new MySqlConnection(dbconn);

        public FormStok()
        {
            InitializeComponent();
        }

        public void getBahanBaku()
        {
            string query = "SELECT * FROM stgk_bahan_baku";
            try
            {
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                MySqlDataReader r = cmd.ExecuteReader();

                if(r.HasRows)
                {
                    while (r.Read())
                    {
                        ListViewItem bb = new ListViewItem(r["id"].ToString());
                        bb.SubItems.Add(r["nama_bahan"].ToString());
                        bb.SubItems.Add(r["stok"].ToString());
                        bb.SubItems.Add(r["satuan"].ToString());
                        bb.SubItems.Add(r["harga_satuan"].ToString());
                        list_bahan_baku.Items.Add(bb);
                    }
                }
                else
                {
                    MessageBox.Show("Tidak Ada Data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConn.Close();
            }
        }

        public void getSatuan()
        {
            string query = "SELECT * FROM stgk_satuan";
            try
            {
                //koneksi dibuka
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString("satuan"));
                    }
                }
                else
                {
                    MessageBox.Show("Tidak Ada data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //tutup koneksi
                databaseConn.Close();
            }
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            getBahanBaku();
            getSatuan();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            list_bahan_baku.Items.Clear();
            string query = "INSERT INTO stgk_bahan_baku (nama_bahan, stok, satuan, harga_satuan) VALUES (@nama, @stok, @satuan, @harga)";
            try
            {
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                cmd.Parameters.AddWithValue("@stok", textBox3.Text);
                cmd.Parameters.AddWithValue("@satuan", pilih);
                cmd.Parameters.AddWithValue("@harga", textBox5.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menambahkan data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                getBahanBaku();
                getSatuan();
            }
        }

        String pilih;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object sat = comboBox1.SelectedItem;
            pilih = sat.ToString();
        }
    }
}
