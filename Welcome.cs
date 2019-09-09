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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        Timer tmr;
        private void Welcome_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 6000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        public void tmr_Tick(Object sender, EventArgs e)
        {
            tmr.Stop();
            SignInPage sI = new SignInPage();
            sI.Show();
            this.Hide();
        }
    }
}
