using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopKlassSystem
{
    public partial class HomeForm : Form
    {
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
            UpdateStock child2 = new UpdateStock();
            child2.MdiParent = this;
            child2.Show();
        }

        private void RepairLineupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineUp child3 = new LineUp();
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
            stockOrder child5 = new stockOrder();
            child5.MdiParent = this;
            child5.Show();
            child5.lblTotaltxt.Visible = true;
            child5.lblRecievedDate.Visible = true;
            child5.txtRecievedDate.Visible = true;
        }

        private void PlaceRepairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StockDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStock child6 = new UpdateStock();
            child6.MdiParent = this;
            child6.Show();
        }

        private void PhoneDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneDataBase child6 = new PhoneDataBase();
            child6.MdiParent = this;
            child6.Show();
        }

        private void ClientsDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDataBase child6 = new ClientDataBase();
            child6.MdiParent = this;
            child6.Show();
        }

        private void RepairDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepairLineDataBase child6 = new RepairLineDataBase();
            child6.MdiParent = this;
            child6.Show();
        }
    }
}
