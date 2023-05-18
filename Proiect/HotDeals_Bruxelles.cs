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
    public partial class HotDeals_Bruxelles : Form, IHotDealsBruxelles
    {
        public HotDeals_Bruxelles()
        {
            InitializeComponent();
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

        private void HotDeals_Bruxelles_Load(object sender, EventArgs e)
        {
            HotDealsBruxellesPresenter presenter = new HotDealsBruxellesPresenter(this);
            presenter.Populate();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
