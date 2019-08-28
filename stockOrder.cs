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
    public partial class stockOrder : Form
    {
        public stockOrder()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSpareName.Text = cmbParts.SelectedItem.ToString();
        }

        private void StockOrder_Load(object sender, EventArgs e)
        {
            //Order Date Should be Automatic upon form load
            String date = DateTime.Today.ToString();
            txtOrderDate.Text = date;
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
