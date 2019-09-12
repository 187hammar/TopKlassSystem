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
    public partial class NewSupplier : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\X\Documents\C# 2k19\TopKlassSystem\Suppliers.mdf;Integrated Security=True";
        public NewSupplier()
        {
            InitializeComponent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            try
            {
                string suppName = txtSupName.Text;
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string inSupplier = "INSERT INTO SupplierTable VALUES (@SupplierName)";
                SqlCommand cmd = new SqlCommand(inSupplier, conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                cmd.Parameters.AddWithValue("@SupplierName", suppName);
                cmd.ExecuteNonQuery();
                conn.Close();
                

                stockOrder so = new stockOrder();
                so.cmbSupplier.Items.Add(suppName);
                so.cmbSupplier.SelectedItem = suppName;
                so.Show();
                this.Hide();
            }
            catch (SqlException err)
            {
                MessageBox.Show("DATABASE ERROR: \n\n\n" + err.Message);
            }


        }
    }
}
