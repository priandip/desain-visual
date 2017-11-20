using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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


        }
    }
}
x