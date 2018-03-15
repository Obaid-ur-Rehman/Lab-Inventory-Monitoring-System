using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lab_Inventory_Monitoring_System
{
    public partial class modifyProduct : Form
    {
        public modifyProduct(String id, bool searchNow)
        {
            InitializeComponent();
            if(searchNow)
            {
                getRecordByName(id);
                hideRecFun();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCancel.Hide();
            btnSubmit.Hide();
            tbID.Enabled = false;
            String id = tbID.Text;
            getRecord(id);
            
        }

        private void getRecord(String id)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT PRODUCT_NAME, PRODUCT_DES FROM products WHERE PRODUCT_ID = '" + id + "';", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tbName.Text = reader.GetString(0);
                            tbDesc.Text = reader.GetString(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No product found");
                        this.Close();
                    }
                    showRecFun();
                }
            }
            catch (Exception ess)
            {
                MessageBox.Show(ess.ToString());
                this.Close();
            }
        }

        private void getRecordByName(String id)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT PRODUCT_ID, PRODUCT_DES FROM products WHERE PRODUCT_NAME = '" + id + "';", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tbID.Text = reader.GetString(0);
                            tbDesc.Text = reader.GetString(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No product found");
                        this.Close();
                    }
                    showRecFun();
                }
            }
            catch (Exception ess)
            {
                MessageBox.Show(ess.ToString());
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyProduct_Load(object sender, EventArgs e)
        {
            hideRecFun();
        }

        private void showRecFun()
        {
            lblName.Show();
            lblDesc.Show();
            btnSubmitRec.Show();
            btnCloseForm.Show();
            tbDesc.Show();
            tbName.Show();
            btnDelete.Show();
        }

        private void hideRecFun()
        {
            lblName.Hide();
            lblDesc.Hide();
            btnSubmitRec.Hide();
            btnCloseForm.Hide();
            tbDesc.Hide();
            tbName.Hide();
            btnDelete.Hide();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitRec_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE products SET PRODUCT_NAME = '" + tbName.Text.ToString() + "', PRODUCT_DES = '" + tbDesc.Text.ToString() + "'", con);
                con.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product record updated");
                }
                else
                {
                    MessageBox.Show("Product details could not be updated");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            btnCancel.Hide();
            btnSubmit.Hide();
            tbID.Enabled = false;
            String id = tbID.Text;
            getRecord(id);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("DELETE FROM products WHERE PRODUCT_ID = '" + tbID.Text.ToString() + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Product record deleted","Alert",MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Product details could not be deleted");
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(mainForm.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("UPDATE products SET PRODUCT_NAME = '" + tbName.Text.ToString() + "', PRODUCT_DES = '" + tbDesc.Text.ToString() + "'", con);
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

        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
