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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void BtnClientsList_Click(object sender, EventArgs e)
        {
            ClientDataBase cdb = new ClientDataBase();
            cdb.Show();
            this.Hide();
        }

        private void BtnRepairList_Click(object sender, EventArgs e)
        {
            RepairLineDataBase rldb = new RepairLineDataBase();
            rldb.Show();
            this.Hide();
        }

        private void BtnOrderList_Click(object sender, EventArgs e)
        {
            UpdateStock us = new UpdateStock();
            us.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
