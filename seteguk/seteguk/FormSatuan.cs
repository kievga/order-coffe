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
    public partial class FormSatuan : Form
    {
        private static string dbcon = "server=localhost;port=3306;username=root;password=;database=seteguk;";
        private MySqlConnection databaseConn = new MySqlConnection(dbcon);

        public FormSatuan()
        {
            InitializeComponent();
        }

        public void getListSatuan()
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
                        ListViewItem listsatuan = new ListViewItem(reader["id_satuan"].ToString());
                        listsatuan.SubItems.Add(reader["satuan"].ToString());
                        listsatuan.SubItems.Add(reader["jumlah"].ToString());
                        listsatuan.SubItems.Add(reader["satuan_detail"].ToString());
                        list_satuan.Items.Add(listsatuan);
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

        private void FormSatuan_Load(object sender, EventArgs e)
        {
            getListSatuan();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            list_satuan.Items.Clear();
            string query = "INSERT INTO stgk_satuan (satuan, jumlah, satuan_detail) VALUES (@satuan, @jumlah, @detail)";
            try
            {
                //buka
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@satuan", text_satuan.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.Parameters.AddWithValue("@detail", text_satuan_detail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menambahkan data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConn.Close();
                text_id.Text = "";
                text_satuan.Text = "";
                text_jumlah.Text = "";
                text_satuan_detail.Text = "";
                getListSatuan();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            list_satuan.Items.Clear();
            string query = "UPDATE stgk_satuan SET satuan = @satuan, jumlah = @jumlah, satuan_detail = @detail WHERE id_satuan = @id";
            try
            {
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@satuan", text_satuan.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.Parameters.AddWithValue("@detail", text_satuan_detail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengubah data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConn.Close();
                text_id.Text = "";
                text_satuan.Text = "";
                text_jumlah.Text = "";
                text_satuan_detail.Text = "";
                getListSatuan();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            list_satuan.Items.Clear();
            string query = "DELETE FROM stgk_satuan WHERE id_satuan = @id";
            try
            {
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConn.Close();
                text_id.Text = "";
                text_satuan.Text = "";
                text_jumlah.Text = "";
                text_satuan_detail.Text = "";
                getListSatuan();
            }
        }

        ListViewItem daftarsatuan;
        private void List_satuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_satuan.SelectedItems.Count > 0)
            {
                daftarsatuan = list_satuan.SelectedItems[0];
                text_id.Text = daftarsatuan.SubItems[0].Text;
                text_satuan.Text = daftarsatuan.SubItems[1].Text;
                text_jumlah.Text = daftarsatuan.SubItems[2].Text;
                text_satuan_detail.Text = daftarsatuan.SubItems[3].Text;
            }
            else
            {
                text_id.Text = "";
                text_satuan.Text = "";
                text_jumlah.Text = "";
                text_satuan_detail.Text = "";
            }
        }
    }
}
