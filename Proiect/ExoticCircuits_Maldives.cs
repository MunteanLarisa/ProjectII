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
    public partial class ExoticCircuits_Maldives : Form, IExoticMaldives
    {
        public ExoticCircuits_Maldives()
        {
            InitializeComponent();
        }
        public DataTable gridView { get => (DataTable)dataGridView.DataSource; set => dataGridView.DataSource = value; }

        private void ExoticCircuits_Maldives_Load(object sender, EventArgs e)
        {
            ExoticMaldivesPresenter presenter = new ExoticMaldivesPresenter(this);
            presenter.Populate();
        }
    }
}
