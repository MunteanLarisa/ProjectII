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

    public partial class MainPage : Form, IMainPage
    {

   
        public MainPage()

        {
            InitializeComponent();
        }

        public string Destination_Paris 
        {
            get
            {
                return parisToolStripMenuItem.Text;
            }
            set
            {
                availableDestinationsToolStripMenuItem.Text = value;
            }
        }
        public string DepartureCity
        {
            get
            {
                return menuStrip_Departure.Text;
            }
            set
            {
                menuStrip_Departure.Text = value;
            }
        }
        public string Transport
        {
            get
            {
                return menuStrip_Transport.Text;
            }
            set
            {
                menuStrip_Transport.Text = value;
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
        public string Pet { get => menuStrip_PetFriendly.Text; set => menuStrip_PetFriendly.Text = value.ToString(); }
        public int Budget { get => Convert.ToInt32(menuStrip_bugete); set => menuStrip_bugete.ToString(); }

        //bool IMainPage.pictureBox
        //{
        //   get
        //   {
        //    return Convert.ToBoolean(pictureBox6);
        // }
        //  set => Convert.ToBoolean(pictureBox6);
        // }



        private void MainPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn2.Open();
            
            cn2.Close();
            //MainPagePresenter presenter = new MainPagePresenter(this);
            //presenter.Destination();
         
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Paris();
        }
        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Ankara();
        }
        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Budapest();
        }
        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bucharest();
        }
        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bruxelles();
        }

    
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.BoraBora();
        }

        private void pictureBox21_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Bali();
        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Dubai();
        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Maldives();
        }
     

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //if (pictureBox6.Click)
           // {

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Search();
        }

        private void clujNapocaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MainPagePresenter presenter = new MainPagePresenter(this);
            //presenter.Departure_ClujNapoca();
        }

        private void parisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parisToolStripMenuItem.Checked = true;
            
        }

        private void availableDestinationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              //if (parisToolStripMenuItem.Checked == true)
              //{
              //    Destination_PA = "Paris";
              //}
       }

        private void milanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            milanoToolStripMenuItem.Checked = true;
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parisToolStripMenuItem.Checked = false;
            milanoToolStripMenuItem.Checked = false;
            barcelonaToolStripMenuItem.Checked = false;
            londonToolStripMenuItem.Checked = false;
            berlinToolStripMenuItem.Checked = false;
            abuDhabiToolStripMenuItem.Checked = false;
            amsterdamToolStripMenuItem.Checked = false;
            ankaraToolStripMenuItem.Checked = false;
            belgradToolStripMenuItem.Checked = false;
            bruxellesToolStripMenuItem.Checked = false;
            budapestToolStripMenuItem.Checked = false;
            copenhagaToolStripMenuItem.Checked = false;
            osloToolStripMenuItem.Checked = false;
            pragaToolStripMenuItem.Checked = false;
          
        }

        private void barcelonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barcelonaToolStripMenuItem.Checked = true;
        }

        private void londonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            londonToolStripMenuItem.Checked = true;
        }

        private void berlinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            berlinToolStripMenuItem.Checked = true;
        }

        private void abuDhabiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abuDhabiToolStripMenuItem.Checked = true;
        }

        private void amsterdamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amsterdamToolStripMenuItem.Checked = true;
        }

        private void ankaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ankaraToolStripMenuItem.Checked = true;
        }

        private void belgradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            belgradToolStripMenuItem.Checked = true;
        }

        private void bruxellesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bruxellesToolStripMenuItem.Checked = true;
        }

        private void budapestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            budapestToolStripMenuItem.Checked = true;
        }

        private void copenhagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copenhagaToolStripMenuItem.Checked = true;
        }

        private void osloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osloToolStripMenuItem.Checked = true;
        }

        private void pragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pragaToolStripMenuItem.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Circuits c = new Circuits();
            c.Show();
        }
    }
}