using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Views;
using Proiect.Presenters;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class Login : Form, ILogin
    {
        private LoginPresenter loginPresenter;
        public Login()
        {
            InitializeComponent();
            this.loginPresenter = new LoginPresenter(this);


        }

        public string LoginUsername 
        { 
            get
            {
                return textBox_userName.Text;
            }
            set
            {
                textBox_userName.Text = value;
            }

        }
        public string LoginPassword 
        {
            get
            {
                return textBox_password.Text;
            }
            set
            {
                textBox_password.Text = value;
            }
        }

        String ILogin.LoginUsername { get => textBox_userName.Text; set => textBox_userName.Text = value; }
        String ILogin.LoginPassword { get => textBox_password.Text; set => textBox_password.Text = value; }
        String ILogin.ErrorMessageLogin { get => ErrorMessageLogin.Text; set => ErrorMessageLogin.Text = value; }
        bool ILogin.ShowErrorMessageLogin { get => ErrorMessageLogin.Visible; set => ErrorMessageLogin.Visible = value; }

        public event EventHandler? LoginAttempted;

        private void button_Login_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.LoginButton();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn2.Open();

            cn2.Close();
        }
    }
}
