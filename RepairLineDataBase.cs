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
    public partial class RepairLineDataBase : Form
    {
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
    }
}
