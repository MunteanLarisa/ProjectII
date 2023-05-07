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
        }

        public string Barcelona { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Belgrade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Oslo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AbuDhabi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Prague { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Amsterdam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string London { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Paris { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Dubai { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    

        private void Circuits_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            cn2.Open();

            cn2.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CircuitsPresenter presenter = new CircuitsPresenter(this);
            presenter.Barcelona();
        }

        
    }
}
