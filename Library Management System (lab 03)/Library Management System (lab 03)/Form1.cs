using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System__lab_03_
{
    public partial class Form1 : Form
    {
        List<User_History> User_History_List = new List<User_History>();
        List<Book_History> books = new List<Book_History>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserOnClick(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(U_IdTextbox.Text);
            string Name = U_NameTextbox.Text;
            string Address = U_AddressTextbox.Text;
            User_History user_dummy = new User_History(ID, Name, Address);
            User_History_List.Add(user_dummy);
            MessageBox.Show("User Added Successfully!");
        }

        private void AddBookOnClick(object sender, EventArgs e)
        {
            int B_ID = Convert.ToInt32(B_IdTextbox.Text);
            string B_Name = B_NameTextbox.Text;
            string B_Author = AuthorTextbox.Text;
            string B_Publisher = PublisherTextbox.Text;
            int B_Quantity = Convert.ToInt32(Quantity_Textbox.Text);
            Book_History book_dummy = new Book_History(B_ID, B_Name,B_Author,B_Publisher,B_Quantity);
            books.Add(book_dummy);
            MessageBox.Show("Book added successfully!");
            if(B_Quantity<0)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void BorrowBookOnClick(object sender, EventArgs e)
        {
           
            int U2_ID = Convert.ToInt32(U2_IdTextbox.Text);
            int B2_ID = Convert.ToInt32(B2_IdTextbox.Text);


            foreach (Book_History book_dummy in books)
            {
                if (book_dummy.B_Quantity > 0)
                {
                    book_dummy.B_Quantity = book_dummy.B_Quantity - 1;
                    MessageBox.Show("Borrowed!");
                }
               

                else
                {
                    MessageBox.Show("Not Enough Books!");
                }
                foreach (User_History user_dummy in User_History_List)
                {
                    if (user_dummy.ID == U2_ID)
                    {
                        user_dummy.borrow += 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User!");
                    }

                    /*
                                       bool flag = false;
                                       foreach (User_History user_dummy in User_History_List)
                                       {
                                           if (user_dummy.ID == U2_ID)
                                           {
                                               flag = true;

                                           }

                                           else
                                           {
                                               flag = false;
                                           }
                                       }
                                       foreach(Book_History book_dummy in books)
                                       {
                                           if(book_dummy.B_ID == B2_ID)
                                           {
                                               flag = true;
                                               if(book_dummy.B_Quantity <1)
                                               {
                                                   MessageBox.Show("Book is not available");
                                                   break;
                                               }
                                               book_dummy.B_Quantity -= 1;
                                               foreach(User_History user_dummy in User_History_List)
                                               {
                                                   if(user_dummy.ID == U2_ID)
                                                   {
                                                       user_dummy.books.Add(B2_ID);
                                                   }
                                               }
                                           }  
                                           else
                                           {
                                               flag = false;
                                           }
                                       }


                                       MessageBox.Show("Book Borrowed Successfully!");
                                       */
                }
            }

                private void ShowHistoryOnCLick(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(History_U_IDTextbox.Text);
            
            
            foreach(User_History user_dummy in User_History_List)
            {
                if(user_dummy.ID == ID)
                {
                    User_History_Listbox.Items.Add(user_dummy.getInfo());
                }
                else
                {
                    MessageBox.Show("Invalid User");
                    break;
                }
                User_History_Listbox.Items.Clear();
                
            

            }
        }

        private void ShowBookHistoryOnClick(object sender, EventArgs e)
        {

        }

        private void BookShowOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Book_historyTextbox.Text);
            bool flag = false;
            foreach (Book_History book_dummy in books)
            {
                if (book_dummy.B_ID == id)
                {
                    flag = true;
                    H_BookIDText.Text = "ID:" + " " + book_dummy.B_ID.ToString();
                    H_BookNameText.Text = "Name:" + " " + book_dummy.B_Name;
                    H_BookAuthorText.Text = "Author:" + " " + book_dummy.B_Author;
                    H_BookPublisherText.Text = "Publisher:" + " " + book_dummy.B_Publisher;
                    H_bookQuantityText.Text = "Quantity:" + " " + book_dummy.B_Quantity.ToString();
                }
               
            }
            if (flag == false)
            {
                MessageBox.Show("Book couldn't be found");
            }
        }
    }
}
