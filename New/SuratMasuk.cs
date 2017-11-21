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
    public partial class SuratMasuk : UserControl
    {
        private string filePath;

        public SuratMasuk()
        {
            InitializeComponent();
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            string pengirim = Pengirim.Text;
            string noSurat = NoSurat.Text;
            string tanggalSurat = TanggalSurat.Value.ToString("yyyy-MM-dd");
            string perihal = Perihal.Text;
            string lampiran = filePath;
            string tanggalTerima = TanggalTerima.Value.ToString("yyyy-MM-dd");
            string uploadDirectory = Path.Combine(Application.StartupPath, "surat");

            DatabaseConnector DB = new DatabaseConnector();
            string query = "INSERT INTO surat_masuk (no_surat, perihal, pengirim, tgl_surat, tgl_terima, lampiran) VALUES (@no_surat, @perihal, @pengirim, @tgl_surat, @tgl_terima, @lampiran);";

            string filename = noSurat + Path.GetExtension(lampiran);

            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@no_surat", noSurat);
            command.Parameters.AddWithValue("@perihal", perihal);
            command.Parameters.AddWithValue("@pengirim", pengirim);
            command.Parameters.AddWithValue("@tgl_surat", tanggalSurat);
            command.Parameters.AddWithValue("@tgl_terima", tanggalTerima);
            command.Parameters.AddWithValue("@lampiran", filename);

            try
            {
                File.Copy(lampiran, Path.Combine(uploadDirectory, filename));
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
                    MessageBox.Show("Berhasil membuat surat masuk");
                }
            }
            catch (MySqlException ex)
            {
                if(ex.Number == 1062)
                {
                    MessageBox.Show("Ada record dengan nomor surat yang sama");
                }
            }
            finally
            {
                DB.Connection.Close();
            }

            if (!Directory.Exists(uploadDirectory)) Directory.CreateDirectory(uploadDirectory);

            

        }

        private void CariBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.filePath = ofd.FileName;
                Lampiran.Text = Path.GetFileName(filePath);
            }
        }

        private void NoSurat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}