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
    interface IMainPage
    {
        string Destination
        {
            get; set;
        }
        string DepartureCity
        {
            get; set;
        }
        string Transport
        {
            get; set;
        }
        DateTime Date
        {
            get; set;
        }
        int Nights
        {
            get; set;
        }
        int Rooms
        {
            get; set;
        }
        int Adults
        {
            get; set;
        }
        int Children
        {
            get; set;
        }
        string Pet
        {
            get; set;
        }
    }
}
