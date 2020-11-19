namespace Admin
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudHargaMenu = new System.Windows.Forms.NumericUpDown();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoMeja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHarian = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHarian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTanggalPenjualan = new System.Windows.Forms.DateTimePicker();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.lblMeja8 = new System.Windows.Forms.Label();
            this.lblMeja7 = new System.Windows.Forms.Label();
            this.lblMeja6 = new System.Windows.Forms.Label();
            this.lblMeja5 = new System.Windows.Forms.Label();
            this.lblMeja4 = new System.Windows.Forms.Label();
            this.lblMeja3 = new System.Windows.Forms.Label();
            this.lblMeja2 = new System.Windows.Forms.Label();
            this.lblMeja1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(450, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 61);
            this.btnDelete.TabIndex = 59;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(450, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 62);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudHargaMenu
            // 
            this.nudHargaMenu.Location = new System.Drawing.Point(411, 96);
            this.nudHargaMenu.Name = "nudHargaMenu";
            this.nudHargaMenu.Size = new System.Drawing.Size(100, 20);
            this.nudHargaMenu.TabIndex = 57;
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(411, 66);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(100, 20);
            this.txtNamaMenu.TabIndex = 56;
            this.txtNamaMenu.Leave += new System.EventHandler(this.txtNamaMenu_Leave);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(411, 123);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 55;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(304, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 53;
            this.label7.Tag = "";
            this.label7.Text = "Tambah/Edit Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Gambar Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Harga Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nama Menu";
            // 
            // lblNoMeja
            // 
            this.lblNoMeja.AutoSize = true;
            this.lblNoMeja.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMeja.Location = new System.Drawing.Point(148, 11);
            this.lblNoMeja.Name = "lblNoMeja";
            this.lblNoMeja.Size = new System.Drawing.Size(0, 24);
            this.lblNoMeja.TabIndex = 49;
            this.lblNoMeja.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 48;
            this.label4.Tag = "";
            this.label4.Text = "Bill Meja";
            // 
            // lblHarian
            // 
            this.lblHarian.AutoSize = true;
            this.lblHarian.BackColor = System.Drawing.Color.Transparent;
            this.lblHarian.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarian.Location = new System.Drawing.Point(646, 300);
            this.lblHarian.Name = "lblHarian";
            this.lblHarian.Size = new System.Drawing.Size(45, 18);
            this.lblHarian.TabIndex = 47;
            this.lblHarian.Text = "label3";
            this.lblHarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 46;
            this.label2.Tag = "";
            this.label2.Text = "Total Penjualan :";
            // 
            // dgvHarian
            // 
            this.dgvHarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarian.Location = new System.Drawing.Point(534, 65);
            this.dgvHarian.Name = "dgvHarian";
            this.dgvHarian.Size = new System.Drawing.Size(256, 229);
            this.dgvHarian.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 44;
            this.label1.Tag = "";
            this.label1.Text = "Rincian Penjualan";
            // 
            // dtpTanggalPenjualan
            // 
            this.dtpTanggalPenjualan.Location = new System.Drawing.Point(534, 39);
            this.dtpTanggalPenjualan.Name = "dtpTanggalPenjualan";
            this.dtpTanggalPenjualan.Size = new System.Drawing.Size(193, 20);
            this.dtpTanggalPenjualan.TabIndex = 43;
            this.dtpTanggalPenjualan.ValueChanged += new System.EventHandler(this.dtpTanggalPenjualan_ValueChanged);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.Yellow;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(44, 299);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(232, 26);
            this.btnCetak.TabIndex = 42;
            this.btnCetak.Text = "Cetak Bill";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(44, 42);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.Size = new System.Drawing.Size(232, 251);
            this.dgvPesanan.TabIndex = 41;
            // 
            // lblMeja8
            // 
            this.lblMeja8.BackColor = System.Drawing.Color.Black;
            this.lblMeja8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja8.ForeColor = System.Drawing.Color.White;
            this.lblMeja8.Location = new System.Drawing.Point(2, 285);
            this.lblMeja8.Name = "lblMeja8";
            this.lblMeja8.Size = new System.Drawing.Size(27, 40);
            this.lblMeja8.TabIndex = 38;
            this.lblMeja8.Text = "8";
            this.lblMeja8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja8.Click += new System.EventHandler(this.lblMeja8_Click);
            // 
            // lblMeja7
            // 
            this.lblMeja7.BackColor = System.Drawing.Color.Black;
            this.lblMeja7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja7.ForeColor = System.Drawing.Color.White;
            this.lblMeja7.Location = new System.Drawing.Point(2, 245);
            this.lblMeja7.Name = "lblMeja7";
            this.lblMeja7.Size = new System.Drawing.Size(27, 40);
            this.lblMeja7.TabIndex = 37;
            this.lblMeja7.Text = "7";
            this.lblMeja7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja7.Click += new System.EventHandler(this.lblMeja7_Click);
            // 
            // lblMeja6
            // 
            this.lblMeja6.BackColor = System.Drawing.Color.Black;
            this.lblMeja6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja6.ForeColor = System.Drawing.Color.White;
            this.lblMeja6.Location = new System.Drawing.Point(2, 205);
            this.lblMeja6.Name = "lblMeja6";
            this.lblMeja6.Size = new System.Drawing.Size(27, 40);
            this.lblMeja6.TabIndex = 36;
            this.lblMeja6.Text = "6";
            this.lblMeja6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja6.Click += new System.EventHandler(this.lblMeja6_Click);
            // 
            // lblMeja5
            // 
            this.lblMeja5.BackColor = System.Drawing.Color.Black;
            this.lblMeja5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja5.ForeColor = System.Drawing.Color.White;
            this.lblMeja5.Location = new System.Drawing.Point(2, 165);
            this.lblMeja5.Name = "lblMeja5";
            this.lblMeja5.Size = new System.Drawing.Size(27, 40);
            this.lblMeja5.TabIndex = 35;
            this.lblMeja5.Text = "5";
            this.lblMeja5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja5.Click += new System.EventHandler(this.lblMeja5_Click);
            // 
            // lblMeja4
            // 
            this.lblMeja4.BackColor = System.Drawing.Color.Black;
            this.lblMeja4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja4.ForeColor = System.Drawing.Color.White;
            this.lblMeja4.Location = new System.Drawing.Point(2, 125);
            this.lblMeja4.Name = "lblMeja4";
            this.lblMeja4.Size = new System.Drawing.Size(27, 40);
            this.lblMeja4.TabIndex = 34;
            this.lblMeja4.Text = "4";
            this.lblMeja4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja4.Click += new System.EventHandler(this.lblMeja4_Click);
            // 
            // lblMeja3
            // 
            this.lblMeja3.BackColor = System.Drawing.Color.Black;
            this.lblMeja3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja3.ForeColor = System.Drawing.Color.White;
            this.lblMeja3.Location = new System.Drawing.Point(2, 85);
            this.lblMeja3.Name = "lblMeja3";
            this.lblMeja3.Size = new System.Drawing.Size(27, 40);
            this.lblMeja3.TabIndex = 33;
            this.lblMeja3.Text = "3";
            this.lblMeja3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja3.Click += new System.EventHandler(this.lblMeja3_Click);
            // 
            // lblMeja2
            // 
            this.lblMeja2.BackColor = System.Drawing.Color.Black;
            this.lblMeja2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja2.ForeColor = System.Drawing.Color.White;
            this.lblMeja2.Location = new System.Drawing.Point(2, 45);
            this.lblMeja2.Name = "lblMeja2";
            this.lblMeja2.Size = new System.Drawing.Size(27, 40);
            this.lblMeja2.TabIndex = 32;
            this.lblMeja2.Text = "2";
            this.lblMeja2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja2.Click += new System.EventHandler(this.lblMeja2_Click);
            // 
            // lblMeja1
            // 
            this.lblMeja1.BackColor = System.Drawing.Color.Black;
            this.lblMeja1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja1.ForeColor = System.Drawing.Color.White;
            this.lblMeja1.Location = new System.Drawing.Point(2, 5);
            this.lblMeja1.Name = "lblMeja1";
            this.lblMeja1.Size = new System.Drawing.Size(27, 40);
            this.lblMeja1.TabIndex = 31;
            this.lblMeja1.Text = "1";
            this.lblMeja1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMeja1.Click += new System.EventHandler(this.lblMeja1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(802, 332);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudHargaMenu);
            this.Controls.Add(this.txtNamaMenu);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoMeja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHarian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHarian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTanggalPenjualan);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.lblMeja8);
            this.Controls.Add(this.lblMeja7);
            this.Controls.Add(this.lblMeja6);
            this.Controls.Add(this.lblMeja5);
            this.Controls.Add(this.lblMeja4);
            this.Controls.Add(this.lblMeja3);
            this.Controls.Add(this.lblMeja2);
            this.Controls.Add(this.lblMeja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudHargaMenu;
        private System.Windows.Forms.TextBox txtNamaMenu;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoMeja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHarian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHarian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTanggalPenjualan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label lblMeja8;
        private System.Windows.Forms.Label lblMeja7;
        private System.Windows.Forms.Label lblMeja6;
        private System.Windows.Forms.Label lblMeja5;
        private System.Windows.Forms.Label lblMeja4;
        private System.Windows.Forms.Label lblMeja3;
        private System.Windows.Forms.Label lblMeja2;
        private System.Windows.Forms.Label lblMeja1;
    }
}

