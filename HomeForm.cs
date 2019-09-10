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
    public partial class HomeForm : Form
    {
        string conStrCellphone = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Cellphones.mdf;Integrated Security = True";
        string conStrClients = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Clients.mdf;Integrated Security=True";
        string conStrModel = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Model.mdf;Integrated Security=True";
        string conStrOrder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Order.mdf;Integrated Security=True";
        string conStrRepair = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Repair.mdf;Integrated Security=True";
        string conStrSupplier = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Suppliers.mdf;Integrated Security=True";
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
        }

        private void UpdateRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Same window as the add repair window, difference is listBox with Client name and Phone model previewed
            RepairLineDataBase child2 = new RepairLineDataBase();
            child2.MdiParent = this;
            child2.Show();
        }

        private void RepairLineupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairLineDataBase child3 = new RepairLineDataBase();
            child3.MdiParent = this;
            child3.Show();

        }

        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockOrder child4 = new stockOrder();
            child4.MdiParent = this;
            child4.Show();
            child4.lblTotaltxt.Visible = false;
            child4.lblRecievedDate.Visible = false;
            child4.txtRecievedDate.Visible = false;
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

        private void PhoneDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneDataBase child6 = new PhoneDataBase();
            child6.MdiParent = this;
            conn = new SqlConnection(conStrCellphone);
            conn.Open();
            string viewAll = "SELECT * FROM CellphoneTable";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "Cellphones");

            child6.dataGridView1.DataSource = ds;
            child6.dataGridView1.DataMember = "Cellphones";
            conn.Close();
            child6.Show();
        }

        private void ClientsDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDataBase child6 = new ClientDataBase();
            child6.MdiParent = this;
            conn = new SqlConnection(conStrClients);
            conn.Open();
            string viewAll = "SELECT * FROM ClientInfo";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "Clients");

            child6.dataGridView1.DataSource = ds;
            child6.dataGridView1.DataMember = "Clients";
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
    }
}
