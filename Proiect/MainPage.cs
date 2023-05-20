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
     

        public ToolStripItemCollection Destinations { get => availableDestinationsToolStripMenuItem.DropDownItems; set => availableDestinationsToolStripMenuItem.ToString(); }
        public string DepartureCity { get => availableCitiesToolStripMenuItem.Text; set => availableCitiesToolStripMenuItem.Text = value; }
        public int Nights { get => Convert.ToInt32(menuStrip_NoOfNights.Text); set => menuStrip_NoOfNights.Text = value.ToString(); }
        public int Rooms { get => Convert.ToInt32(menuStrip_NoOfRooms); set => menuStrip_NoOfRooms.ToString(); }
        public int Adults { get => Convert.ToInt32(menuStrip_Adults); set => menuStrip_Adults.ToString(); }
        public int Children { get => Convert.ToInt32(menuStrip_Children); set => menuStrip_Children.ToString(); }
        public string Pet { get => menuStrip_PetFriendly.Text; set => menuStrip_PetFriendly.Text = value.ToString(); }
        public int Budget { get => Convert.ToInt32(menuStrip_bugete); set => menuStrip_bugete.ToString(); }
        public bool Paris_submenu { get => parisToolStripMenuItem.Checked; set => parisToolStripMenuItem.GetType(); }
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
        public bool CityOfDeparture_ClujNapoca { get => clujNapocaToolStripMenuItem.Checked; set => clujNapocaToolStripMenuItem.ToString(); }
        public bool CityOfDeparture_Bucharest { get => bucurestiToolStripMenuItem1.Checked; set => bucurestiToolStripMenuItem1.ToString(); }
        public bool Nights_3 { get => toolStripMenuNights3.Checked; set => toolStripMenuNights5.ToString(); }
        public bool Nights_5 { get => toolStripMenuNights5.Checked; set => toolStripMenuNights5.ToString(); }
        public bool Nights_7 { get => toolStripMenuNights7.Checked; set => toolStripMenuNights7.ToString(); }
        public bool Rooms_1 { get => toolStripMenuRooms1.Checked; set => toolStripMenuRooms1.ToString(); }
        public bool Rooms_2 { get => toolStripMenuRooms2.Checked; set => toolStripMenuRooms2.ToString(); }
        public bool Rooms_3 { get => toolStripMenuRooms3.Checked; set => toolStripMenuRooms3.ToString(); }
        public bool Adults_1 { get => toolStripMenuAdults1.Checked; set => toolStripMenuAdults1.ToString(); }
        public bool Adults_2 { get => toolStripMenuAdults2.Checked; set => toolStripMenuAdults2.ToString(); }
        public bool Children_0 { get => toolStripMenuChildren1.Checked; set => toolStripMenuChildren1.ToString(); }
        public bool Children_1 { get => toolStripMenuChildren2.Checked; set => toolStripMenuChildren2.ToString(); }
        public bool Children_2 { get => toolStripMenuItem2.Checked; set => toolStripMenuItem2.ToString(); }
        public bool PetFriendly_Yes { get => yesToolStripMenuItem.Checked; set => yesToolStripMenuItem.ToString(); }
        public bool PetFriendly_No { get => noToolStripMenuItem.Checked; set => noToolStripMenuItem.ToString(); }
        public String CityOfDeparture_Cluj { get => clujNapocaToolStripMenuItem.Text; set => clujNapocaToolStripMenuItem.Text=value; }

        private void MainPage_Load(object sender, EventArgs e)
    {
        SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
        cn2.Open();
        cn2.Close();
    }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            string msg1 = string.Empty;
            foreach (ToolStripMenuItem menuItem in availableDestinationsToolStripMenuItem.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg1 = menuItem.Text;
                }
            }
            string msg2 = string.Empty;
            foreach (ToolStripMenuItem menuItem in availableCitiesToolStripMenuItem.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg2 = menuItem.Text;
                }
            }
            string msg3 = string.Empty;
            foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg3 = menuItem.Text;
                }
            }
            string msg4 = string.Empty;
            foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem1.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg4 = menuItem.Text;
                }
            }
            string msg5 = string.Empty;
            foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg5 = menuItem.Text;
                }
            }
            string msg6 = string.Empty;
            foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem1.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg6 = menuItem.Text;
                }
            }
            string msg7 = string.Empty;
            foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem2.DropDownItems)
            {
                if (menuItem.Checked == true)
                {
                    msg7 = menuItem.Text;
                }
            }
            MessageBox.Show("You have chosen: \nDestination:" + msg1 + "\nDeparture city:" + msg2 + "\nNumber of nights:" + msg3 + "\nNumber of rooms:" + msg4 + "\nAdults:" + msg5 + "\nChildren: " + msg6 + "\nPet:" + msg7 + ".", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            clujNapocaToolStripMenuItem.Checked = false;
            bucurestiToolStripMenuItem1.Checked = false;
    }

    private void button6_Click(object sender, EventArgs e)
    {
            toolStripMenuNights3.Checked = false;
            toolStripMenuNights5.Checked = false;
            toolStripMenuNights7.Checked = false;
    }

    private void button7_Click(object sender, EventArgs e)
    {
            toolStripMenuRooms1.Checked = false;
            toolStripMenuRooms2.Checked = false;
            toolStripMenuRooms3.Checked = false;
    }

    private void button8_Click(object sender, EventArgs e)
    {
            toolStripMenuAdults1.Checked = false;
            toolStripMenuAdults2.Checked = false;
    }

    private void button9_Click(object sender, EventArgs e)
    {
            toolStripMenuChildren1.Checked = false;
            toolStripMenuChildren2.Checked = false;
    }

    private void button10_Click(object sender, EventArgs e)
    {
            yesToolStripMenuItem.Checked = false;
            noToolStripMenuItem.Checked = false;
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

