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
    public partial class Packages : Form, IPackages
    {
        public Packages()
        {
            InitializeComponent();
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();

            myCon.Close();
        }
        public DataTable gridView
        {
            get
            {
                return (DataTable)dataGridView1.DataSource;
            }
            set
            {
                dataGridView1.DataSource = value;
            }
        }
        private void Packages_Load(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            //PARIS
            if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu2();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu3();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu4();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu5();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu6();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu7();
            }
            else if (MainPagePresenter.mainPageView.Paris_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu8();
            }
            //MILANO
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu2();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu3();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu4();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu5();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu6();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu7();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu8();
            }
            //BARCELONA
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu2();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu3();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu4();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu5();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu6();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu7();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu8();
            }
            //LONDON
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu2();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu3();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu4();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu5();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu6();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu7();
            }
            else if (MainPagePresenter.mainPageView.London_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu8();
            }
            //BERLIN
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu2();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu3();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu4();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu5();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu6();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu7();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu8();
            }
            //ABU DHABI
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu2();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu3();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu4();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu5();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu6();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu7();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu8();
            }
            //AMSTERDAM
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu2();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu3();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu4();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu5();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu6();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu7();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu8();
            }
            //ANKARA
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu2();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu3();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu4();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu5();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu6();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu7();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu8();
            }
            //BELGRAD
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu2();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu3();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu4();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu5();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu6();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu7();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu8();
            }
            //BRUSSELS
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu2();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu3();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu4();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu5();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu6();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu7();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Brussels_menu8();
            }
            //BUDAPEST
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu2();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu3();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu4();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu5();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu6();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu7();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu8();
            }
            //COPENHAGA
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu2();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu3();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu4();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu5();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu6();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu7();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu8();
            }
            //OSLO
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu2();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu3();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu4();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu5();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu6();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu7();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu8();
            }
            //PRAGA
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_2 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu2();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu3();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_1 && MainPagePresenter.mainPageView.PetFriendly_Yes)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu4();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu5();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_3 && MainPagePresenter.mainPageView.Rooms_3 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_2 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu6();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_ClujNapoca && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu7();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu && MainPagePresenter.mainPageView.CityOfDeparture_Bucharest && MainPagePresenter.mainPageView.Nights_5 && MainPagePresenter.mainPageView.Rooms_1 && MainPagePresenter.mainPageView.Adults_2 && MainPagePresenter.mainPageView.Children_0 && MainPagePresenter.mainPageView.PetFriendly_No)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu8();
            }
            else
            {
                MessageBox.Show("We don't have offers for these options, please try select other options!");
            }
            myCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ckeckout_ checkout = new Ckeckout_();
            checkout.Show();

        }
    }
}
