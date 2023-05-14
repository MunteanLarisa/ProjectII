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
    public partial class SignUp : Form, IRegister
    {
        public string Username 
        {
            get
            {
                return txtUsername.Text;
            }
            set
            {
                txtUsername.Text = value;
            }

        }
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
            set
            {
                txtPassword.Text = value;
            }
        }
        public string ConfPassword
        {
            get
            {
                return txtConfirmPass.Text;
            }
            set
            {
                txtConfirmPass.Text = value;
            }
        }

        public SignUp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn.Open();

            cn.Close();

        }
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            RegisterPresenter presenter = new RegisterPresenter(this);
            presenter.SignUpButton();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

           
        }

       
    }
}
