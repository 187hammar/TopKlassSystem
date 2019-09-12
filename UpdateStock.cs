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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Order.mdf;Integrated Security=True";

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            this.Hide();
            hf.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            stockOrder rw = new stockOrder();
            this.Hide();
            rw.Show();
            rw.lblOrderNum.Visible = true;
            rw.txtOrderNum.Visible = true;
            rw.btnReSubmit.Visible = true;
            rw.btnSubmitOrder.Visible = true;
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewAll = "SELECT * FROM OrderTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "OrderTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "OrderTable";
            conn.Close();
        }
    }
}
