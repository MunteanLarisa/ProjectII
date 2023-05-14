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

        public string Destination_Paris { get => parisToolStripMenuItem.Text; set => availableDestinationsToolStripMenuItem.Text = value; }
        public string DepartureCity{ get => menuStrip_Departure.Text; set =>  menuStrip_Departure.Text = value; }
        public string Transport { get => menuStrip_Transport.Text; set => menuStrip_Transport.Text = value; }
        public DateTime Date{ get => Convert.ToDateTime(menuStrip_DepartureDate.Text); set => menuStrip_DepartureDate.Text = value.ToString();}
        public int Nights{ get => Convert.ToInt32(menuStrip_NoOfNights.Text); set => menuStrip_NoOfNights.Text = value.ToString();}
        public int Rooms { get => Convert.ToInt32(menuStrip_NoOfRooms); set => menuStrip_NoOfRooms.ToString(); }
        public int Adults { get => Convert.ToInt32(menuStrip_Adults); set => menuStrip_Adults.ToString(); }
        public int Children { get => Convert.ToInt32(menuStrip_Children); set => menuStrip_Children.ToString(); }
        public string Pet { get => menuStrip_PetFriendly.Text; set => menuStrip_PetFriendly.Text = value.ToString(); }
        public int Budget { get => Convert.ToInt32(menuStrip_bugete); set => menuStrip_bugete.ToString(); }
        public bool Paris_submenu { get => parisToolStripMenuItem.Checked; set => parisToolStripMenuItem.ToString();}
        public bool Milano_submenu { get => milanoToolStripMenuItem.Checked; set => milanoToolStripMenuItem.ToString(); }
        public bool Barcelona_submenu { get => barcelonaToolStripMenuItem.Checked; set => barcelonaToolStripMenuItem.ToString(); }
        public bool London_submenu { get => londonToolStripMenuItem.Checked; set => londonToolStripMenuItem.ToString(); }
        public bool Berlin_submenu { get => berlinToolStripMenuItem.Checked; set => berlinToolStripMenuItem.ToString(); }
        public bool AbuDhabi_submenu { get => abuDhabiToolStripMenuItem.Checked; set =>abuDhabiToolStripMenuItem.ToString(); }
        public bool Amsterdam_submenu { get => amsterdamToolStripMenuItem.Checked; set => amsterdamToolStripMenuItem.ToString(); }
        public bool Ankara_submenu { get => ankaraToolStripMenuItem.Checked; set => ankaraToolStripMenuItem.ToString(); }
        public bool Belgrad_submenu { get => belgradToolStripMenuItem.Checked; set => belgradToolStripMenuItem.ToString(); }
        public bool Bruxelles_submenu { get => bruxellesToolStripMenuItem.Checked; set =>bruxellesToolStripMenuItem.ToString(); }
        public bool Budapest_submenu { get => budapestToolStripMenuItem.Checked; set => budapestToolStripMenuItem.ToString(); }
        public bool Copenhaga_submenu { get => copenhagaToolStripMenuItem.Checked; set => copenhagaToolStripMenuItem.ToString(); }
        public bool Oslo_submenu { get => osloToolStripMenuItem.Checked; set => osloToolStripMenuItem.ToString(); }
        public bool Praga_submenu { get => pragaToolStripMenuItem.Checked; set => pragaToolStripMenuItem.ToString(); }


        private void MainPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn2.Open();
            cn2.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainPagePresenter presenter = new MainPagePresenter(this);
            presenter.Search();
        }
        private void parisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parisToolStripMenuItem.Checked = true;
            
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
            carToolStripMenuItem.Checked = false;
            planeToolStripMenuItem.Checked = false;
            trainToolStripMenuItem.Checked = false;
            busToolStripMenuItem.Checked = false;
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

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carToolStripMenuItem.Checked = true;
        }

        private void planeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planeToolStripMenuItem.Checked = true;
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainToolStripMenuItem.Checked = true;
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busToolStripMenuItem.Checked = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            HotDeals_Ankara h = new HotDeals_Ankara();
            h.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            HotDeals_Budapest h = new HotDeals_Budapest();
            h.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            HotDeals_Bucharest h = new HotDeals_Bucharest();
            h.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            HotDeals_Bruxelles h = new HotDeals_Bruxelles();
            h.Show();
        }
    }
}