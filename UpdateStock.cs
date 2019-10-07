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

namespace TopKlassSystem
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Order.mdf;Integrated Security=True";

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewAll = "SELECT * FROM OrderTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "OrderTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "OrderTable";
            conn.Close();
        }

        public void refreshDatabase()
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewAll = "SELECT * FROM OrderTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "OrderTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "OrderTable";
            conn.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string Sqldel = @"DELETE FROM OrderTable WHERE OrderId ='" + txtOrderId.Text + "'";
                SqlCommand cmd = new SqlCommand(Sqldel, conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adp.DeleteCommand = cmd;
                adp.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Successful");
                txtOrderId.Text = "";
                refreshDatabase();
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
