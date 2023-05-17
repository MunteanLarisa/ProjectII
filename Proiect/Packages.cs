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
            if (MainPagePresenter.mainPageView.Paris_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Paris_menu();
            }
            else if (MainPagePresenter.mainPageView.Milano_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Milano_menu();
            }
            else if (MainPagePresenter.mainPageView.Barcelona_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Barcelona_menu();
            }
            else if (MainPagePresenter.mainPageView.London_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.London_menu();
            }
            else if (MainPagePresenter.mainPageView.Berlin_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Berlin_menu();
            }
            else if (MainPagePresenter.mainPageView.AbuDhabi_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.AbuDhabi_menu();
            }
            else if (MainPagePresenter.mainPageView.Amsterdam_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Amsterdam_menu();
            }
            else if (MainPagePresenter.mainPageView.Ankara_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Ankara_menu();
            }
            else if (MainPagePresenter.mainPageView.Belgrad_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Belgrad_menu();
            }
            else if (MainPagePresenter.mainPageView.Bruxelles_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Bruxelles_menu();
            }
            else if (MainPagePresenter.mainPageView.Budapest_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Budapest_menu();
            }
            else if (MainPagePresenter.mainPageView.Copenhaga_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Copenhaga_menu();
            }
            else if (MainPagePresenter.mainPageView.Oslo_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Oslo_menu();
            }
            else if (MainPagePresenter.mainPageView.Praga_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(PackagesPresenter.mainPageView, this);
                presenter.Praga_menu();
            }
            else MessageBox.Show("Please select a destination!");
            //string msg1 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in MainPagePresenter.mainPageView.Destinations)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg1 = menuItem.ToString();
            //    }
            //}
            //string msg2 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableCitiesToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg2 = menuItem.Text;
            //    }
            //}
            //string msg3 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg3 = menuItem.Text;
            //    }
            //}
            //string msg4 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem1.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg4 = menuItem.Text;
            //    }
            //}
            //string msg5 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg5 = menuItem.Text;
            //    }
            //}
            //string msg6 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem1.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg6 = menuItem.Text;
            //    }
            //}
            //string msg7 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem2.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg7 = menuItem.Text;
            //    }
            //}
            myCon.Close();
        }
    }
}
