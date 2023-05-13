﻿using System;
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

        private void Circuits_Load(object sender, EventArgs e)
        {
           // CircuitsPresenter presenter = new CircuitsPresenter(this);
            //if (MainPagePresenter.IdTableBa() == 5)
            //{
            //    presenter.Barcelona();
           // }
           // if (MainPagePresenter.IdTableBe() == 11)
           // {
           //     presenter.Belgrade();
           // }
        }

       
    }
}
