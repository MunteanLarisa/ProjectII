using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Views;
using Proiect.Models;
using Proiect.Presenters;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect
{
    public partial class HotDeals_Budapest : Form, IHotDealsBudapest
    {
        public HotDeals_Budapest()
        {
            InitializeComponent();
        }

        public DataTable gridView { get => (DataTable)dataGridView1.DataSource; set => dataGridView1.DataSource = value; }

        private void HotDeals_Budapest_Load(object sender, EventArgs e)
        {
            HotDealsBudapestPresenter presenter = new HotDealsBudapestPresenter(this);
            presenter.Populate();
        }
    }
}
