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
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        public static string hashedPassword;

        private void BtnNext_Click(object sender, EventArgs e)
        {
            String FName = txtFName.Text;
            String LName = txtLName.Text;
            String PWord1 = txtPWord.Text;
            String PWord2 = txtConPWord.Text;
            if (PWord1==PWord2)
            {
                String password = PWord1;
                hashedPassword = Hash(password);
            }

            MessageBox.Show(hashedPassword);

            SignInPage home = new SignInPage();
            this.Hide();
            home.ShowDialog();
            this.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
