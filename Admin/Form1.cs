using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public int total = 0;
        public string dir;
        public Form1()
        {
            InitializeComponent();

            nudHargaMenu.Minimum = 20000;
            nudHargaMenu.Maximum = 400000;
            nudHargaMenu.Increment = 2000;
            btnCetak.Enabled = false;
            lblHarian.Text = "";

            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            lblMeja1.BackColor = Color.Black;
            lblMeja2.BackColor = Color.Black;
            lblMeja3.BackColor = Color.Black;
            lblMeja4.BackColor = Color.Black;
            lblMeja5.BackColor = Color.Black;
            lblMeja6.BackColor = Color.Black;
            lblMeja7.BackColor = Color.Black;
            lblMeja8.BackColor = Color.Black;
            
            cmd = new SqlCommand("select TableNum from Meja where flag = 1 group by TableNum", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string temp = reader[0].ToString();
                    if (temp == "1")
                        lblMeja1.BackColor = Color.Red;
                    else if (temp == "2")
                        lblMeja2.BackColor = Color.Red;
                    else if (temp == "3")
                        lblMeja3.BackColor = Color.Red;
                    else if (temp == "4")
                        lblMeja4.BackColor = Color.Red;
                    else if (temp == "5")
                        lblMeja5.BackColor = Color.Red;
                    else if (temp == "6")
                        lblMeja6.BackColor = Color.Red;
                    else if (temp == "7")
                        lblMeja7.BackColor = Color.Red;
                    else if (temp == "8")
                        lblMeja8.BackColor = Color.Red;
                }
            reader.Close();
        }

        private void lblMeja1_Click(object sender, EventArgs e)
        {
            TampilBill("1", lblMeja1.BackColor);
        }

        private void lblMeja2_Click(object sender, EventArgs e)
        {
            TampilBill("2", lblMeja2.BackColor);
        }

        private void lblMeja3_Click(object sender, EventArgs e)
        {
            TampilBill("3", lblMeja3.BackColor);
        }

        private void lblMeja4_Click(object sender, EventArgs e)
        {
            TampilBill("4", lblMeja4.BackColor);
        }
        private void lblMeja5_Click(object sender, EventArgs e)
        {
            TampilBill("5", lblMeja5.BackColor);
        }
        private void lblMeja6_Click(object sender, EventArgs e)
        {
            TampilBill("6", lblMeja6.BackColor);
        }
        private void lblMeja7_Click(object sender, EventArgs e)
        {
            TampilBill("7", lblMeja7.BackColor);
        }
        private void lblMeja8_Click(object sender, EventArgs e)
        {
            TampilBill("8", lblMeja8.BackColor);
        }
        public void TampilBill(string noMeja, Color bg)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total, Tanggal from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = {noMeja}", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            dgvPesanan.DataSource = ds.Tables["Menu"];
            lblNoMeja.Text = noMeja;
            if (bg == Color.Red)
                btnCetak.Enabled = true;
            else
                btnCetak.Enabled = false;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dgvPesanan.Rows.Count > 1)
            {
                total = 0;

                for (int i = 0; i < dgvPesanan.Rows.Count; i++)
                    total += Convert.ToInt32(dgvPesanan.Rows[i].Cells[3].Value);

                string sql = String.Format("insert into Admin values('{0}',convert(varchar,cast({1} as money)),'{2}')", lblNoMeja.Text, total, DateTimeOffset.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                PrintPreviewDialog ppd1 = new PrintPreviewDialog();
                ppd1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("tes", 285, 600);
                ppd1.ShowDialog();

                sql = String.Format("Update Meja set flag = 0 where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = String.Format("Delete from Meja where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                dgvPesanan.DataSource = null;

                Form1_Load(null, null);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Ric's Fancy", new Font("Lucida Calligraphy", 20, FontStyle.Bold), Brushes.Black, new Point(50, 10));
            e.Graphics.DrawLine(Pens.Black, new Point(0, 50), new Point(285, 50));
            e.Graphics.DrawString($"{DateTimeOffset.Now.ToString("dd MMM yyyy hh:mm:ss")}", new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(60, 60));

            string sql = String.Format("select m.NamaMenu,Qty, (HargaMenu * Qty) from Meja m inner join Menu n on m.NamaMenu = n.NamaMenu where TableNum = '{0}'", lblNoMeja.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int a = 0, b = 120;
            e.Graphics.DrawString("Menu", new Font("Consolas", 7, FontStyle.Bold), Brushes.Black, new Point(30, 90));
            e.Graphics.DrawString("@", new Font("Consolas", 7, FontStyle.Bold), Brushes.Black, new Point(120, 90));
            e.Graphics.DrawString("Total Harga", new Font("Consolas", 7, FontStyle.Bold), Brushes.Black, new Point(150, 90));
            while (reader.Read())
            {
                e.Graphics.DrawString($"{reader[0].ToString()}", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(30, b + a));
                e.Graphics.DrawString($"{reader[1].ToString()}", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(120, b + a));
                e.Graphics.DrawString($"Rp.{reader[2].ToString()}", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(150, b + a));
                a += 13;
            }
            e.Graphics.DrawString($"Total ....... Rp.{total.ToString()}", new Font("Consolas", 10, FontStyle.Bold), Brushes.Black, new Point(55, b + a + 20));
            e.Graphics.DrawString("Thank you", new Font("Consolas", 30, FontStyle.Bold), Brushes.Black, new Point(25, b + a + 50));
            reader.Close();
        }

        private void dtpTanggalPenjualan_ValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select * from Admin where Tanggal = '{dtpTanggalPenjualan.Value.ToString("yyyy/MM/dd")}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rekap");
            dgvHarian.DataSource = ds.Tables["Rekap"];
            int sum = 0;
            for (int i = 0; i < dgvHarian.Rows.Count; i++)
                sum += Convert.ToInt32(dgvHarian.Rows[i].Cells[1].Value);
            lblHarian.Text = $"Rp.{sum:N}";
            if (dgvHarian.Rows.Count < 1)
                dgvHarian.DataSource = null;
        }

        private void txtNamaMenu_Leave(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            string sql = String.Format("select NamaMenu, GambarMenu, HargaMenu from Menu where NamaMenu = '{0}'", txtNamaMenu.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            btnSave.Text = "Save";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nudHargaMenu.Value = Convert.ToDecimal(reader[2]);
                    pictureBox1.Image = Image.FromFile($"{reader[1].ToString()}");
                    dir = reader[1].ToString();
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
            reader.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "All Images|*.jpg;*.png;*.bmp";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                dir = openFileDialog1.FileName.ToString();
                pictureBox1.Image = Image.FromFile(dir);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Update")
            {
                string sql = String.Format("Delete from Menu where NamaMenu = '{0}'", txtNamaMenu.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                reset();
            }

        }

        public void reset()
        {
            btnSave.Text = "Keep";
            txtNamaMenu.Text = "";
            nudHargaMenu.Value = nudHargaMenu.Minimum;
            pictureBox1.Image = null;
            dir = "";
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (btnSave.Text == "Update")
                {
                    string sql = String.Format("update Menu set HargaMenu = convert(money,{0}), GambarMenu = '{1}' where NamaMenu = '{2}'", nudHargaMenu.Value, dir, txtNamaMenu.Text);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    string sql = String.Format("Insert into Menu values('{0}','{1}',convert(money,{2}),0)", txtNamaMenu.Text, dir, nudHargaMenu.Value);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                reset();
            }
        }
    }
}
