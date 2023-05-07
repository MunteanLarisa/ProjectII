using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proiect.Presenters
{
    class CircuitsPresenter
    {
        ICircuits circuitsView;

        public CircuitsPresenter(ICircuits view)
        {
            circuitsView = view;
        }
        public void Barcelona()
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from Activitati INNER JOIN Destinatii where Activitati.Id=Destinatii.Id AND Destinatii.Oras = Barcelona' " + circuitsView.Barcelona + "'", cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    dr.Close();

            //}
            //cn.Close();
            //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            //cn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from Activitati INNER JOIN Destinatii where Activitati.Id = Destinatii.Id AND Destinatii.Oras = Barcelona' " + circuitsView.Barcelona + "'", cn);
            //Circuits c = new Circuits();
            //c.Fill(da);
            //circuitsView.DataSource = da;
        }  
    }
}
