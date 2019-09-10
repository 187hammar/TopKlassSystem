using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            String dateDay = DateTime.Today.DayOfWeek.ToString();
            String dateMonth = DateTime.Now.ToString("MMM");
            String time = DateTime.Now.ToString("HH:mm"); ;
            String dateYear = DateTime.Today.Year.ToString();
            String date = dateDay + ", " + dateMonth + ", " + dateYear +", "+time;
            txtOrderDate.Text = date;

            lblOrderNum.Visible = false;
            txtOrderNum.Visible = false;

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
