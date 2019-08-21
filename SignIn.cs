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
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LogIn lI = new LogIn();
            this.Hide();
            lI.ShowDialog();
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistrationPage register = new RegistrationPage();
            this.Hide();
            register.ShowDialog();
            this.Close();
            btnRegister.Visible = false;
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {

        }

        private void SignInPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
