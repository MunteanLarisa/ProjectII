﻿using System;
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

    public partial class MainPage : Form, IMainPage
    {


        public MainPage()

        {
            InitializeComponent();
        }

        public string Destination 
        {
            get
            {
                return menuStrip_Destination.Text;
            }
            set
            {
                menuStrip_Destination.Text = value;
            }
        }
        public string DepartureCity
        {
            get
            {
                return menuStrip_CityOfDeparture.Text;
            }
            set
            {
                menuStrip_CityOfDeparture.Text = value;
            }
        }
        public string Transport
        {
            get
            {
                return menuStrip_MeanOfTransport.Text;
            }
            set
            {
                menuStrip_MeanOfTransport.Text = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return Convert.ToDateTime(menuStrip_DepartureDate.Text);
            }
            set
            {
                menuStrip_DepartureDate.Text = value.ToString();
            }
        }
        public int Nights
        {
            get
            {
                return Convert.ToInt32(menuStrip_NoOfNights.Text);
            }
            set
            {
                menuStrip_NoOfNights.Text = value.ToString();
            }
        }
        public int Rooms { get => Convert.ToInt32(menuStrip_NoOfRooms); set => menuStrip_NoOfRooms.ToString(); }
        public int Adults { get => Convert.ToInt32(menuStrip_Adults); set => menuStrip_Adults.ToString(); }
        public int Children { get => Convert.ToInt32(menuStrip_Children); set => menuStrip_Children.ToString(); }
        public string Pet { get => menuStrip_PetFriendly.Text; set => menuStrip_PetFriendly.Text=value.ToString(); }

        private void menuStrip_Destination_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
 
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Destination();
            MessageBox.Show(e.ClickedItem.Text);
            //switch (presenter)
            //{
            //  case "menu name 1":
            //do stuff
            //    break;

            //  case "menu name 2":
            // do stuff
            //    break;
            //}
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn2.Open();

            cn2.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Barcelona();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Belgrade();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Oslo();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.AbuDhabi();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Prague();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Amsterdam();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.London();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Paris();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.DubaiC();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Ankara();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Budapest();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bucharest();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bruxelles();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.BoraBora();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bali();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Dubai();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Maldives();
        }
    }
}