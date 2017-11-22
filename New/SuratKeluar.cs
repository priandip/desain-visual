using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace New
{
    public partial class SuratKeluar : UserControl
    {
        private string filePath;
        public SuratKeluar()
        {
            InitializeComponent();
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
    {
            string kepada = Kepada.Text;
            string tembusan = Tembusan.Text;
            string nosurat = NoSurat.Text;
            string tanggalsurat = TanggalSurat.Text;
            string perihal = Perihal.Text;
            string lampiran = Lampiran.Text;
            string tanggalkirim = TanggalKirim.Value.ToString("yyyy-MM-dd");
            string uploadDirectory = @Path.Combine(Application.StartupPath, "surat_keluar");

            DatabaseConnector DB = new DatabaseConnector();
            string query = "INSERT INTO surat_keluar (no_surat, perihal, tgl_kirim, tgl_surat, lampiran, tembusan, kepada) VALUES (@no_surat, @perihal, @tgl_kirim, @tgl_surat, @lampiran, @tembusan, @kepada);";

            string filename = nosurat + Path.GetExtension(this.filePath);

            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@no_surat", nosurat);
            command.Parameters.AddWithValue("@perihal", perihal);
            command.Parameters.AddWithValue("@tgl_kirim", tanggalkirim);
            command.Parameters.AddWithValue("@tgl_surat", tanggalsurat);
            command.Parameters.AddWithValue("@lampiran", filename);
            command.Parameters.AddWithValue("@tembusan", tembusan);
            command.Parameters.AddWithValue("@kepada", kepada);

            try
            {
                if (!Directory.Exists(uploadDirectory)) Directory.CreateDirectory(uploadDirectory);
                File.Copy(@filePath, Path.Combine(uploadDirectory, filename));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DB.Connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("Berhasil membuat surat keluar");
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

            //cari 
        private void CariBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.filePath = ofd.FileName;
                Lampiran.Text = Path.GetFileName(filePath);
            }
        }

        private void SuratKeluar_Load(object sender, EventArgs e)
        {

        }
    }

        
    }
