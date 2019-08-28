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
            RepairWindow child2 = new RepairWindow();
            child2.MdiParent = this;
            child2.Show();
            child2.cbxClients.Visible = true;
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
    }
}
