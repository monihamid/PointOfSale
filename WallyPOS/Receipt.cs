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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        string orderline = "";
        List<string> salesLine = new List<string>();
        private void Receipt_Load(object sender, EventArgs e)
        {
            string priceS = OrderForm.SetValueForPrice;
            double unitPrice = 0;
            Double.TryParse(priceS, out unitPrice);
            

            string quantityS= OrderForm.SetValueForQuantity;
            int quantity = 0;
            Int32.TryParse(quantityS, out quantity);
            double totalPrice = unitPrice * quantity;           //calculation price for each item
            double subtotal = 0.0;                            // calculation subtotal
            subtotal = subtotal + totalPrice;
            double hst = subtotal*.13;                              //calculation HST
            double totalSale = subtotal + hst;                       //calculation total sale

            DateTime thisDay = DateTime.Today;            
            string today = thisDay.ToString("D");


            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            grettinglabel.Text = OrderForm.SetValueForBranch;
            //grettinglabel.Text = " Customer Receipt\n\n\n\nThank You for shopping at \nWally's World " + OrderForm.SetValueForBranch
            //+ "\nOn " + today + ",  " + OrderForm.SetValueForName + "!\nOrder ID: " + OrderForm.SetValueForOrderID
            //+ "\n" + OrderForm.SetValueForProduct + " " + OrderForm.SetValueForQuantity + " X  " + OrderForm.SetValueForPrice
            //+ " = $" + totalPrice + "\nSubtotal = $" + subtotal
            //+ "\nHST (13%) = $ " + hst
            //+ "\nSale Total = $ " + totalSale;
            MessageBox.Show(" Customer Receipt\n\n\n\nThank You for shopping at \nWally's World " + OrderForm.SetValueForBranch
            + "\nOn " + today + ",  " + OrderForm.SetValueForName + "!\nOrder ID: " + OrderForm.SetValueForOrderID
            + "\n" + OrderForm.SetValueForProduct + " " + OrderForm.SetValueForQuantity + " X  " + OrderForm.SetValueForPrice
            + " = $" + totalPrice + "\nSubtotal = $" + subtotal
            + "\nHST (13%) = $ " + hst
            + "\nSale Total = $ " + totalSale) ;

            orderline = OrderForm.SetValueForProduct+" "+ OrderForm.SetValueForQuantity + " X  " + OrderForm.SetValueForPrice
            + " = $" + totalPrice + "\nSubtotal = $" + subtotal;
             salesLine.Add(orderline);

            // salesLine.Add(orderline);
        }

        

        private void salebutt_Click(object sender, EventArgs e)
        {
            string orderID = OrderForm.SetValueForOrderID;
            int latestOrderId = 0;
            Int32.TryParse(orderID, out latestOrderId);
            string orderLine = "";
           // string 
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
                Console.WriteLine(ex.ToString());
                //label2.Text = ex.ToString();
            }
            //string phone = PhoneBox.Text;
            // get the orderline for printing receipt
            //SELECT FirstName, LastName  FROM Customer;
            string sql = "SELECT OrderID, ProductId, QuantitySold FROM OrderLine WHERE OrderID= " + latestOrderId;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                // Display the query results
                orderLine= rdr[0] + " " + rdr[1]+ " " + rdr[2].ToString();                               
               
            }
            if (rdr.Read().Equals(false))
            {
                grettinglabel.Text = " Order does not exist";
            }
            //   close datareader
            rdr.Close();

            if (conn != null)
            {
                conn.Close();
            }
        }

        public string displayInventory(List<String> salesLine)
        {
            return string.Join(Environment.NewLine, salesLine.ToArray());

        }
    }
}
