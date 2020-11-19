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

namespace Customer
{
    public partial class Form1 : Form
    {
        public string makanan;
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
                cmbbxNomor.Items.Add(i);
            nudJumlah.Minimum = 1;
            nudJumlah.Maximum = 99;


            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();

            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbbxNomor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTop.Enabled = true;
            dgvMenu.Enabled = true;
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{cmbbxNomor.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            dgvOrder.DataSource = ds.Tables["Menu"];
            if (dgvOrder.Rows.Count > 0)
                btnBill.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "0";
            grpbxPesan.Enabled = false;
            dgvMenu.Enabled = false;
            dgvTop.Enabled = false;
            btnBill.Enabled = false;

            cmbbxNomor.Enabled = true;
            dgvMenu.ClearSelection();
            dgvTop.ClearSelection();
            dgvOrder.ClearSelection();
            dgvOrder.DataSource = null;
            pictureBox1.Image = null;

            SqlDataAdapter da = new SqlDataAdapter("select NamaMenu, Cast(HargaMenu as decimal) Harga from Menu", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            dgvMenu.DataSource = ds.Tables["Menu"];

            da = new SqlDataAdapter("select Top 3 NamaMenu, HargaMenu from Menu order by Populer desc", conn);
            ds = new DataSet();
            da.Fill(ds, "Menu");
            dgvTop.DataSource = ds.Tables["Menu"];
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTop.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tampilgambar(makanan);

        }

        public void tampilgambar(string makanan)
        {
            string sql = String.Format("Select GambarMenu from Menu where NamaMenu = '{0}'", makanan);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                pictureBox1.Image = Image.FromFile(reader[0].ToString());
            reader.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnBill.Enabled = true;

            string sql = String.Format("insert into Meja values('{0}','0','{1}','{2}',{3})", cmbbxNomor.SelectedItem, makanan, DateTimeOffset.Now.ToString("yyyy/MM/dd"), nudJumlah.Value);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = '{cmbbxNomor.SelectedItem}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Pesanan");
            dgvOrder.DataSource = ds.Tables["Pesanan"];

            sql = String.Format("Update Menu set Populer += {0} where NamaMenu = '{1}'", nudJumlah.Value, makanan);
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            int total = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
                total += Convert.ToInt32(dgvOrder.Rows[i].Cells[3].Value);
            lblTotal.Text = total.ToString();
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            if (dgvOrder.RowCount > 1)
            {
                MessageBox.Show("Bill Anda sedang Diproses");
                string sql = String.Format("Update Meja set flag = '1' where TableNum = '{0}'", cmbbxNomor.SelectedItem);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Form1_Load(null, null);
            }
        }

        private void dgvTop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMenu.ClearSelection();
            grpbxPesan.Enabled = true;
            makanan = dgvTop.Rows[e.RowIndex].Cells[0].Value.ToString();
            tampilgambar(makanan);
        }
    }
}
