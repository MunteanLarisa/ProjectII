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
    public partial class ExoticCircuits_BoraBora : Form, IExoticBoraBora
    {
        public ExoticCircuits_BoraBora()
        {
            InitializeComponent();
        }

        public DataTable gridView { get => (DataTable)dataGridView.DataSource; set => dataGridView.DataSource = value; }

        private void ExoticCircuits_BoraBora_Load(object sender, EventArgs e)
        {
            ExoticBoraBoraPresenter presenter = new ExoticBoraBoraPresenter(this);
            presenter.Populate();
        }
    }
}
