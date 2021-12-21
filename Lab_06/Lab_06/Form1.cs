using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Form1 : Form
    {
        List<User> Users = new List<User>();
        List<Order> Wash = new List<Order>();


        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountOnClick(object sender, EventArgs e)
        {
            int User_ID = Convert.ToInt32(User_IDTextbox.Text);
            string Name = NameTextbox.Text;
            string Address = AddressTextbox.Text;
            User dummy_user = new User(User_ID, Name, Address);
            Users.Add(dummy_user);
            MessageBox.Show("Account Created Successfully!");

        }

        private void PlaceOrderOnClick(object sender, EventArgs e)
        {
            int User_ID = Convert.ToInt32(UserIDTextbox.Text);
            int Shirt = Convert.ToInt32(shirtTextbox.Text);
            string Shirt_type = shirtCombo.Text;
            int Pant = Convert.ToInt32(PantTextbox.Text);
            string Pant_type = PantCombo.Text;

            int Suit = Convert.ToInt32(SuitTextbox.Text);
            string Suit_type = SuitCOmbo.Text;
            int Bed_sheet = Convert.ToInt32(BedsheetTextbox.Text);
            string Bedsheet_type = BedsheetCombo.Text;
            int shirt_amount = Convert.ToInt32(shirtTextbox.Text) * 10;
            int pant_amount = Convert.ToInt32(PantTextbox.Text) * 12;
            int suit_amount = Convert.ToInt32(SuitTextbox.Text) * 8;
            int bedsheet_amount = Convert.ToInt32(BedsheetTextbox.Text) * 6;
            Order dummy_wash = new Order(User_ID,Shirt, Pant, Suit,Bed_sheet, Shirt_type, Pant_type, Suit_type, Bedsheet_type,shirt_amount,pant_amount,suit_amount,bedsheet_amount);
            Wash.Add(dummy_wash);
            MessageBox.Show("Order Placed Successfully");
            foreach( Order ord in Wash)
            {
                if( ord.User_ID == dummy_wash.User_ID)
                {
                     dummy_wash.Amount = (dummy_wash.Shirt * 10) + (dummy_wash.Pant * 12) + (dummy_wash.Suit * 8) + (dummy_wash.Bed_Sheet * 6);
                }
            }
        }

        

        private void Set_StatusOnClick(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(OrderIDTextbox.Text);
            LaundryListBox.Items.Clear();
            foreach (Order Order in Wash)
            {
                if(ID == Order.User_ID)
                {
                    MessageBox.Show("Status Updated!");
                    Current_BalanceLabel.Text = "Current Balance" + " " + Order.Amount.ToString();
                    
                }
                
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LaundryListBox.Items.Clear();
            int User_ID = Convert.ToInt32(IDTextbox.Text);
            string Order_Combo = OrderCOmbo.Text;
            string Name = NameTextbox.Text;
            string Address = AddressTextbox.Text;
            foreach (Order order in Wash)
            {
                if (User_ID == order.User_ID)
                {
                    LaundryListBox.Items.Add(order.getInfo1());
                    LaundryListBox.Items.Add(order.getInfo2());
                    LaundryListBox.Items.Add(order.getInfo3());
                    LaundryListBox.Items.Add(order.getInfo4());

                    statusLabel.Text = "Satus:" + "  " + Order_Combo.ToString();
                    AmountLabel.Text = "Amount: " + "  " + order.Amount.ToString();
                    label14.Text = "Name: " + "  " + Name.ToString();
                    label15.Text = "Address: " + "  " + Address.ToString();
                }
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
                    }

        private void LaundryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear1OnClick(object sender, EventArgs e)
        {
            UserIDTextbox.Text = string.Empty;
            shirtTextbox.Text = string.Empty;
            PantTextbox.Text = string.Empty;
            SuitTextbox.Text = string.Empty;
            BedsheetTextbox.Text = string.Empty;
            MessageBox.Show("Cleared Successfully!");
        }

        private void Clear2OnClick(object sender, EventArgs e)
        {
            User_IDTextbox.Text = string.Empty;
            NameTextbox.Text = string.Empty;
            AddressTextbox.Text = string.Empty;
            MessageBox.Show("Cleared");
        }
    }
}
