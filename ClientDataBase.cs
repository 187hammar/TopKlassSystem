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
    public partial class ClientDataBase : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Clients.mdf;Integrated Security=True";
        public ClientDataBase()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            RepairWindow rw = new RepairWindow();
            this.Hide();
            rw.txtCellphoneBrand.Enabled = false;
            rw.txtCellphoneModel.Enabled = false;
            rw.txtRepairDesc.Enabled = false;
            rw.txtTotalCost.Enabled = false;
            rw.txtSerialNum.Enabled = false;
            rw.lblClientName.Visible = true;
            rw.cbxClients.Visible = true;
            rw.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewSearch = "SELECT * FROM ClientTable WHERE ClientFName LIKE '"+txtSearch.Text+"%'";
            SqlCommand cmd = new SqlCommand(viewSearch, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "ClientTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ClientTable";
            conn.Close();
        }

        private void ClientDataBase_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewAll = "SELECT * FROM ClientTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "ClientTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ClientTable";
            conn.Close();
        }

        public void refreshDatabase()
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string viewAll = "SELECT * FROM ClientTable";
            SqlCommand cmd = new SqlCommand(viewAll, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "ClientTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ClientTable";
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string Sqldel = @"DELETE FROM ClientTable WHERE ClientID ='" + txtClientsInfo.Text + "'";
                SqlCommand cmd = new SqlCommand(Sqldel, conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();

                adp.DeleteCommand = cmd;
                adp.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Successful");
                txtClientsInfo.Text = "";
                refreshDatabase();
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
