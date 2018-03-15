using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.OleDb;

namespace Lab_Inventory_Monitoring_System
{
    public partial class mainForm : Form
    {
        static public String conStr;
        Thread bleSearcher;
        SerialPort bluetooth;
        int i;
        public mainForm()
        {
            InitializeComponent();
            getAllPorts();
            conStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =products.mdb";   //OLEDB connection string
            bleSearcher = new Thread(searchBLE);
            bleSearcher.IsBackground = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void getAllPorts()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cbPorts.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bluetooth = new SerialPort(cbPorts.SelectedItem.ToString(), 38400);
            label1.Text = "COM Port initialized";
            try
            {
                bluetooth.Open();
                bleSearcher.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot open serial port. Please close other program using the selected serial port" + Environment.NewLine + ex.ToString(), "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (bluetooth != null || bluetooth.IsOpen)
                    bluetooth.Close();
            }
            catch (Exception c)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void searchBLE()
        {
            try {
                String s = "";
                while (true)
                {
                    String ss = bluetooth.ReadLine();
                    if (ss.Length > 2)
                    {
                        if (ss.IndexOf("Finished") > -1)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                unknownProducts.Items.Clear();
                                onlineProducts.Items.Clear();
                                
                            });
                        }
                        else
                        {
                                ss = ss.Substring(5);
                                string[] packs = ss.Split(',');
                            if (packs[0].Length > 5)
                            {
                                updateUI(packs[0]);
                            }
                            
                        }
                    }
                }
            }
            catch(Exception xx)
            {
                MessageBox.Show(xx.ToString());
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct("");
            f.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            modifyProduct mp = new modifyProduct("", false);
            mp.Show();
        }

        private void updateUI(String s)
        {
            this.Invoke((MethodInvoker)delegate
            {
            if (isKnown(s))
            {
                    updateOnline(s);
                
            }
            else
            {
                updateUnknown(s);
            }
            });
        }

        private void updateOnline(string id)
        {
            //MessageBox.Show(id);
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT PRODUCT_NAME FROM products WHERE PRODUCT_ID = '" + id + "'", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    onlineProducts.Items.Add(reader.GetString(0));
                }
            }
        }
        
        

        private int getNumberOfProducts()
        {
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM products", con);
                con.Open();
                int rows = (int)cmd.ExecuteScalar();
                return rows;
            }
        }

        private void updateUnknown(String s)
        {
            unknownProducts.Items.Add(s);
        }

        private bool isKnown(String id)
        {
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM products WHERE PRODUCT_ID = '" + id + "'", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    return true;
                else
                    return false;
            }
        }

        private void a()
        {

            //using (OleDbConnection con = new OleDbConnection(conStr))
            //{
            //    OleDbCommand cmd = new OleDbCommand("SELECT CNIC, NAME FROM db WHERE MSISDN = '" + info + "'", con);
            //    con.Open();
            //    OleDbDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        //result += "," + reader.GetString(1);
            //        //result += "," + reader.GetString(0);
            //    }
            //}


        }

        private void unknownProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AddProduct ap = new AddProduct(unknownProducts.SelectedItem.ToString());
                ap.Show();
            }
            catch(Exception er)
            {
                MessageBox.Show("Please try again");
            }
        }

        private void onlineProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                modifyProduct mp = new modifyProduct(onlineProducts.SelectedItem.ToString(), true);
                mp.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct("");
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            modifyProduct mp = new modifyProduct("", false);
            mp.Show();
        }
    }
}
