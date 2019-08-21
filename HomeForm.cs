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
            RepairOrder ro = new RepairOrder();
            ro.Show();
        }
    }
}
