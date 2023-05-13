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
            PackagesPresenter presenter = new PackagesPresenter(this);

        }
    }
}
