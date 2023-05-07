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
            if (loginView.LoginPassword != string.Empty || loginView.LoginUsername != string.Empty)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                cn.Open(); 
                SqlCommand cmd = new SqlCommand("select * from Login where username='" + loginView.LoginUsername + "' and password='" + loginView.LoginPassword + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    SignUp f1 = new SignUp();
                    f1.Close();
                    MainPage f2 = new MainPage();
                    f2.Show();
                    Login f3 = new Login();
                    f3.Close();
                   
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
       

    }
}
