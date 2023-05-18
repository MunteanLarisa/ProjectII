using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Models
{
    class MainPage
    {
        public ToolStripItemCollection Destinations { get ; set ; }
        public string DepartureCity
        {
            get; set;
        }
        public int Nights
        {
            get; set;
        }
        public int Rooms
        {
            get; set;
        }
        public int Adults
        {
            get; set;
        }
        public int Children
        {
            get; set;
        }
        public string Pet
        {
            get; set;
        }
        public int Budget
        {
            get; set;
        }
        public bool Paris_submenu
        {
            get;set;
        }
        public bool Milano_submenu
        {
            get; set;
        }
        public bool Barcelona_submenu { get; set; }
        public bool London_submenu { get ; set; }
        public bool Berlin_submenu { get ; set; }
        public bool AbuDhabi_submenu { get; set; }
        public bool Amsterdam_submenu { get; set ; }
        public bool Ankara_submenu { get; set ; }
        public bool Belgrad_submenu { get ; set; }
        public bool Bruxelles_submenu { get; set ; }
        public bool Budapest_submenu { get ; set ; }
        public bool Copenhaga_submenu { get ; set; }
        public bool Oslo_submenu { get ; set ; }
        public bool Praga_submenu { get ; set ; }
        public bool Budget100_submenu { get; set; }
        public bool Budget300_submenu { get ; set ; }
        public bool Budget500_submenu { get ; set ; }
        public bool Budget700_submenu { get; set; }
        public bool Budget900_submenu { get; set; }
        public bool CityOfDeparture_ClujNapoca { get; set; }
        public bool CityOfDeparture_Bucharest { get; set; }
        public bool Nights_3 { get; set; }
        public bool Nights_5 { get; set; }
        public bool Nights_7 { get; set; }
        public bool Rooms_1 { get; set; }
        public bool Rooms_2 { get; set; }
        public bool Rooms_3 { get; set; }
        public bool Adults_1 { get; set; }
        public bool Adults_2 { get; set; }
        public bool Children_0 { get ; set; }
        public bool Children_1 { get; set; }
        public bool Children_2 { get; set ; }
        public bool PetFriendly_Yes { get; set; }
        public bool PetFriendly_No { get; set; }
        public String CityOfDeparture_Cluj { get; set ; }


    }  
}
