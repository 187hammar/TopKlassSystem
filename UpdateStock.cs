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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
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
            RepairWindow rw = new RepairWindow();
            this.Hide();
            rw.Show();
            rw.lblClientName.Visible = true;
            rw.cbxClients.Visible = true;
        }
    }
}
