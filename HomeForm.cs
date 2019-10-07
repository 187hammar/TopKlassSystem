using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Net;
using System.Net.Mail;

using System.Data.SqlClient;


namespace TopKlassSystem
{
    public partial class HomeForm : Form
    {
        string conStrClients = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Clients.mdf;Integrated Security=True";
        string conStrOrder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Order.mdf;Integrated Security=True";
        string conStrRepair = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Repair.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void AddClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlaceRepairOrder_Click(object sender, EventArgs e)
        {

        }

        private void AddRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairWindow child1 = new RepairWindow();
            child1.MdiParent = this;
            child1.Show();
            child1.cbxClients.Visible = false;
            child1.lblClientName.Visible = false;
        }

        private void UpdateRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Same window as the add repair window, difference is listBox with Client name and Phone model previewed
            RepairLineDataBase child2 = new RepairLineDataBase();
            child2.MdiParent = this;
            child2.Show();
        }

        

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockOrder child4 = new stockOrder();
            child4.MdiParent = this;
            child4.Show();
            child4.lblRecievedDate.Visible = false;
            child4.txtRecievedDate.Visible = false;
            child4.btnSubmitOrder.Visible = true;
            child4.btnReSubmit.Visible = true;
        }

        private void UpdateStockOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStock child5 = new UpdateStock();
            child5.MdiParent = this;
            child5.Show();
        }

        private void PlaceRepairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StockDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStock child6 = new UpdateStock();
            child6.MdiParent = this;
            conn = new SqlConnection(conStrOrder);
            conn.Open();
            string viewAll = "SELECT * FROM OrderTable";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "Order");

            child6.dataGridView1.DataSource = ds;
            child6.dataGridView1.DataMember = "Order";
            conn.Close();
            child6.Show();
        }

        private void ClientsDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDataBase child6 = new ClientDataBase();
            child6.MdiParent = this;
            conn = new SqlConnection(conStrClients);
            conn.Open();
            string viewAll = "SELECT * FROM ClientTable";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "ClientTable");

            child6.dataGridView1.DataSource = ds;
            child6.dataGridView1.DataMember = "ClientTable";
            conn.Close();
            child6.Show();
        }

        private void RepairDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairLineDataBase child6 = new RepairLineDataBase();
            child6.MdiParent = this;
            conn = new SqlConnection(conStrRepair);
            conn.Open();
            string viewAll = "SELECT * FROM RepairTable";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "Repair");

            child6.dataGridView1.DataSource = ds;
            child6.dataGridView1.DataMember = "Repair";
            conn.Close();
            child6.Show();
        }

        private void UpdateClientsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDataBase child7 = new ClientDataBase();
            child7.MdiParent = this;
            child7.Show();
        }

        private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report child8 = new Report();
            SqlConnection conn1 = new SqlConnection(conStrClients);
            SqlConnection conn2 = new SqlConnection(conStrOrder);
            SqlConnection conn3 = new SqlConnection(conStrRepair);
            conn1.Open();
            conn2.Open();
            conn3.Open();
            string viewClients = "SELECT * FROM ClientTable";
            string viewOrder = "SELECT * FROM OrderTable";
            string viewRepair = "SELECT * FROM RepairTable";
            SqlCommand cmd1 = new SqlCommand(viewClients, conn1);
            SqlCommand cmd2 = new SqlCommand(viewOrder, conn2);
            SqlCommand cmd3 = new SqlCommand(viewRepair, conn3);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd1;
            adp.Fill(ds, "ClientTable");
            SqlDataAdapter adp2 = new SqlDataAdapter();
            DataSet ds2 = new DataSet();
            adp.SelectCommand = cmd2;
            adp.Fill(ds2, "ClientTable");
            SqlDataAdapter adp3 = new SqlDataAdapter();
            DataSet ds3 = new DataSet();
            adp.SelectCommand = cmd3;
            adp.Fill(ds3, "ClientTable");

            child8.dataGridView1.DataSource = ds;
            child8.dataGridView1.DataMember = "ClientTable";
            child8.dataGridView2.DataSource = ds2;
            child8.dataGridView2.DataMember = "ClientTable";
            child8.dataGridView3.DataSource = ds3;
            child8.dataGridView3.DataMember = "ClientTable";
            conn1.Close();
            conn2.Close();
            conn3.Close();
            child8.MdiParent = this;
            child8.Show();
            
        }

        

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
