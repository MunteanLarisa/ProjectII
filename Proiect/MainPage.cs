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

        public string Destination_Paris { get => availableDestinationsToolStripMenuItem.Text; set => availableDestinationsToolStripMenuItem.Text = value; }
        public string DepartureCity { get => availableCitiesToolStripMenuItem.Text; set => availableCitiesToolStripMenuItem.Text = value; }
        public string Transport { get => availableTarnsportToolStripMenuItem.Text; set => availableTarnsportToolStripMenuItem.Text = value; }
        public DateTime Date { get => Convert.ToDateTime(menuStrip_DepartureDate.Text); set => menuStrip_DepartureDate.Text = value.ToString(); }
        public int Nights { get => Convert.ToInt32(menuStrip_NoOfNights.Text); set => menuStrip_NoOfNights.Text = value.ToString(); }
        public int Rooms { get => Convert.ToInt32(menuStrip_NoOfRooms); set => menuStrip_NoOfRooms.ToString(); }
        public int Adults { get => Convert.ToInt32(menuStrip_Adults); set => menuStrip_Adults.ToString(); }
        public int Children { get => Convert.ToInt32(menuStrip_Children); set => menuStrip_Children.ToString(); }
        public string Pet { get => menuStrip_PetFriendly.Text; set => menuStrip_PetFriendly.Text = value.ToString(); }
        public int Budget { get => Convert.ToInt32(menuStrip_bugete); set => menuStrip_bugete.ToString(); }
        public bool Paris_submenu { get => parisToolStripMenuItem.Checked; set => parisToolStripMenuItem.ToString(); }
        public bool Milano_submenu { get => milanoToolStripMenuItem.Checked; set => milanoToolStripMenuItem.ToString(); }
        public bool Barcelona_submenu { get => barcelonaToolStripMenuItem.Checked; set => barcelonaToolStripMenuItem.ToString(); }
        public bool London_submenu { get => londonToolStripMenuItem.Checked; set => londonToolStripMenuItem.ToString(); }
        public bool Berlin_submenu { get => berlinToolStripMenuItem.Checked; set => berlinToolStripMenuItem.ToString(); }
        public bool AbuDhabi_submenu { get => abuDhabiToolStripMenuItem.Checked; set => abuDhabiToolStripMenuItem.ToString(); }
        public bool Amsterdam_submenu { get => amsterdamToolStripMenuItem.Checked; set => amsterdamToolStripMenuItem.ToString(); }
        public bool Ankara_submenu { get => ankaraToolStripMenuItem.Checked; set => ankaraToolStripMenuItem.ToString(); }
        public bool Belgrad_submenu { get => belgradToolStripMenuItem.Checked; set => belgradToolStripMenuItem.ToString(); }
        public bool Bruxelles_submenu { get => bruxellesToolStripMenuItem.Checked; set => bruxellesToolStripMenuItem.ToString(); }
        public bool Budapest_submenu { get => budapestToolStripMenuItem.Checked; set => budapestToolStripMenuItem.ToString(); }
        public bool Copenhaga_submenu { get => copenhagaToolStripMenuItem.Checked; set => copenhagaToolStripMenuItem.ToString(); }
        public bool Oslo_submenu { get => osloToolStripMenuItem.Checked; set => osloToolStripMenuItem.ToString(); }
        public bool Praga_submenu { get => pragaToolStripMenuItem.Checked; set => pragaToolStripMenuItem.ToString(); }
        public bool Budget100_submenu { get => toolStripMenuItem_100.Checked; set => toolStripMenuItem_100.ToString(); }
        public bool Budget300_submenu { get => toolStripMenuItem_300.Checked; set => toolStripMenuItem_300.ToString(); }
        public bool Budget500_submenu { get => toolStripMenuItem_500.Checked; set => toolStripMenuItem_500.ToString(); }
        public bool Budget700_submenu { get => toolStripMenuItem_700.Checked; set => toolStripMenuItem_700.ToString(); }
        public bool Budget900_submenu { get => toolStripMenuItem_900.Checked; set => toolStripMenuItem_900.ToString(); }


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

    private void button11_Click(object sender, EventArgs e)
    {
         MainPagePresenter presenter = new MainPagePresenter(this);
         presenter.Search2();
    }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            ExoticCircuits_BoraBora c = new ExoticCircuits_BoraBora();
            c.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            ExoticCircuits_Bali c = new ExoticCircuits_Bali();
            c.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            ExoticCircuits_Dubai c = new ExoticCircuits_Dubai();
            c.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ExoticCircuits_Maldives c = new ExoticCircuits_Maldives();
            c.Show();
        }
    }
}

