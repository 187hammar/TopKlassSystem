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
using System.Net;
using System.Net.Mail;

namespace TopKlassSystem
{
    public partial class RepairWindow : Form
    {
        string conStrRepair = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Repair.mdf;Integrated Security=True";
        string conStrModel = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Model.mdf;Integrated Security=True";
        string conStrCellphone = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Cellphones.mdf;Integrated Security=True";
        string conStrClient = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Clients.mdf;Integrated Security=True";
        public RepairWindow()
        {
            InitializeComponent();
        }
        SqlDataAdapter adp;
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneBrand = txtCellphoneBrand.Text;
                string phoneModel = txtCellphoneModel.Text;
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                string eMail = txtEmail.Text;
                string phoneNum = txtPhoneNum.Text;
                string repairDesc = txtRepairDesc.Text;
                string serialNum = txtSerialNum.Text;
                string repairCost = txtTotalCost.Text;
                
                SqlConnection connRepair = new SqlConnection(conStrRepair);
                SqlConnection connModel = new SqlConnection(conStrModel);
                SqlConnection connClients = new SqlConnection(conStrClient);
                SqlConnection connCellphones = new SqlConnection(conStrCellphone);
                string inRepair = "INSERT INTO RepairTable VALUES(@RepairDescription, @RepairCost)";
                string inModel = "INSERT INTO ModelTable VALUES(@ModelBrand, @ModelDescription)";
                string inClients = "INSERT INTO ClientTable VALUES(@ClientFName, @ClientLName, @ClientEmail, @ClientPhoneNumber)";
                string inCell = "INSERT INTO CellphoneTable VALUES(@CellphoneSerialNumber)";
                connRepair.Open();
                connModel.Open();
                connClients.Open();
                connCellphones.Open();
                adp = new SqlDataAdapter();
                SqlCommand cmd1 = new SqlCommand(inRepair, connRepair);
                SqlCommand cmd2 = new SqlCommand(inModel, connModel);
                SqlCommand cmd3 = new SqlCommand(inClients, connClients);
                SqlCommand cmd4 = new SqlCommand(inCell, connCellphones);
                cmd1.Parameters.AddWithValue("@RepairDescription", repairDesc);
                cmd1.Parameters.AddWithValue("@RepairCost", repairCost);
                cmd2.Parameters.AddWithValue("@ModelBrand", phoneBrand);
                cmd2.Parameters.AddWithValue("@ModelDescription", phoneModel);
                cmd3.Parameters.AddWithValue("@ClientFName", fName);
                cmd3.Parameters.AddWithValue("@ClientLName", lName);
                cmd3.Parameters.AddWithValue("@ClientEmail", eMail);
                cmd3.Parameters.AddWithValue("@ClientPhoneNumber", phoneNum);
                cmd4.Parameters.AddWithValue("@CellphoneSerialNumber", serialNum);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                connRepair.Close();
                connModel.Close();
                connClients.Close();
                connCellphones.Close();
                MessageBox.Show("Repair Successfully added to database");
            }
            catch (SqlException error)
            {
                MessageBox.Show("DATABASE NOT FOUND\n" + error);
            }
            this.Close();
        }

        private void RepairWindow_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //SqlConnection conn1 = new SqlConnection(conStringRepair);
            SqlConnection conn2 = new SqlConnection(conStrClient);
            //string viewRepair = "SELECT * FROM RepairTable";
            //string viewModel = "SELECT * FROM ModelTable";
            string viewClient = "SELECT * FROM ClientTable";
            //conn1.Open();
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand(viewClient, conn2);
            SqlDataAdapter adp = new SqlDataAdapter();
            //SqlCommand cmd1 = new SqlCommand(viewRepair, conn1);
            //SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd2;
            adp.Fill(ds, "ClientTable");

            cbxClients.DisplayMember = "ClientLName";
            cbxClients.ValueMember = "ClientLName";
            cbxClients.DataSource = ds.Tables["ClientLName"];

            //rp.txtRepairDesc.Text = dt.Rows[0]["RepairDescription"].ToString();
            //rp.txtTotalCost.Text = dt.Rows[0]["RepairCost"].ToString();
            //conn1.Close();
            conn2.Close();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            txtCellphoneBrand.Text = "";
            txtCellphoneModel.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNum.Text = "";
            txtRepairDesc.Text = "";
            txtSerialNum.Text = "";
            txtTotalCost.Text = "";
        }

        

        private void CbxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //d();
        }

        public void updateDatabase()
        {
            string phoneBrand = txtCellphoneBrand.Text;
            string phoneModel = txtCellphoneModel.Text;
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string eMail = txtEmail.Text;
            string phoneNum = txtPhoneNum.Text;
            string repairDesc = txtRepairDesc.Text;
            string serialNum = txtSerialNum.Text;
            string repairCost = txtTotalCost.Text;
            SqlConnection connRepair = new SqlConnection(conStrRepair);
            SqlConnection connModel = new SqlConnection(conStrModel);
            SqlConnection connClients = new SqlConnection(conStrClient);
            SqlConnection connCellphones = new SqlConnection(conStrCellphone);
            string inRepair = "UPDATE INTO RepairTable VALUES(@RepairDescription, @RepairCost)";
            string inModel = "UPDATE INTO ModelTable VALUES(@ModelBrand, @ModelDescription)";
            string inClients = "UPDATE INTO ClientTable VALUES(@ClientFName, @ClientLName, @ClientEmail, @ClientPhoneNumber)";
            string inCell = "UPDATE INTO CellphoneTable VALUES(@CellphoneSerialNumber)";
            connRepair.Open();
            connModel.Open();
            connClients.Open();
            connCellphones.Open();

            adp = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand(inRepair, connRepair);
            SqlCommand cmd2 = new SqlCommand(inModel, connModel);
            SqlCommand cmd3 = new SqlCommand(inClients, connClients);
            SqlCommand cmd4 = new SqlCommand(inCell, connCellphones);
            cmd1.Parameters.AddWithValue("@RepairDescription", repairDesc);
            cmd1.Parameters.AddWithValue("@RepairCost", repairCost);
            cmd2.Parameters.AddWithValue("@ModelBrand", phoneBrand);
            cmd2.Parameters.AddWithValue("@ModelDescription", phoneModel);
            cmd3.Parameters.AddWithValue("@ClientFName", fName);
            cmd3.Parameters.AddWithValue("@ClientLName", lName);
            cmd3.Parameters.AddWithValue("@ClientEmail", eMail);
            cmd3.Parameters.AddWithValue("@ClientPhoneNumber", phoneNum);
            cmd4.Parameters.AddWithValue("@CellphoneSerialNumber", serialNum);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();

            connRepair.Close();
            connModel.Close();
            connClients.Close();
            connCellphones.Close();
            ClearData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            updateDatabase();
        }

        private void CbxClients_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
