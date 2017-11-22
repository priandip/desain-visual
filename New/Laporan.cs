using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace New
{
    public partial class Laporan : UserControl
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void CariBtn_Click(object sender, EventArgs e)
        {
            string tanggalArsip = TanggalArsip.Value.ToString("yyyy-MM-dd");

            DatabaseConnector DB = new DatabaseConnector();
            string query = "SELECT * FROM arsip where tgl_arsip BETWEEN @tanggal_mulai AND NOW()";

            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@tanggal_mulai", tanggalArsip);

            try
            {
                DB.Connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                DataViewer.ColumnCount = 5;
                DataViewer.Columns[0].Name = "no_arsip";
                DataViewer.Columns[1].Name = "no_surat";
                DataViewer.Columns[2].Name = "lokasi_arsip";
                DataViewer.Columns[3].Name = "keterangan";
                DataViewer.Columns[4].Name = "tgl_arsip";


                List<string> row = new List<string>();
                while (reader.Read())
                {
                    row.Add(reader["no_arsip"].ToString());
                    row.Add(reader["no_surat"].ToString());
                    row.Add(reader["lokasi_arsip"].ToString());
                    row.Add(reader["keterangan"].ToString());
                    row.Add(reader["tgl_arsip"].ToString());
                    DataViewer.Rows.Add(row.ToArray());
                    row.Clear();
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.Connection.Close();
            }
        }

        private void Laporan_Load(object sender, EventArgs e)
        {

        }
    }
}
