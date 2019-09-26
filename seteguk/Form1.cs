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
    public partial class Form1 : Form
    {
        // Prepare the connection
        private static string connectionString = "server=localhost;port=3306;username=root;password='';database=seteguk;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE stgk_pemesanan SET id_pemesanan = @id_pemesanan, nama_pembeli=@nama_pembeli,nama_menu = @nama_menu, jumlah = @jumlah, total_harga = @total_harga WHERE id_pemesan = @id_pemesan";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_pemesanan", text_no.Text);
                cmd.Parameters.AddWithValue("@nama_pembeli", text_pembeli.Text);
                cmd.Parameters.AddWithValue("@nama_menu", text_menu.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.Parameters.AddWithValue("@total_harga", text_harga.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT * FROM stgk_pemesanan INNER JOIN stgk_menu ON stgk_pemesanan.id_menu = stgk_menu.id_menu;";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listView1.Items.Add(listViewItem);
                        text_pembeli.Text = reader["nama_pembeli"].ToString();
                        text_harga.Text = reader["total_harga"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE * FROM stgk_pemesanan INNER JOIN stgk_menu ON stgk_pemesanan.id_menu = stgk_menu.id_menu WHERE stgk_pemesanan.id_pemesanan = @id_pemesanan;";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_pemesan", text_no.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        ListViewItem listv;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stgk_pemesanan INNER JOIN stgk_menu ON stgk_pemesanan.id_menu = stgk_menu.id_menu WHERE stgk_pemesanan.id_pemesanan = @id_pemesanan; ";

            if (listView1.SelectedItems.Count > 0)
            {
                

                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_pemesanan", text_no.Text);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listView1.Items.Add(listViewItem);
                        text_pembeli.Text = reader["nama_pembeli"].ToString();
                        text_harga.Text = reader["total_harga"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada pemesanan");
                }
            }
            else
            {
                listView1.Items.Clear();
                text_no.Text = "";
                text_pembeli.Text = "";
                text_harga.Text = "";
            }
            databaseConnection.Close();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stgk_pemesanan INNER JOIN stgk_menu ON stgk_pemesanan.id_menu = stgk_menu.id_menu;";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listViewItem.SubItems.Add(reader["total_harga"].ToString());
                        listView1.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}
