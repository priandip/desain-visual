using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel.Controls.Clear();
            panel.Controls.Add(new SuratMasuk());
        }

        private void SuratMasukBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new SuratMasuk());
        }

        private void SuratKeluarBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new SuratKeluar());
        }

        private void ArsipBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new Arsip());
        }

        private void LaporanBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new Laporan());
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
