using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proiect.Presenters
{
    public class CheckoutPresenter
    {
        private readonly ICheckout checkout;
        public CheckoutPresenter(ICheckout view)
        {
            checkout = view;
            checkout.CheckoutAttempted += checkoutCheckoutAttempted;
        }
        public void checkoutCheckoutAttempted(object? sender, EventArgs e)
        {
            checkout.ShowErrorMessageCheckout = false;
            checkout.ErrorMessageCheckout = null;
            if (string.IsNullOrEmpty(checkout.FirstName))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "First Name field cannot be empty";
            }


            if (string.IsNullOrEmpty(checkout.LastName))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Last Name field cannot be empty";
            }

            if (string.IsNullOrEmpty(checkout.Email))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Email field cannot be empty";
            }
            if (string.IsNullOrEmpty(checkout.PhoneNumber))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Phone Number field cannot be empty";
            }
            if (string.IsNullOrEmpty(checkout.Day))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Day field cannot be empty";
            }
            if (string.IsNullOrEmpty(checkout.Month))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Month field cannot be empty";
            }
            if (string.IsNullOrEmpty(checkout.Year))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Year field cannot be empty";
            }
            if (!string.IsNullOrEmpty(checkout.Email) && !checkout.Email.Contains("@"))
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Email field must contain @ character";
            }
            if (!string.IsNullOrEmpty(checkout.PhoneNumber) && checkout.PhoneNumber.Length > 10)
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "Phone number must not contain more than 10 digits";
            }
            if (!string.IsNullOrEmpty(checkout.Year) && (2023-Int32.Parse(checkout.Year)<18) )
            {
                checkout.ShowErrorMessageCheckout = true;
                checkout.ErrorMessageCheckout = "You must be over 18 years old";
            }
            
        }
        public void Checkout()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True"); 
            myCon.Open();

            if (checkout.FirstName != string.Empty || checkout.LastName != string.Empty || checkout.Email != string.Empty || checkout.CountryOfResidence != string.Empty || checkout.Day != string.Empty || checkout.Month != string.Empty || checkout.Year != string.Empty)
            {

                    SqlCommand cmd = new SqlCommand("select * from Customer where Email='" + checkout.Email + "'", myCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Your checkout is already saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                    else
                    {
                        dr.Close();
                        SqlCommand command = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Email, CountryOfResidence, Day, Month, Year) VALUES (@FirstName, @LastName, @Email, @CountryOfResidence,@Day,@Month, @Year)", myCon);
                        command.Parameters.Add("@FirstName", SqlDbType.Text).Value = checkout.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.Text).Value = checkout.LastName;
                        command.Parameters.Add("@Email", SqlDbType.Text).Value = checkout.Email;
                        command.Parameters.Add("@CountryOfResidence", SqlDbType.Text).Value = checkout.CountryOfResidence;
                        command.Parameters.Add("@Day", SqlDbType.Text).Value = checkout.Day;
                        command.Parameters.Add("@Month", SqlDbType.Text).Value = checkout.Month;
                        command.Parameters.Add("@Year", SqlDbType.Text).Value = checkout.Year;
                        MessageBox.Show("Checkout complet! An agent will contact you as soon as possible!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
               
            }
            else
            {
                MessageBox.Show("Please complete all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      
           
            myCon.Close();
        }
    }
}
