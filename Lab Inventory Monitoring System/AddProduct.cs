using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lab_Inventory_Monitoring_System
{
    public partial class AddProduct : Form
    {
        public AddProduct(String ID)
        {
            InitializeComponent();
            tbID.Text = ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0 && tbName.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO products (PRODUCT_ID, PRODUCT_NAME, PRODUCT_DES) VALUES('" + tbID.Text.ToString() + "', '" + tbName.Text.ToString() + "', '" + tbDescription.Text.ToString() + "')", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Product record updated");
                    }
                    else
                    {
                        MessageBox.Show("Product details could not be updated");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter valid ID and Name of product");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
