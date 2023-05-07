using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Proiect.Presenters
{
    public class LoginPresenter 
    {
        ILogin loginView;

        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }
 
        public void LoginButton()
        {
            if (loginView.Password != string.Empty || loginView.Username != string.Empty)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                cn.Open(); 
                SqlCommand cmd = new SqlCommand("select * from Login where username='" + loginView.Username + "' and password='" + loginView.Password + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    Form2 f2 = new Form2();
                    Form1 f1 = new Form1(); 
                    f1.Show(); 
                    f2.Close(); 
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
            }
            
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void SignUpButton()
        {

            if (loginView.ConfPassword != string.Empty || loginView.Password != string.Empty || loginView.Username != string.Empty)
            {
                if (loginView.Password == loginView.ConfPassword)
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                    cn.Open();
                        
                    SqlCommand cmd = new SqlCommand("select * from Login where username='" + loginView.Username + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Login values (@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", loginView.Username);
                        cmd.Parameters.AddWithValue("password", loginView.Password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    }
}
