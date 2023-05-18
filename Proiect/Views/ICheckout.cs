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
    interface ICheckout
    {
        String FirstName { get; set; }
        String LastName { get; set; }
        String Email { get; set; }
        String CountryOfResidence { get; set; }
        String Day { get; set; }
        String Month { get; set; }
        String Year { get; set; }
    }
}
