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
            //try
            //{
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
            /*}
            catch (SqlException error)
            {
                MessageBox.Show("DATABASE NOT FOUND\n" + error);
            }
            this.Close();*/
        }

        private void RepairWindow_Load(object sender, EventArgs e)
        {
            lblClientName.Visible = false;
            cbxClients.Visible = false;
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            RegistrationPage rp = new RegistrationPage();
            string to, from, pass, mail, nameOfClient;
            nameOfClient = "Ted";
            to = (txtEmail.Text).ToString();
            from = (rp.txtEmail.Text).ToString();
            mail = "Dear "+nameOfClient+"\n\n" +
                "We are pleased to inform you that the process of restoring and repairing you cellphone is complete. Thank you for your patience.\n" +
                "Please come to collect you phone at the store as soon as possible. We hope the services were above standard and that they were so satisfactory that you would recomend us to your family and friends.\n" +
                "\nYours Faithfully" +
                "\n"+rp.txtLName.Text+" "+rp.txtFName.Text+"" +
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
    }
}
