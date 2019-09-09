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
    public partial class LineUp : Form
    {
        public LineUp()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Repair.mdf;Integrated Security=True";
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;

        private void LineUp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            String viewAll = "SELECT * FROM RepairTable";
            cmd = new SqlCommand(viewAll, conn);
            adp = new SqlDataAdapter();
            ds = new DataSet();

            adp.SelectCommand = cmd;
            adp.Fill(ds, "RepairTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RepairTable";
        }
    }
}
