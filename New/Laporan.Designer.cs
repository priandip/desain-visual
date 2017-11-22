namespace New
{
    partial class Laporan
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataViewer = new System.Windows.Forms.DataGridView();
            this.TanggalArsip = new System.Windows.Forms.DateTimePicker();
            this.CariBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Arsip";
            // 
            // DataViewer
            // 
            this.DataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewer.Location = new System.Drawing.Point(14, 125);
            this.DataViewer.Name = "DataViewer";
            this.DataViewer.Size = new System.Drawing.Size(583, 223);
            this.DataViewer.TabIndex = 1;
            // 
            // TanggalArsip
            // 
            this.TanggalArsip.Location = new System.Drawing.Point(146, 71);
            this.TanggalArsip.Name = "TanggalArsip";
            this.TanggalArsip.Size = new System.Drawing.Size(200, 20);
            this.TanggalArsip.TabIndex = 2;
            // 
            // CariBtn
            // 
            this.CariBtn.BackColor = System.Drawing.Color.Black;
            this.CariBtn.FlatAppearance.BorderSize = 0;
            this.CariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CariBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariBtn.ForeColor = System.Drawing.Color.White;
            this.CariBtn.Location = new System.Drawing.Point(366, 71);
            this.CariBtn.Name = "CariBtn";
            this.CariBtn.Size = new System.Drawing.Size(75, 23);
            this.CariBtn.TabIndex = 3;
            this.CariBtn.Text = "Cari";
            this.CariBtn.UseVisualStyleBackColor = false;
            this.CariBtn.Click += new System.EventHandler(this.CariBtn_Click);
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CariBtn);
            this.Controls.Add(this.TanggalArsip);
            this.Controls.Add(this.DataViewer);
            this.Controls.Add(this.label1);
            this.Name = "Laporan";
            this.Size = new System.Drawing.Size(622, 406);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataViewer;
        private System.Windows.Forms.DateTimePicker TanggalArsip;
        private System.Windows.Forms.Button CariBtn;
    }
}
