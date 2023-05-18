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
using System.Net.Mail;

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
            // Email
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlCommand email = new SqlCommand("Select FirstNAME,LastName FROM Customer Where Email = @Email", myCon);
            email.Parameters.AddWithValue("@Email", checkout.Email);
            string searchemail = (string)email.ExecuteScalar();
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(" ");
            mail.To.Add(searchemail);
            mail.Subject = "Holiday package";
            mail.Body = "Hello! Thank you for chosing SeeTheWorld travel agency for your next vacantion! For any questions, don'T hesitate to write an email!";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(" ", " ");
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("An email has been send to:" + searchemail);

            checkout.FirstName = null;
            checkout.LastName = null;
            checkout.Email = null;
            myCon.Close();
          
        }
    }
}
