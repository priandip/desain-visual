namespace New
{
    partial class Arsip
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
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NoArsip = new System.Windows.Forms.TextBox();
            this.TangalArsip = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoSurat = new System.Windows.Forms.TextBox();
            this.LokasiArsip = new System.Windows.Forms.TextBox();
            this.Keterangan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.BackColor = System.Drawing.Color.Black;
            this.SimpanBtn.FlatAppearance.BorderSize = 0;
            this.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimpanBtn.ForeColor = System.Drawing.Color.White;
            this.SimpanBtn.Location = new System.Drawing.Point(138, 227);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(75, 23);
            this.SimpanBtn.TabIndex = 0;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = false;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Arsip";
            // 
            // NoArsip
            // 
            this.NoArsip.Location = new System.Drawing.Point(138, 70);
            this.NoArsip.Name = "NoArsip";
            this.NoArsip.Size = new System.Drawing.Size(200, 20);
            this.NoArsip.TabIndex = 2;
            this.NoArsip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TangalArsip
            // 
            this.TangalArsip.Location = new System.Drawing.Point(138, 175);
            this.TangalArsip.Name = "TangalArsip";
            this.TangalArsip.Size = new System.Drawing.Size(200, 20);
            this.TangalArsip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Surat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lokasi Arsip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Keterangan";
            // 
            // NoSurat
            // 
            this.NoSurat.Location = new System.Drawing.Point(138, 96);
            this.NoSurat.Name = "NoSurat";
            this.NoSurat.Size = new System.Drawing.Size(200, 20);
            this.NoSurat.TabIndex = 8;
            // 
            // LokasiArsip
            // 
            this.LokasiArsip.Location = new System.Drawing.Point(138, 122);
            this.LokasiArsip.Name = "LokasiArsip";
            this.LokasiArsip.Size = new System.Drawing.Size(200, 20);
            this.LokasiArsip.TabIndex = 9;
            // 
            // Keterangan
            // 
            this.Keterangan.Location = new System.Drawing.Point(138, 150);
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Size = new System.Drawing.Size(200, 20);
            this.Keterangan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanggal Arsip";
            // 
            // HapusBtn
            // 
            this.HapusBtn.BackColor = System.Drawing.Color.Black;
            this.HapusBtn.FlatAppearance.BorderSize = 0;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.ForeColor = System.Drawing.Color.White;
            this.HapusBtn.Location = new System.Drawing.Point(263, 227);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(75, 23);
            this.HapusBtn.TabIndex = 11;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = false;
            // 
            // Arsip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HapusBtn);
            this.Controls.Add(this.Keterangan);
            this.Controls.Add(this.LokasiArsip);
            this.Controls.Add(this.NoSurat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TangalArsip);
            this.Controls.Add(this.NoArsip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimpanBtn);
            this.Name = "Arsip";
            this.Size = new System.Drawing.Size(622, 406);
            this.Load += new System.EventHandler(this.Arsip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoArsip;
        private System.Windows.Forms.DateTimePicker TangalArsip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoSurat;
        private System.Windows.Forms.TextBox LokasiArsip;
        private System.Windows.Forms.TextBox Keterangan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HapusBtn;
    }
}
