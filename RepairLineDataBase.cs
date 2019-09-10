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
        string conStringModel = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Model.mdf;Integrated Security=True";
        string conStringClient = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Clients.mdf;Integrated Security=True";
        public RepairLineDataBase()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            this.Hide();
            hf.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            RepairWindow rp = new RepairWindow();
            rp.groupBox1.Visible = false;
            this.Hide();

            DataTable dt = new DataTable();
            SqlConnection conn1 = new SqlConnection(conStringRepair);
            SqlConnection conn2 = new SqlConnection(conStringClient);
            string viewRepair = "SELECT * FROM RepairTable";
            string viewModel = "SELECT * FROM ModelTable";
            string viewClient = "SELECT * FROM ClientTable";
            conn1.Open();
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand(viewClient, conn2);
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand(viewRepair, conn1);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd2;
            adp.Fill(ds, "ClientTable");

            rp.cbxClients.DisplayMember = "ClientLName";
            rp.cbxClients.ValueMember = "ClientLName";
            rp.cbxClients.DataSource = ds.Tables["ClientLName"];

            rp.txtRepairDesc.Text = dt.Rows[0]["RepairDescription"].ToString();
            rp.txtTotalCost.Text = dt.Rows[0]["RepairCost"].ToString();
            conn1.Close();
            conn2.Close();
            rp.Show();
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
    }
}
