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
using Proiect.Models;
using Proiect.Presenters;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class Ckeckout_ : Form, ICheckout
    {
        public Ckeckout_()
        {
            InitializeComponent();
        }

        public string FirstName { get => textBox_firstName.Text; set => textBox_firstName.Text=value; }
        public string LastName { get => textBox_lastName.Text; set => textBox_lastName.Text=value; }
        public string Email { get => textBox_email.Text; set => textBox_email.Text=value; }

        private void Send_Click(object sender, EventArgs e)
        {
            CheckoutPresenter presenter = new CheckoutPresenter(this);
            presenter.Checkout();
        }
    }
}
