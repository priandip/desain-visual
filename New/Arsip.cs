using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace New
{
    public partial class Arsip : UserControl
    {
        public Arsip()
        {
            InitializeComponent();
        }

        private void Arsip_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            string noarsip = NoArsip.Text;
            string nosurat = NoSurat.Text;
            string lokasiarsip = LokasiArsip.Text;
            string keterangan = Keterangan.Text;
            string tanggalarsip = TangalArsip.Text;

            DatabaseConnector DB = new DatabaseConnector();
            string query = "INSERT INTO surat_keluar (no_arsip, no_surat, lokasi_arsip, keterangan, tgl_arsip) VALUES (@no_arsip, @no_surat, @lokasi_arsip, @keterangan, @tgl_arsip);";
            
            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@no_arsip", noarsip);
            command.Parameters.AddWithValue("@no_surat", nosurat);
            command.Parameters.AddWithValue("@lokasi_arsip", lokasiarsip);
            command.Parameters.AddWithValue("@keterangan", keterangan);
            command.Parameters.AddWithValue("@tanggal_arsip", tanggalarsip);

            try
            {
                DB.Connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("Berhasil membuat arsip");
                }
            }

            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ada record dengan nomor surat yang sama");
                }
            }
            finally
            {
                DB.Connection.Close();
            }
        }
    }
}
