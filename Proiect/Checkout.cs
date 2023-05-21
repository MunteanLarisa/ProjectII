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
    public partial class Checkout : Form, ICheckout
    {
        public Checkout()
        {
            InitializeComponent();
        }

        
        string ICheckout.FirstName { get => textBox1.Text; set => textBox1.Text = value; }
        string ICheckout.LastName { get => textBox2.Text; set => textBox2.Text = value; }
        string ICheckout.Email { get => textBox3.Text; set => textBox3.Text = value; }
        string ICheckout.PhoneNumber { get => textBox4.Text; set => textBox4.Text = value; }
        string ICheckout.CountryOfResidence { get => textBox5.Text; set => textBox5.Text = value; }
        string ICheckout.Day { get => textBox6.Text; set => textBox6.Text = value; }
        string ICheckout.Month { get => textBox7.Text; set => textBox8.Text = value; }
        string ICheckout.Year { get => textBox8.Text; set => textBox8.Text = value; }
        string ICheckout.ErrorMessageCheckout { get => errorMessageCheckout.Text; set => errorMessageCheckout.Text = value; }
        bool ICheckout.ShowErrorMessageCheckout { get => errorMessageCheckout.Visible; set => errorMessageCheckout.Visible = value; }
        public event EventHandler? CheckoutAttempted;

        

        private void button1_Click(object sender, EventArgs e)
        {
            CheckoutPresenter presenter = new CheckoutPresenter(this);
            presenter.Checkout();
        }
    }
}
