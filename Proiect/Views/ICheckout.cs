using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Models;
using Proiect.Views;

namespace Proiect.Views
{
    public interface ICheckout
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String CountryOfResidence { get; set; }
        public String Day { get; set; }
        public String  Month { get; set; }
        public String  Year { get; set; }
        public String ErrorMessageCheckout { get; set; }
        public bool ShowErrorMessageCheckout { get; set; }
        public event EventHandler CheckoutAttempted;
    }
}
