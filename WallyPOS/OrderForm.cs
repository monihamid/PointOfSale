
/* ========================================================
FILE          : assign1.cpp
PROJECT       : overloaded Function- Assignment #1
STUDENT NAME  : Monira Sultana (ID 7308182)
FIRST VERSION : January 12, 2015
FUNCTION      : main
PURPOSE       :This mainline calls set of various overloaded functions.
RETURNS       : 0 - OKAY status
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
    public partial class OrderForm : Form
    {
        
        public OrderForm()
        {
            InitializeComponent();
            
            
        }
        //public static string SetValueForBranch = "";
        //public static string SetValueForName = "";
        //public static string SetValueForOrderID = "";
        //public static string SetValueForProduct = "";
        //public static string SetValueForQuantity = "";
        //public static string SetValueForPrice = "";
        //string orderLine = "";
        string productdetail = "";
        List<string> productQuantity = new List<string>();
        List<string> productDetails = new List<string> ();
       

        private void OrderForm_Load(object sender, EventArgs e)
        {   

        }
        /*
        * FUNCTION    :  private void FindCbutt_Click
        * DESCRIPTION : Find and Display customer after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void FindCbutt_Click(object sender, EventArgs e)
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
                
            }
            string phone = PhoneBox.Text;
            //SELECT FirstName, LastName  FROM Customer;
            string sql = "SELECT CustomerID, FirstName, LastName FROM Customer WHERE Phone= " + "'" + phone+ "'";   
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                // Display the query results

                MessageBox.Show("CustomerId FirstName LastName\n   " +rdr[0].ToString()+ "                  " +rdr[1].ToString()+ "              "+rdr[2].ToString());
               
            }
            else if (rdr.Read().Equals(false))
            {
                MessageBox.Show( " Customer not in the data base");
            }
            //close datareader
            rdr.Close();

            if (conn != null)
            {
                conn.Close();
            }
        }
        /*
        * FUNCTION    :  private void CreateCusbutt_Click
        * DESCRIPTION : Takes user input and add customer in to the data base after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void CreateCusbutt_Click(object sender, EventArgs e)
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
                
            }
            
            string phone = PhoneBox.Text;
            string fName = fNameBox.Text;
            string lastName =LNameBox.Text;
            string sql = "INSERT INTO Customer(FirstName, LastName, Phone) VALUES (" +"'"+fName+"',"+
                "'"+lastName+"',"+"'" +phone+"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd = new MySqlCommand(sql, conn); //MySqlCommand
            cmd.ExecuteNonQuery();      
                    

            if (conn != null)
            {
                conn.Close();
            }
            

        }
        /*
        * FUNCTION    :  private void orderdetailButt_Click
        * DESCRIPTION : Takes user input and insert OrderLine values in to the data base after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void orderdetailButt_Click(object sender, EventArgs e)
        {
           
            string quantity = quantityBox.Text;       //get user input for quantity
            int quantiysold = 0;
            string product = ProductListBox.Text;     //get user input for product name

            //SetValueForProduct = ProductListBox.Text;
            //SetValueForQuantity = quantityBox.Text;
                          
            string productID;
            int produID = 0;
           
            string auto_IncNo;
            int autoIncrementNo = 0;
            DateTime today = DateTime.Today;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");           
           
            Int32.TryParse(quantity, out quantiysold);
            

            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
               
                // HERE is where we attempt to OPEN the connection to MySQL database...

                conn.Open();
            }
            catch (Exception ex)
            {
                
            }
                     
            
            string sql = "SELECT ProductID,UnitPrice FROM Product WHERE ProductName= "+"'" +product + "'";
            MySqlCommand prod = new MySqlCommand(sql, conn);
            prod = new MySqlCommand(sql, conn);             //MySqlCommand
            MySqlDataReader prodReader = prod.ExecuteReader();
            while (prodReader.Read())
            {
                // Display the query results
                //label2.Text = "ProductID is  " + prodReader[0].ToString();
                productID = prodReader[0].ToString();
                Int32.TryParse(productID, out produID);
                
            }

            prodReader.Close();
          
           
                 //make query for last OrderID
            sql = "SELECT AUTO_INCREMENT FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'MSWALLY' AND TABLE_NAME = 'Orders'";
            MySqlCommand insertOrder = new MySqlCommand(sql, conn); //MySqlCommand
            MySqlDataReader autoReader = insertOrder.ExecuteReader();
            while (autoReader.Read())
             {
                
                auto_IncNo = autoReader[0].ToString();
               
                Int32.TryParse(auto_IncNo, out autoIncrementNo);
             }

            autoReader.Close();
            //insert OrderLine
            autoIncrementNo = autoIncrementNo - 1;          // Because autoIncrementNo gets the next value
           
            orderIDtextBox.Text = autoIncrementNo.ToString();

            sql = "INSERT INTO OrderLine( OrderID, ProductID, QuantitySold) VALUES ("+ autoIncrementNo+","+ produID+","+ quantiysold+")";
            MySqlCommand OrderLine = new MySqlCommand(sql, conn);
            OrderLine = new MySqlCommand(sql, conn); //MySqlCommand
            OrderLine.ExecuteNonQuery();

            //update product quantity
            if (paidradioButt.Checked == true)
            {
                sql = "UPDATE Product SET Quantity = Quantity - "+quantiysold+" WHERE ProductID = " + produID ;
                
                MySqlCommand updatePQ = new MySqlCommand(sql, conn);
                updatePQ = new MySqlCommand(sql, conn); //MySqlCommand
                updatePQ.ExecuteNonQuery();

            }

            if (conn != null)
            {
                conn.Close();
            }
            quantityBox.Clear();
        }

        /*
        * FUNCTION    :  private void checkInventorybutt_Click
        * DESCRIPTION : Takes user input and display inventory level(Quantity) after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void checkInventorybutt_Click(object sender, EventArgs e)
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
                
            }
            string product = ProductListBox.Text;

            string sql = "SELECT Quantity FROM Product WHERE ProductName=" + "'"+product+"'";              
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd = new MySqlCommand(sql, conn); //MySqlCommand
            //cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                
                MessageBox.Show("Inventory lebel for " + product + " is   " + rdr[0].ToString());
               
            }

            if (conn != null)
            {
                conn.Close();
            }

        }
        /*
        * FUNCTION    :  private void orderButt_Click
        * DESCRIPTION : Takes user input and insert Order values in to the data base after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void orderButt_Click(object sender, EventArgs e)
        {
            string phone = PhoneBox.Text;            //get user input for phone               
            string branch = branchBox.Text;           //get user input for branch name
            
            string CustomerID;
            int CusID = 0;
            string BranchID;        
            int branchNo = 0;          
            DateTime today = DateTime.Today;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string status = null;
            
          

            string connStr = "server=localhost;user=superuser;database=MSWALLY;port=3306;password=Conestoga1;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
               
                // HERE is where we attempt to OPEN the connection to MySQL database...

                conn.Open();
            }
            catch (Exception ex)
            {
                
            }
            if ((phone != "" && branch != "")&&(paidradioButt.Checked == true||pendingradioButt.Checked==true))
            {
                string sql = "SELECT CustomerID, FirstName, LastName FROM Customer WHERE Phone= " + "'" + phone + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd = new MySqlCommand(sql, conn);                 //MySqlCommand
                                                                   //cmd.ExecuteNonQuery();
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read().Equals(true))
                {

                    CustomerID = rdr[0].ToString();
                    Int32.TryParse(CustomerID, out CusID);


                    //else if (rdr.Read().Equals(false))
                    //{
                    //    label2.Text = "Customer not in the data base please add a new customer";
                    //}
                    rdr.Close();

                    // get branchID

                    sql = "SELECT BranchID FROM Branch WHERE BranchName= " + "'" + branch + "'";
                    MySqlCommand bran = new MySqlCommand(sql, conn);
                    bran = new MySqlCommand(sql, conn); //MySqlCommand
                                                        //cmd.ExecuteNonQuery();
                    MySqlDataReader bReader = bran.ExecuteReader();
                    while (bReader.Read())
                    {

                        BranchID = bReader[0].ToString();
                        Int32.TryParse(BranchID, out branchNo);
                    }

                    bReader.Close();

                    if (paidradioButt.Checked == true)
                    {
                        status = "Paid";
                    }
                    if (pendingradioButt.Checked == true)
                    {
                        status = "Pending";
                    }
                    else if (paidradioButt.Checked == false && pendingradioButt.Checked == false)
                    {
                        MessageBox.Show("You have to select the status of order");
                    }
                    sql = "INSERT INTO Orders( CustomerID, BranchID, OrderDate, OrderStatus) VALUES (" +
                     CusID + "," + branchNo + ",'" + date + "'," + "'" + status + "')";

                    MySqlCommand insertOrder = new MySqlCommand(sql, conn);
                    insertOrder = new MySqlCommand(sql, conn); //MySqlCommand
                    insertOrder.ExecuteNonQuery();
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must add Customer phone no, branch and order status to proceed");
            }

        }
        /*
        * FUNCTION    :  private void orderButt_Click
        * DESCRIPTION : Takes user input (OrderID) and print sales recoed (receipt) after event happen( button clicked) 
        * PARAMETERS  : object: sender 
        *               EventArgs: e
        * RETURNS     : Nothing
        */
        private void receiptbutt_Click(object sender, EventArgs e)
        {
            string OrderId = OrdIDtextBox.Text;
            int orderNo = 0;
            Int32.TryParse(OrderId, out orderNo);            
            string quantity = "";
            int quantitysold = 0;
            string customerID = "";
            int customerNo = 0;
            string fName = "";
            string lName = "";
            string branchID = "";
            int branchNo = 0;
            string branchName = "";
            string status = "";
            string lastworld = "";            
            string uPrice = "";
            string sql = "";
            
            double unitPrice = 0;
            


           
            double totalPrice = 0.0;            //calculation price for each item
            double subtotal = 0.0;                            
            
            double hst = 0.0;                             //calculation HST
            double totalSale = subtotal + hst;                       //calculation total sale

            DateTime thisDay = DateTime.Today;
            string today = thisDay.ToString("D");
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
           

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
                     
            
            //Read Orders
            sql = "SELECT CustomerID, OrderStatus, BranchID from Orders WHERE OrderID=" + orderNo;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd = new MySqlCommand(sql, conn);                 //MySqlCommand

            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                customerID = rdr[0].ToString();
                Int32.TryParse(customerID, out customerNo);
                status = rdr[1].ToString();
                branchID = rdr[2].ToString();
                Int32.TryParse(branchID, out branchNo);
            }
            rdr.Close();
            sql = "SELECT FirstName, LastName FROM Customer WHERE CustomerID=" + customerNo;
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fName = rdr[0].ToString();                
                lName = rdr[1].ToString();
                
            }
            rdr.Close();
            sql = "SELECT BranchName FROM Branch WHERE BranchID=" + branchNo;
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                branchName = rdr[0].ToString();                

            }
            rdr.Close();


            sql = "SELECT Product.ProductName, OrderLine.QuantitySold, Product.UnitPrice  FROM Product INNER JOIN OrderLine  ON product.ProductID = orderLine.ProductID WHERE OrderID = " + orderNo;
                   
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                quantity = rdr[1].ToString();
                Int32.TryParse(quantity, out quantitysold);
                uPrice = rdr[2].ToString();
                Double.TryParse(uPrice, out unitPrice);
                totalPrice = (quantitysold * unitPrice);
                totalPrice.ToString();

                productdetail = rdr[0].ToString()+" "+ rdr[1].ToString()+" X "+ rdr[2].ToString()+" = $ "+ totalPrice;
                productDetails.Add(productdetail);
                subtotal = subtotal + totalPrice;
            }
            rdr.Close();
            rdr.Close();
               hst = subtotal * .13;                              //calculation HST
             totalSale = subtotal + hst;

            if (status.Equals("Paid"))
            {
               
                lastworld = "Thank You. Visit us again";
            }
            if (status.Equals("Pending"))
            {
                lastworld = "We'll contact you soon";
            }
            if (status.Equals("Cancel"))
            {
                if (FrontPage.SetValueForPending == 1)
                {
                    lastworld = " Your pending order has been canceled. Please come again";
                }
                else
                {
                    lastworld = "Refunded - Please come again";
                }
            }
            
            MessageBox.Show(" Customer Receipt\n\n\n\nThank You for shopping at \nWally's World " + branchName
        + "\nOn " + today + ",  " + fName + " " + lName + "!\nOrder ID: " + OrderId
        + "\n" + display(productDetails)
        + "\nSubtotal = $" + subtotal
        + "\nHST (13%) = $ " + hst
        + "\nSale Total = $ " + totalSale +"\n\n\n\n"+ lastworld);
        
        }
        public string display(List<String> productOrder)
        {
            return string.Join(Environment.NewLine, productOrder.ToArray());

        }
        public string displayOL(Dictionary<String,String> productOrder)
        {
            return string.Join(Environment.NewLine, productOrder.ToArray());

        }
        private void EOrderbutt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
