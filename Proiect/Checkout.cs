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

        public string FirstName { get => textBox1.Text; set => textBox1.Text=value; }
        public string LastName { get => textBox2.Text; set => textBox2.Text=value; }
        public string Email { get => textBox3.Text; set => textBox3.Text=value; }
        public string CountryOfResidence { get => textBox5.Text; set => textBox5.Text=value; }
        public string Day { get => textBox6.Text; set => textBox6.Text=value; }
        public string Month { get => textBox7.Text; set => textBox8.Text=value; }
        public string Year { get => textBox8.Text; set => textBox8.Text=value; }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckoutPresenter presenter = new CheckoutPresenter(this);
            presenter.Checkout();
        }
    }
}
