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
    public partial class ExoticCircuits_Dubai : Form, IExoticDubai
    {
        public ExoticCircuits_Dubai()
        {
            InitializeComponent();
        }
        public DataTable gridView { get => (DataTable)dataGridView.DataSource; set => dataGridView.DataSource = value; }

        private void ExoticCircuits_Dubai_Load(object sender, EventArgs e)
        {
            ExoticDubaiPresenter presenter = new ExoticDubaiPresenter(this);
            presenter.Populate();
        }
    }
}
