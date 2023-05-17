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
        ToolStripItemCollection Destinations { get ; set ; }
        string DepartureCity
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
        int Budget
        {
            get; set;
        }
        bool Paris_submenu
        {
            get;set;
        }
        bool Milano_submenu
        {
            get; set;
        }
        bool Barcelona_submenu { get; set; }
        bool London_submenu { get; set; }
        bool Berlin_submenu { get; set; }
        bool AbuDhabi_submenu { get; set; }
        bool Amsterdam_submenu { get; set; }
        bool Ankara_submenu { get; set; }
        bool Belgrad_submenu { get; set; }
        bool Bruxelles_submenu { get; set; }
        bool Budapest_submenu { get; set; }
        bool Copenhaga_submenu { get; set; }
        bool Oslo_submenu { get; set; }
        bool Praga_submenu { get; set; }
        bool Budget100_submenu { get; set; }
        bool Budget300_submenu { get; set; }
        bool Budget500_submenu { get; set; }
        bool Budget700_submenu { get; set; }
        bool Budget900_submenu { get; set; }
        bool CityOfDeparture_ClujNapoca { get; set; }
        bool CityOfDeparture_Bucharest { get; set; }
        bool Nights_3 { get; set; }
        bool Nights_5 { get; set; }
        bool Nights_7 { get; set; }
        bool Rooms_1 { get; set; }
        bool Rooms_2 { get; set; }
        bool Rooms_3 { get; set; }
        bool Adults_1 { get; set; }
        bool Adults_2 { get; set; }
        bool Children_1 { get; set; }
        bool Children_2 { get; set; }
        bool PetFriendly_Yes { get; set; }
        bool PetFriendly_No { get; set; }
        String CityOfDeparture_Cluj { get; set ; }
    }
}
