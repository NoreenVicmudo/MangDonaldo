using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DS_ORDERINGEXAM
{
    public partial class mangdonaldo : Form
    {
        //itemandprice is array for the item and their prices
        Dictionary<string, double> itemandprice = new Dictionary<string, double>
        {
            {"Big Mang", 179.00},
            {"Double Quarter Pounder w/ Cheese", 242.00},
            {"Quarter Pounder w/ Cheese", 179.00},
            {"Triple Cheeseburger", 179.00},
            {"Double Cheeseburger", 142.00},
            {"Double MangChicken", 142.00},
            {"MangChicken", 99.00},
            {"Cheeseburger", 79.00},
            {"Crispy Chicken Sandwich", 64.00},
            {"Burger MangDo", 44.00},

            {"6 pcs. MangNuggets", 99.00},
            {"10 pcs. MangNuggets", 175.00},
            {"20 pcs. MangNuggets", 350.00},

            {"Enemy Fries", 169.00},
            {"Large Fries", 105.00},
            {"Medium Fries", 83.00},
            {"Enemy Shake Shake Fries", 189.00},
            {"Regular Fries", 55.00},
            {"Medium Shake Shake Fries", 93.00},
            {"Large Shake Shake Fries", 115.00},
            {"Regular Twister Fries", 98.00},
            {"Sharing Twister Fries", 221.00},

            {"1 pc. Crispy Chicken Fillet", 82.00},
            {"2 pcs. Crispy Chicken Fillet", 115.00},
            {"1 pc. Crispy Chicken Fillet Ala King", 89.00},

            {"1 pc. Chicken MangDo", 99.00},
            {"1 pc. Chicken MangDo - Spicy", 105.00},
            {"2 pcs. Chicken MangDo", 185.00},
            {"2 pcs. Chicken MangDo - Spicy", 191.00},
            {"6 pcs. Chicken MangDo MangShare Box", 495.00},
            {"8 pcs. Chicken MangDo MangShare Box", 651.00},

            {"MangSpaghetti", 75.00},
            {"1 pc. Mushroom Pepper Steak", 79.00},
            {"2 pcs. Mushroom Pepper Steak", 118.00},
            {"Apple Pie", 43.00},

            {"Hot Fudge Sundae", 55.00},
            {"Hot Caramel Sundae", 55.00},
            {"MangFlurry with Oreo", 62.00},

            {"MangCafe Iced Coffee Original Medium", 61.00},
            {"MangCafe Iced Coffee w/ Vanilla Medium", 72.00},
            {"MangCafe Iced Coffee w/ Vanilla Large", 92.00},
            {"MangCafe Iced Coffee Chocolate Medium", 72.00},
            {"MangCafe Iced Coffee Chocolate Large", 92.00},
            {"MangCafe Premium Roast Coffee Regular", 57.00},
            {"MangCafe Premium Roast Coffee Large", 67.00},
            {"MangCafe Iced Coffee Original Large", 81.00},

            {"Coke MangFloat Medium", 57.00},
            {"Coke MangFloat Large", 79.00},
            {"MangCafe Coffee MangFloat", 82.00},

            {"Coke Medium", 75.00},
            {"Coke Large", 85.00},
            {"Coke Zero Medium", 75.00},
            {"Coke Zero Large", 85.00},
            {"Sprite Medium", 75.00},
            {"Sprite Large", 85.00},
            {"Orange Juice Medium", 82.00},
            {"Orange Juice Large", 92.00},
            {"Pineapple Juice Medium", 82.00},
            {"Pineapple Juice Large", 92.00},
            {"Iced Tea Medium", 82.00},
            {"Iced Tea Large", 92.00},

            
            {"Burger MangDo w/ toy", 129.00},
            {"MangSpaghetti w/ toy", 140.00},
            {"4 pcs. MangNuggets w/ toy", 147.00},
            {"1 pc. Chicken MangDo w/ toy", 185.00},

            {"Extra Gravy", 11.00},
            {"Extra Cheese", 17.00},
            {"Extra BBQ Sauce", 17.00},
            {"Extra Sweet and Sour Sauce", 17.00},
            {"Mushroom Pepper Sauce", 11.00},
            {"Buttered Corn", 53.00},

            {"Voucher of 30", 30.00},
            {"Voucher of 50", 50.00},
            {"Voucher of 80", 80.00}
        };
        
        double total = 0; 

        public mangdonaldo()
        {
            InitializeComponent();
        }

        //combobox
        private void mangdonaldo_Load(object sender, EventArgs e)
        { //declare items in combobox
            hamborgar.Items.Add("Big Mang");
            hamborgar.Items.Add("Double Quarter Pounder w/ Cheese");
            hamborgar.Items.Add("Quarter Pounder w/ Cheese");
            hamborgar.Items.Add("Triple Cheeseburger");
            hamborgar.Items.Add("Double Cheeseburger");
            hamborgar.Items.Add("Double MangChicken");
            hamborgar.Items.Add("MangChicken");
            hamborgar.Items.Add("Cheeseburger");
            hamborgar.Items.Add("Crispy Chicken Sandwich");
            hamborgar.Items.Add("Burger MangDo");

            nagets.Items.Add("6 pcs. MangNuggets");
            nagets.Items.Add("10 pcs. MangNuggets");
            nagets.Items.Add("20 pcs. MangNuggets");

            poteto.Items.Add("Enemy Fries");
            poteto.Items.Add("Large Fries");
            poteto.Items.Add("Medium Fries");
            poteto.Items.Add("Enemy Shake Shake Fries");
            poteto.Items.Add("Regular Fries");
            poteto.Items.Add("Medium Shake Shake Fries");
            poteto.Items.Add("Large Shake Shake Fries");
            poteto.Items.Add("Regular Twister Fries");
            poteto.Items.Add("Sharing Twister Fries");

            fillet.Items.Add("1 pc. Crispy Chicken Fillet");
            fillet.Items.Add("2 pcs. Crispy Chicken Fillet");
            fillet.Items.Add("1 pc. Crispy Chicken Fillet Ala King");

            chikin.Items.Add("1 pc. Chicken MangDo");
            chikin.Items.Add("1 pc. Chicken MangDo - Spicy");
            chikin.Items.Add("2 pcs. Chicken MangDo");
            chikin.Items.Add("2 pcs. Chicken MangDo - Spicy");
            chikin.Items.Add("6 pcs. Chicken MangDo MangShare Box");
            chikin.Items.Add("8 pcs. Chicken MangDo MangShare Box");

            snacks.Items.Add("MangSpaghetti");
            snacks.Items.Add("1 pc. Mushroom Pepper Steak");
            snacks.Items.Add("2 pcs. Mushroom Pepper Steak");
            snacks.Items.Add("Apple Pie");

            sunday.Items.Add("Hot Fudge Sundae");
            sunday.Items.Add("Hot Caramel Sundae");
            sunday.Items.Add("MangFlurry with Oreo");

            kopi.Items.Add("MangCafe Iced Coffee Original Medium");
            kopi.Items.Add("MangCafe Iced Coffee w/ Vanilla Medium");
            kopi.Items.Add("MangCafe Iced Coffee w/ Vanilla Large");
            kopi.Items.Add("MangCafe Iced Coffee Chocolate Medium");
            kopi.Items.Add("MangCafe Iced Coffee Chocolate Large");
            kopi.Items.Add("MangCafe Premium Roast Coffee Regular");
            kopi.Items.Add("MangCafe Premium Roast Coffee Large");
            kopi.Items.Add("MangCafe Iced Coffee Original Large");

            plowt.Items.Add("Coke MangFloat Medium");
            plowt.Items.Add("Coke MangFloat Large");
            plowt.Items.Add("MangCafe Coffee MangFloat");

            drinks.Items.Add("Coke Medium");
            drinks.Items.Add("Coke Large");
            drinks.Items.Add("Coke Zero Medium");
            drinks.Items.Add("Coke Zero Large");
            drinks.Items.Add("Sprite Medium");
            drinks.Items.Add("Sprite Large");
            drinks.Items.Add("Orange Juice Medium");
            drinks.Items.Add("Orange Juice Large");
            drinks.Items.Add("Pineapple Juice Medium");
            drinks.Items.Add("Pineapple Juice Large");
            drinks.Items.Add("Iced Tea Medium");
            drinks.Items.Add("Iced Tea Large");

            happymeal.Items.Add("Burger MangDo w/ toy");
            happymeal.Items.Add("MangSpaghetti w/ toy");
            happymeal.Items.Add("4 pcs. MangNuggets w/ toy");
            happymeal.Items.Add("1 pc. Chicken MangDo w/ toy");

            extras.Items.Add("Extra Gravy");
            extras.Items.Add("Extra Cheese");
            extras.Items.Add("Extra BBQ Sauce");
            extras.Items.Add("Extra Sweet and Sour Sauce");
            extras.Items.Add("Mushroom Pepper Sauce");
            extras.Items.Add("Buttered Corn");

            vouchers.Items.Add("Voucher of 30");
            vouchers.Items.Add("Voucher of 50");
            vouchers.Items.Add("Voucher of 80");
        }

        //function per combobox
        private void cart (string order)
        {
            if (itemandprice.ContainsKey(order)) // Check if the the string order is in the array
            {
                double price = itemandprice[order]; //get the price kapag nasa array nga
                string itempricedisplay = $"{order} - ₱{price}"; //string form to be printed later
                orderlist.Items.Add(itempricedisplay); //print and add
                total += price; //add the orders
                ordernotif.Text = $"{order} is added to the order."; //notif
                totalprice.Text = $"₱{total}"; //show total
            }
        }
        
        //Borgar Combobox
        private void hamborgar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = hamborgar.SelectedItem.ToString();
            cart(selecteditem); //call the function
        }

        //Nugggets Combobox
        private void nagets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = nagets.SelectedItem.ToString();
            cart(selecteditem);
        }

        //Fries Combobox
        private void poteto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = poteto.SelectedItem.ToString();
            cart(selecteditem);
        }

        //Fillet Combobox
        private void fillet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = fillet.SelectedItem.ToString();
            cart(selecteditem);
        }

        //Chicken Combobox
        private void chikin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = chikin.SelectedItem.ToString();
            cart(selecteditem);
        }

        //snacks combobox
        private void snacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = snacks.SelectedItem.ToString();
            cart(selecteditem);
        }

        //sundae combobox
        private void sunday_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = sunday.SelectedItem.ToString();
            cart(selecteditem);
        }

        //coffee combobox
        private void kopi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = kopi.SelectedItem.ToString();
            cart(selecteditem);
        }

        //float combobox
        private void plowt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = plowt.SelectedItem.ToString();
            cart(selecteditem);
        }

        //drinks combobox
        private void drinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = drinks.SelectedItem.ToString();
            cart(selecteditem);
        }

        //happy meal combobox
        private void happymeal_SelectedIndexChanged(object sender, EventArgs e)
        {           
            string selecteditem = happymeal.SelectedItem.ToString();
            cart(selecteditem);
        }

        //extras combobox
        private void extras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = extras.SelectedItem.ToString();
            cart(selecteditem);
        }

        //checkout order
        private void checkout_Click(object sender, EventArgs e)
        {       
            if (total == 0.0) //if the total amount is 0, it meant that no items was selected
            {
                MessageBox.Show("No items selected.");
            }
            else
            { //else it will print the result that it was ordered
                DialogResult res = MessageBox.Show($"Selection Successful! Amount to pay: ₱{total}  Order Again?", "Thank you for using Kangfu Panda!", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes) //if dialog result is yes, what will happen
                { //will clear and revert these 
                    total = 0.0;
                    hamborgar.Text = "Hamburger";
                    nagets.Text = "MangNuggets";
                    poteto.Text = "Fries";
                    fillet.Text = "Chicken Fillet";
                    chikin.Text = "Chicken";
                    snacks.Text = "Snacks";
                    sunday.Text = "Sundae";
                    kopi.Text = "MangCafe";
                    plowt.Text = "Float";
                    drinks.Text = "Drinks";
                    happymeal.Text = "Happy Meal";
                    extras.Text = "Extras";
                    orderlist.Items.Clear();
                    totalprice.Text = "";
                    ordernotif.Text = "";
                    vouchers.Text = "Vouchers";
                }
                else if (res == DialogResult.Cancel)
                { //if cancel it will bring back 
                }
                else
                { //exit
                    this.Close(); //close the dialog
                }
            }
        }

        //clear order
        private void clearButton_Click(object sender, EventArgs e)
        { //will clear the order/ resetting to repeat the order again
            orderlist.Items.Clear();         
            total = 0; // Reset the total to 0
            totalprice.Text = "";
            ordernotif.Text = "";
            vouchers.Text = "Vouchers";
        }

        //remove button
        private void removeButton_Click(object sender, EventArgs e)
        { //remove an item in the list
            if (orderlist.SelectedIndex != -1) // Check if an item is selected in the orderlist
            {
                string selecteditem = orderlist.Items[orderlist.SelectedIndex].ToString(); // Get the selected item, convert it to a string
                string getitemnameonly = selecteditem.Split('-')[0].Trim();  // split the string and only get the name like key

                if (itemandprice.ContainsKey(getitemnameonly))
                { // Check if the item is in the array itemandprice
                    double price = itemandprice[getitemnameonly]; //get the price              
                    orderlist.Items.RemoveAt(orderlist.SelectedIndex); // Remove the item     
                    total -= price;  // Subtract the price from the total
                    totalprice.Text = $"₱{total}"; //print the new total 
                    ordernotif.Text = $"{getitemnameonly} is removed from the order."; //notification
                }
            }
        }

        //vouchers
        private void vouchers_SelectedIndexChanged(object sender, EventArgs e)
        {          
            string selectedvoucher = vouchers.SelectedItem.ToString(); //vouchers subtracts the order
            if (itemandprice.ContainsKey(selectedvoucher))
            {
                // Check if the selected voucher is already in the order list
                bool voucherAlreadyInOrder = orderlist.Items.Cast<string>().Any(item => item.StartsWith(selectedvoucher));

                if (voucherAlreadyInOrder)
                {
                    // Display a message to inform the user that the voucher is already in the order
                    MessageBox.Show("Voucher is already in the order. You can't add it again.");
                }
                else if (itemandprice.ContainsKey(selectedvoucher))
                {//check if the voucher is present in the array
                    double price = itemandprice[selectedvoucher]; //get the price 
                    string itempricedisplay = $"{selectedvoucher} - ₱{price}"; //display
                    orderlist.Items.Add(itempricedisplay); //add in list
                    total -= price; //subtract
                    ordernotif.Text = $"{selectedvoucher} is added to give discount."; //notif
                    totalprice.Text = $"₱{total}"; //display
                }
            }
        }
    }
}
