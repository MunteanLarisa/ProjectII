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
    public partial class HotDeals_Ankara : Form, IHotDealsAnkara
    {
  
        public HotDeals_Ankara()
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
                return (DataTable)dataGridView_Ankara.DataSource;
            }
            set
            {
                dataGridView_Ankara.DataSource = value;
            }
        }
        
        private void HotDeals_Ankara_Load(object sender, EventArgs e)
        {
            HotDealsAnkaraPresenter presenter = new HotDealsAnkaraPresenter(this);
            presenter.Populate();
        }
   
    }
}
