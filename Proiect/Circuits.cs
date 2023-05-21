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
    public partial class Circuits : Form, ICircuits
    {
        public Circuits()
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

        private void Circuits_Load(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open(); 
            if (MainPagePresenter.mainPageView.Budget100_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(CircuitsPresenter.mainPageView,this);
                presenter.Budget100();
            }
            else if (MainPagePresenter.mainPageView.Budget300_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(CircuitsPresenter.mainPageView, this);
                presenter.Budget300();
            }
            else if (MainPagePresenter.mainPageView.Budget500_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(CircuitsPresenter.mainPageView, this);
                presenter.Budget500();
            }
            else if (MainPagePresenter.mainPageView.Budget700_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(CircuitsPresenter.mainPageView, this);
                presenter.Budget700();
            }
            else if (MainPagePresenter.mainPageView.Budget900_submenu)
            {
                MainPagePresenter presenter = new MainPagePresenter(CircuitsPresenter.mainPageView, this);
                presenter.Budget900();
            }
            myCon.Close();
        }

        private void btn_ExoticCircuitsMaldives_Click(object sender, EventArgs e)
        {
            Checkout f = new Checkout();
            f.Show();
        }
    }
}
