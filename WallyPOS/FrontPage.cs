/* ========================================================
FILE          : Form1.cs
PROJECT       : Revence of Wally (PoS)- Assignment #04
STUDENT NAME  : Monira Sultana (ID 7308182)
FUNCTION      : Display fromt page and take user input
PURPOSE       :This file takes user input and call other form pages.
======================================================== */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WallyPOS
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }
        //static public bool SetValueForUnpaid = paidRadioButt.Checked;
        public static int SetValueForPending = 0;
        /*
        * FUNCTION :  private void orderButt_Click
        * DESCRIPTION : Display OrderForm after event happen( button clicked) 
        * PARAMETERS : object: sender 
        *              EventArgs: e
        * RETURNS : Nothing
        */
        private void orderButt_Click(object sender, EventArgs e)
        {
            OrderForm orderInfo = new OrderForm();
            orderInfo.Show();

        }

        /*
        * FUNCTION :  private void cancelOrderbutt_Click
        * DESCRIPTION : Cancel Order after event happen( button clicked) 
        * PARAMETERS : object: sender 
        *              EventArgs: e
        * RETURNS : Nothing
        */

        private void cancelOrderbutt_Click(object sender, EventArgs e)
        {
            string sql;
            string orderID = findOrderIDBox.Text;
            int ordID = 0;
            Int32.TryParse(orderID, out ordID);
            string status = "";
            int quantity = 0;




            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            //if(PendingRadioButt.Checked == false && paidRadioButt.Checked == false)
            //{
            //    MessageBox.Show("You must checked order was paid or unpaid");
            //}
            if ((PendingRadioButt.Checked == true || paidRadioButt.Checked == true) && orderID != "")
            {
                if (PendingRadioButt.Checked == true)
                {
                    SetValueForPending = 1;
                    sql = "SELECT OrderStatus FROM Orders WHERE OrderID = " + ordID;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        status = rdr[0].ToString();

                    }
                    // close datareader
                    rdr.Close();
                    if (status.Equals("Pending"))
                    {
                        sql = "UPDATE Orders SET OrderStatus = 'Cancel' WHERE OrderID = " + ordID;
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order has been canceled.");
                        sql = "UPDATE Orderline SET QuantitySold = 0  WHERE OrderID = " + ordID;
                        MySqlCommand quan = new MySqlCommand(sql, conn);
                        quan.ExecuteNonQuery();
                        PendingRadioButt.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("This is duplicate request.Your order cenceled before");
                    }
                }

                if (paidRadioButt.Checked == true)
                {
                    sql = "SELECT OrderStatus FROM Orders WHERE OrderID = " + ordID;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        status = rdr[0].ToString();

                    }
                    // close datareader
                    rdr.Close();
                    if (status.Equals("Paid"))
                    {
                        sql = "UPDATE Orders SET OrderStatus = 'Cancel' WHERE OrderID = " + ordID;
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        //update product
                        sql = "UPDATE Orderline SET QuantitySold = 0 WHERE OrderID = " + ordID;
                        MySqlCommand quan = new MySqlCommand(sql, conn);
                        quan.ExecuteNonQuery();

                        sql = " UPDATE Product SET Quantity = Quantity +" + quantity;
                        MySqlCommand update = new MySqlCommand(sql, conn);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Order has been canceled.");
                        paidRadioButt.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("This is duplicate request.Your order cenceled before");
                    }
                }
            }
            else
            {
                MessageBox.Show(" You must enter OrderID and Order Status to proceed.");
            }
            
            if (conn != null)
            {
                conn.Close();
            }
        }




        /*
        * FUNCTION    :  private void inventorybutt_Click
        * DESCRIPTION : Display total inventory after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void inventorybutt_Click(object sender, EventArgs e)
        {
            
            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
                      
            string sql = "SELECT *from Product";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

           
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            displayView.DataSource = bSource;
            sda.Update(dbdataset);

            if (conn != null)
            {
                conn.Close();
            }
        }
        /*
        * FUNCTION :  public string displayInventory
        * DESCRIPTION : Display inventory upon call
        * PARAMETERS : List <string > productInv
        *              
        * RETURNS : string
        */
        //public string displayInventory(List<String> productInv)
        //{
        //    return string.Join(Environment.NewLine, productInv.ToArray());

        //}

        /*
        * FUNCTION    :  private void closebutt_Click
        * DESCRIPTION : Close the application after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void closebutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        * FUNCTION    :  private void dispOrbutt_Click
        * DESCRIPTION : Display order after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void dispOrbutt_Click(object sender, EventArgs e)
        {

            string order = findOrderIDBox.Text;
            int orderID = 0;
            string firstName = fNametextBox.Text;
            string customerId = "";
            int customerNo = 0;
           // string cusOrder = "";
            Int32.TryParse(order, out orderID);
            //string display = "";
            //int i = 0;
            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //Quarey order
            if (order != "")
            {
                //string sql = "SELECT  OrderID, CustomerID, BranchID, OrderDate, OrderStatus  FROM Orders WHERE OrderID=" + orderID;
                string sql = "SELECT *from Orders where  OrderID= " + orderID;
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //MySqlDataReader rdr = cmd.ExecuteReader();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                displayView.DataSource = bSource;
                sda.Update(dbdataset);

                findOrderIDBox.Clear();

            }
            else if (order == "" && firstName == "")
            {
                MessageBox.Show("Please add a orderID or Customer first Name");
            }

            if (firstName != "")
            {
                string sql = "SELECT  CustomerID  FROM Customer WHERE FirstName= '" + firstName + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    customerId = rdr[0].ToString();
                    Int32.TryParse(customerId, out customerNo);
                    fNametextBox.Clear();
                }
                // close datareader
                rdr.Close();

                sql = "SELECT *from Orders where  CustomerID= " + customerNo;
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                displayView.DataSource = bSource;
                sda.Update(dbdataset);
                
                   //display in a table https://www.youtube.com/watch?v=Sm5mxkytfWk
                   //http://solibnis.blogspot.ca/2013/02/connecting-mysql-table-to-datagridview.html               
                                           
            }

             if (conn != null)
            {
                conn.Close();
            }
        }


        /*
        * FUNCTION    :  private void pendingOrderbutt_Click
        * DESCRIPTION : Change order status from pending to Paid after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void pendingOrderbutt_Click(object sender, EventArgs e)
        {
            string order = findOrderIDBox.Text;
            int orderID = 0;
            Int32.TryParse(order, out orderID);
            string productID = "";
            int porductNo = 0;
            string solQquantity = "";
            int quantity = 0;
            string sql = "";
            string status = "";
            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                // HERE is where we attempt to OPEN the connection to MySQL database...
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            //Quarey order
            if (order != "")
            {
                sql = "SELECT OrderStatus FROM Orders WHERE OrderID = " + orderID;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    status = rdr[0].ToString();

                }
                // close datareader
                rdr.Close();
                if (status.Equals("Pending"))
                {
                    sql = "UPDATE Orders SET OrderStatus = 'Paid' WHERE OrderID = " + orderID;
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "SELECT ProductID, QuantitySold FROM OrderLine WHERE OrderID= " + orderID;
                    cmd = new MySqlCommand(sql, conn);
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        productID = rdr[0].ToString();
                        Int32.TryParse(productID, out porductNo);
                        solQquantity = rdr[1].ToString();
                        Int32.TryParse(solQquantity, out quantity);
                    }
                    // close datareader
                    rdr.Close();
                    sql = "UPDATE Product SET Quantity = Quantity+" + quantity + " WHERE ProductID = " + porductNo;
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                    if (conn != null)
                    {
                        conn.Close();
                    }
                    MessageBox.Show("Your Order has been updated");
                }
                else
                {
                    MessageBox.Show("This is duplicate request.Your order updated before");
                }
                findOrderIDBox.Clear();
            }
            else
            {
                MessageBox.Show("You have to enter a OrderID");
            }
        }
    }
}
 

