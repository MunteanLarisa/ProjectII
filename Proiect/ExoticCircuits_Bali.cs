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
    public partial class ExoticCircuits_Bali : Form, IExoticBali
    {
        public ExoticCircuits_Bali()
        {
            InitializeComponent();
        }
        public DataTable gridView { get => (DataTable)dataGridView.DataSource; set => dataGridView.DataSource = value; }

        private void ExoticCircuits_Bali_Load(object sender, EventArgs e)
        {
            ExoticBaliPresenter presenter = new ExoticBaliPresenter(this);
            presenter.Populate();
        }
    }
}
