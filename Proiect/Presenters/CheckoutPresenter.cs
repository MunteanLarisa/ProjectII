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
    class CheckoutPresenter
    {
        ICheckout checkout;
        public CheckoutPresenter(ICheckout view)
        {
            checkout = view;
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
                MessageBox.Show("PLease complete all fileds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      
           
            myCon.Close();
        }
    }
}
