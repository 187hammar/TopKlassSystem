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
        string conStrSup = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Suppliers.mdf;Integrated Security=True";
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
            string day = DateTime.Today.Day.ToString();
            String date = dateDay + ", " +day+ ", " + dateMonth + ", " + dateYear +", "+time;
            txtOrderDate.Text = date;

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
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnReSubmit_Click(object sender, EventArgs e)
        {
            RegistrationPage rp = new RegistrationPage();
            NewSupplier ns = new NewSupplier();
            string to, from, pass, mail, nameOfClient;
            nameOfClient = "Ted";
            if (cmbSupplier.SelectedIndex == 0)
            {
                to = "info@gamma.co.za";
            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                to = "info@mobilefun.co.za";
            }
            else if (cmbSupplier.SelectedIndex == 2)
            {
                to = "info@bluetec.co.za";
            }
            else if (cmbSupplier.SelectedIndex == 3)
            {
                to = "info@tvcmall.co.za";
            }
            else if (cmbSupplier.SelectedIndex == 1)
            {
                to = "info@fruugo.co.za";
            }
            else
            {
                to = ns.txtSupName.Text;
            }
            from = (rp.txtEmail.Text).ToString();
            mail = "Dear " + nameOfClient + "\n\n" +
                "We are pleased to inform you that the process of restoring and repairing you cellphone is complete. Thank you for your patience.\n" +
                "Please come to collect you phone at the store as soon as possible. We hope the services were above standard and that they were so satisfactory that you would recomend us to your family and friends.\n" +
                "\nYours Faithfully" +
                "\n" + rp.txtLName.Text + " " + rp.txtFName.Text + "" +
                "\n" +
                "\nThis system was deeloped by Top Klazz System development team.";
            pass = (rp.txtConPWord.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Cellphone repair progress";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email delivered to Client");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
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
