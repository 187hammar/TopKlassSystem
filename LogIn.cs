using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TopKlassSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        static string Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            RegistrationPage rp = new RegistrationPage();
            String LogInPassword = Hash(txtLogInPassword.Text);
            MessageBox.Show(RegistrationPage.hashedPassword);
            
            if (RegistrationPage.hashedPassword == LogInPassword)
            {
                HomeForm hf = new HomeForm();
                this.Hide();
                hf.ShowDialog();
            }
            else
            {
                MessageBox.Show("INCORRECT PASSWORD!");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            RegistrationPage rp = new RegistrationPage();
            this.Hide();
            rp.ShowDialog();
        }
    }
}
