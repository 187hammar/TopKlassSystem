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
    public partial class RepairLineDataBase : Form
    {
        string conStringRepair = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Repair.mdf;Integrated Security=True";
        public RepairLineDataBase()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepairLineDataBase_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStringRepair);
            conn.Open();
            string viewAll = "SELECT * FROM RepairTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            SqlDataAdapter adp = new SqlDataAdapter();

            DataSet ds = new DataSet();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "RepairTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RepairTable";
            conn.Close();
        }

        public void refreshDatabase()
        {
            SqlConnection conn = new SqlConnection(conStringRepair);
            conn.Open();
            string viewAll = "SELECT * FROM RepairTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            SqlDataAdapter adp = new SqlDataAdapter();

            DataSet ds = new DataSet();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "RepairTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RepairTable";
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStringRepair);
                conn.Open();
                string Sqldel = @"DELETE FROM RepairTable WHERE RepairId ='" + txtRepair.Text + "'";
                SqlCommand cmd = new SqlCommand(Sqldel, conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adp.DeleteCommand = cmd;
                adp.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Successful");
                txtRepair.Text = "";
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
