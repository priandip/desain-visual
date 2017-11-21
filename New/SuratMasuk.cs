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
        public SuratMasuk()
        {
            InitializeComponent();
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            string dari = Dari.Text;
            string noSurat = NoSurat.Text;
            string tanggalSurat = TanggalSurat.Value.ToString("yyyy-MM-dd");
            string perihal = Perihal.Text;
            string lampiran = Lampiran.Text;
            string tanggalTerima = TanggalTerima.Value.ToString("yyyy-MM-dd");
            string uploadDirectory = Path.Combine(Application.StartupPath, "surat");

            DatabaseConnector DB = new DatabaseConnector();
            string query = "INSERT INTO surat_masuk (no_surat, perihal, tgl_surat, tgl_terima) VALUES (@no_surat, @perihal, @tgl_surat, @tgl_terima)";
            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@no_surat", noSurat);
            command.Parameters.AddWithValue("@perihal", perihal);
            command.Parameters.AddWithValue("@tgl_surat", tanggalSurat);
            command.Parameters.AddWithValue("@tgl_terima", tanggalTerima);

            if (!Directory.Exists(uploadDirectory)) Directory.CreateDirectory(uploadDirectory);

            string filename = noSurat + Path.GetExtension(lampiran);

            File.Copy(lampiran, Path.Combine(uploadDirectory, filename));

        }

        private void CariBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Lampiran.Text = ofd.FileName;
            }
        }

        private void SuratMasuk_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}