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
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace TopKlassSystem
{
    public partial class stockOrder : Form
    {
        double LCDprice = 140, battery = 189, screen = 445, phoneSpeaker = 470, phoneMicrophone = 289, chargingSystem = 445, headsetPods = 58;
        string conStrOrder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Order.mdf;Integrated Security=True";
        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button3.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text +"\n "+ button3.Text;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button4.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button4.Text;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button5.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button5.Text;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button6.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button6.Text;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button7.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button7.Text;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button2.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button2.Text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtSpareName.Text == null)
            {
                txtSpareName.Text = txtSpareName.Text + button1.Text;
            }
            else
            {
                txtSpareName.Text = txtSpareName.Text + "\n " + button1.Text;
            }
        }

        string conStrSup = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Suppliers.mdf;Integrated Security=True";
        public stockOrder()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public static string orderDate;
        public static string orderRecievedDate;
        private void StockOrder_Load(object sender, EventArgs e)
        {
            string dateDay = DateTime.Today.DayOfWeek.ToString();
            string dateMonth = DateTime.Now.ToString("MMM");
            string time = DateTime.Now.ToString("HH:mm"); ;
            string dateYear = DateTime.Today.Year.ToString();
            string day = DateTime.Today.Day.ToString();
            orderDate = dateDay + ", " +day+ ", " + dateMonth + ", " + dateYear +", "+time;

            string dateDayR = DateTime.Today.AddDays(3).DayOfWeek.ToString();
            string dateMonthR = DateTime.Now.AddDays(3).ToString("MMM");
            string timeR = DateTime.Now.AddDays(3).ToString("HH:mm"); ;
            string dateYearR = DateTime.Today.AddDays(3).Year.ToString();
            string dayR = DateTime.Today.Day.ToString();
            orderRecievedDate = dateDayR + ", " + dayR + ", " + dateMonthR + ", " + dateYearR + ", " + timeR;
            txtOrderDate.Text = orderDate;
            txtOrderDate.Enabled = false;
            txtRecievedDate.Text = orderRecievedDate;
            txtRecievedDate.Enabled = false;

            lblOrderNum.Visible = false;
            txtOrderNum.Visible = false;

            SqlConnection conn= new SqlConnection(conStrSup);
            conn.Open();
            string viewSup = "SELECT SupplierName FROM SupplierTable";
            SqlCommand cmd = new SqlCommand(viewSup, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "SupplierTable");

            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierName";
            cmbSupplier.DataSource = ds.Tables["SupplierTable"];
            conn.Close();


        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            double totalCost = 0;
            if (txtSpareName.Text.Contains(button1.Text))
            {
                totalCost += LCDprice;
            }
            if (txtSpareName.Text.Contains(button2.Text))
            {
                totalCost += battery;
            }
            if (txtSpareName.Text.Contains(button3.Text))
            {
                totalCost += screen;
            }
            if (txtSpareName.Text.Contains(button4.Text))
            {
                totalCost += phoneMicrophone;
            }
            if (txtSpareName.Text.Contains(button5.Text))
            {
                totalCost += phoneSpeaker;
            }
            if (txtSpareName.Text.Contains(button6.Text))
            {
                totalCost += chargingSystem;
            }
            if (txtSpareName.Text.Contains(button7.Text))
            {
                totalCost += headsetPods;
            }

            string phoneBrand = txtBrand.Text, model = txtModel.Text, date = txtOrderDate.Text, spareName = txtSpareName.Text;
            string orderDesc = phoneBrand + ", " + model + ", " + spareName;
            this.InitializeComponent();
            SqlConnection conn = new SqlConnection(conStrOrder);
            conn.Open();
            string addOrder = "INSERT INTO OrderTable VALUES(@OrderDescription, @OrderCost, @OrderDate, @OrderDateRecieved)";
            SqlCommand cmd = new SqlCommand(addOrder, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@OrderDescription", orderDesc);
            cmd.Parameters.AddWithValue("@OrderCost", totalCost);
            cmd.Parameters.AddWithValue("@OrderDate", orderDate);
            cmd.Parameters.AddWithValue("@OrderDateRecieved", orderRecievedDate);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("ORDER SUCCESSFULLY SENT TO SUPPLIER.\n\n Order currently being proccessed. \n PARTS WILL BE DILIVERED WITH IN A MAXIMUN OF THREE DAYS");


        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnReSubmit_Click(object sender, EventArgs e)
        {
            double totalCost = 0;
            if (txtSpareName.Text.Contains(button1.Text))
            {
                totalCost += LCDprice;
            }
            if (txtSpareName.Text.Contains(button2.Text))
            {
                totalCost += battery;
            }
            if (txtSpareName.Text.Contains(button3.Text))
            {
                totalCost += screen;
            }
            if (txtSpareName.Text.Contains(button4.Text))
            {
                totalCost += phoneMicrophone;
            }
            if (txtSpareName.Text.Contains(button5.Text))
            {
                totalCost += phoneSpeaker;
            }
            if (txtSpareName.Text.Contains(button6.Text))
            {
                totalCost += chargingSystem;
            }
            if (txtSpareName.Text.Contains(button7.Text))
            {
                totalCost += headsetPods;
            }

            string phoneBrand = txtBrand.Text, model = txtModel.Text, date = txtOrderDate.Text, spareName = txtSpareName.Text;
            string orderDesc = phoneBrand + ", " + model + ", " + spareName;
            this.InitializeComponent();
            SqlConnection conn = new SqlConnection(conStrOrder);
            conn.Open();
            string addOrder = "INSERT INTO OrderTable VALUES(@OrderDescription, @OrderCost, @OrderDate, @OrderDateRecieved)";
            SqlCommand cmd = new SqlCommand(addOrder, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@OrderDescription", orderDesc);
            cmd.Parameters.AddWithValue("@OrderCost", totalCost);
            cmd.Parameters.AddWithValue("@OrderDate", orderDate);
            cmd.Parameters.AddWithValue("@OrderDateRecieved", orderRecievedDate);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("ORDER SUCCESSFULLY SENT TO SUPPLIER.\n\n Order currently being proccessed. \n PARTS WILL BE DILIVERED WITH IN A MAXIMUN OF THREE DAYS");

        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            NewSupplier ns = new NewSupplier();
            ns.Show();
            this.Hide();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStrSup);
                conn.Open();
                string del = @"DELETE FROM SUpplierTable WHERE SupplierName ='"+txtDelete.Text+"";
                SqlDataAdapter adp = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(del, conn);
                adp.DeleteCommand = cmd;
                adp.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("DELETE SUCCESSFUL");
            }
            catch (SqlException err)
            {
                MessageBox.Show("ERROR: COULDN'T DELETE\n\n" + err.Message);
            }
        }
    }
}
