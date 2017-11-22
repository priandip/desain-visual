namespace New
{
    partial class SuratMasuk
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CariBtn = new System.Windows.Forms.Button();
            this.TanggalSurat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Pengirim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NoSurat = new System.Windows.Forms.TextBox();
            this.Perihal = new System.Windows.Forms.TextBox();
            this.Lampiran = new System.Windows.Forms.TextBox();
            this.TanggalTerima = new System.Windows.Forms.DateTimePicker();
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CariBtn
            // 
            this.CariBtn.BackColor = System.Drawing.Color.Black;
            this.CariBtn.FlatAppearance.BorderSize = 0;
            this.CariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CariBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariBtn.ForeColor = System.Drawing.Color.White;
            this.CariBtn.Location = new System.Drawing.Point(363, 172);
            this.CariBtn.Name = "CariBtn";
            this.CariBtn.Size = new System.Drawing.Size(75, 23);
            this.CariBtn.TabIndex = 0;
            this.CariBtn.Text = "Cari";
            this.CariBtn.UseVisualStyleBackColor = false;
            this.CariBtn.Click += new System.EventHandler(this.CariBtn_Click);
            // 
            // TanggalSurat
            // 
            this.TanggalSurat.Location = new System.Drawing.Point(145, 120);
            this.TanggalSurat.Name = "TanggalSurat";
            this.TanggalSurat.Size = new System.Drawing.Size(200, 20);
            this.TanggalSurat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pengirim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pengirim
            // 
            this.Pengirim.Location = new System.Drawing.Point(145, 68);
            this.Pengirim.Name = "Pengirim";
            this.Pengirim.Size = new System.Drawing.Size(200, 20);
            this.Pengirim.TabIndex = 3;
            this.Pengirim.TextChanged += new System.EventHandler(this.Pengirim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Surat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal Surat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perihal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lampiran";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Terima";
            // 
            // NoSurat
            // 
            this.NoSurat.Location = new System.Drawing.Point(145, 94);
            this.NoSurat.Name = "NoSurat";
            this.NoSurat.Size = new System.Drawing.Size(200, 20);
            this.NoSurat.TabIndex = 9;
            // 
            // Perihal
            // 
            this.Perihal.Location = new System.Drawing.Point(145, 146);
            this.Perihal.Name = "Perihal";
            this.Perihal.Size = new System.Drawing.Size(200, 20);
            this.Perihal.TabIndex = 10;
            // 
            // Lampiran
            // 
            this.Lampiran.Enabled = false;
            this.Lampiran.Location = new System.Drawing.Point(145, 172);
            this.Lampiran.Name = "Lampiran";
            this.Lampiran.Size = new System.Drawing.Size(200, 20);
            this.Lampiran.TabIndex = 11;
            // 
            // TanggalTerima
            // 
            this.TanggalTerima.Location = new System.Drawing.Point(145, 198);
            this.TanggalTerima.Name = "TanggalTerima";
            this.TanggalTerima.Size = new System.Drawing.Size(200, 20);
            this.TanggalTerima.TabIndex = 12;
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.BackColor = System.Drawing.Color.Black;
            this.SimpanBtn.FlatAppearance.BorderSize = 0;
            this.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimpanBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpanBtn.ForeColor = System.Drawing.Color.White;
            this.SimpanBtn.Location = new System.Drawing.Point(145, 249);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(75, 23);
            this.SimpanBtn.TabIndex = 13;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = false;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // HapusBtn
            // 
            this.HapusBtn.BackColor = System.Drawing.Color.Black;
            this.HapusBtn.FlatAppearance.BorderSize = 0;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusBtn.ForeColor = System.Drawing.Color.White;
            this.HapusBtn.Location = new System.Drawing.Point(270, 249);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(75, 23);
            this.HapusBtn.TabIndex = 14;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Surat Masuk";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SuratMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HapusBtn);
            this.Controls.Add(this.SimpanBtn);
            this.Controls.Add(this.TanggalTerima);
            this.Controls.Add(this.Lampiran);
            this.Controls.Add(this.Perihal);
            this.Controls.Add(this.NoSurat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pengirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TanggalSurat);
            this.Controls.Add(this.CariBtn);
            this.Name = "SuratMasuk";
            this.Size = new System.Drawing.Size(622, 406);
            this.Load += new System.EventHandler(this.SuratMasuk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CariBtn;
        private System.Windows.Forms.DateTimePicker TanggalSurat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pengirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NoSurat;
        private System.Windows.Forms.TextBox Perihal;
        private System.Windows.Forms.TextBox Lampiran;
        private System.Windows.Forms.DateTimePicker TanggalTerima;
        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Button HapusBtn;
        private System.Windows.Forms.Label label7;
    }
}
