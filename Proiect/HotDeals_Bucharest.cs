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
    public partial class HotDeals_Bucharest : Form, IHotDealsBucharest
    {
        public HotDeals_Bucharest()
        {
            InitializeComponent();
        }

        public DataTable gridView { get => (DataTable)dataGridView2.DataSource; set => dataGridView2.DataSource = value; }

        private void HotDeals_Bucharest_Load(object sender, EventArgs e)
        {
            HotDealsBucharestPresenter presenter = new HotDealsBucharestPresenter(this);
            presenter.Populate();
        }
    }
}
