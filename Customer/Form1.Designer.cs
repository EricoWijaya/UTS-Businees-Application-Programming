namespace Customer
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvTop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxNomor = new System.Windows.Forms.ComboBox();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Freehand521 BT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(388, 468);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 25);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Freehand521 BT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total Harga :";
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(12, 43);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(242, 332);
            this.dgvMenu.TabIndex = 17;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // dgvTop
            // 
            this.dgvTop.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop.Location = new System.Drawing.Point(439, 82);
            this.dgvTop.MultiSelect = false;
            this.dgvTop.Name = "dgvTop";
            this.dgvTop.ReadOnly = true;
            this.dgvTop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTop.Size = new System.Drawing.Size(243, 137);
            this.dgvTop.TabIndex = 25;
            this.dgvTop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTop_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freehand521 BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Freehand521 BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Top Seller";
            // 
            // cmbbxNomor
            // 
            this.cmbbxNomor.FormattingEnabled = true;
            this.cmbbxNomor.Location = new System.Drawing.Point(560, 18);
            this.cmbbxNomor.Name = "cmbbxNomor";
            this.cmbbxNomor.Size = new System.Drawing.Size(52, 21);
            this.cmbbxNomor.TabIndex = 23;
            this.cmbbxNomor.SelectedIndexChanged += new System.EventHandler(this.cmbbxNomor_SelectedIndexChanged);
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.btnOrder);
            this.grpbxPesan.Controls.Add(this.nudJumlah);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(271, 43);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 176);
            this.grpbxPesan.TabIndex = 22;
            this.grpbxPesan.TabStop = false;
            this.grpbxPesan.Text = "Pesanan";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Gold;
            this.btnOrder.Font = new System.Drawing.Font("Castellar", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(24, 116);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 39);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(24, 59);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(100, 20);
            this.nudJumlah.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freehand521 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(573, 465);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(109, 43);
            this.btnBill.TabIndex = 20;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exotc350 DmBd BT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nomor Meja";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(271, 225);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(411, 234);
            this.dgvOrder.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(69, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(700, 518);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.dgvTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbbxNomor);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridView dgvTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxNomor;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

