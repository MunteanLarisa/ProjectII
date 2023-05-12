using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Views;
using Proiect.Models;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proiect.Presenters
{
    class MainPagePresenter
    {
        IMainPage mainPageView;
        ICircuits circuitsView;

        public MenuStrip MainMenuStrip { get; private set; }

        public MainPagePresenter(IMainPage view)
        {
            mainPageView = view;
        }

        public void Destination()
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            // cn.Open();
            //SqlCommand cmd = new SqlCommand("select Oras from Destinatii where Oras=' "+ mainPageView.Destination +"'", cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    dr.Close();


            //}
            //cn.Close();

        }
        public void Destinations_Menu()
        {
            
        }

        public void Barcelona()
        {   
            Circuits c = new Circuits();
            c.Show();
        }
        public static int IdTable()
        {
            return 5;
        }
        public void Belgrade()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void Oslo()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void AbuDhabi()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void Prague()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void Amsterdam()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void London()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void Paris()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void DubaiC()
        {
            Circuits c = new Circuits();
            c.Show();
        }
        public void Ankara()
        {
            HotDeals h = new HotDeals();
            h.Show();
        }
        public void Budapest()
        {
            HotDeals h = new HotDeals();
            h.Show();
        }
        public void Bucharest()
        {
            HotDeals h = new HotDeals();
            h.Show();
        }
        public void Bruxelles()
        {
            HotDeals h = new HotDeals();
            h.Show();
        }
        public void BoraBora()
        {
            ExoticCircuits e = new ExoticCircuits();
            e.Show();
        }
        public void Bali()
        {
            ExoticCircuits e = new ExoticCircuits();
            e.Show();
        }
        public void Dubai()
        {
            ExoticCircuits e = new ExoticCircuits();
            e.Show();
        }
        public void Maldives()
        {
            ExoticCircuits e = new ExoticCircuits();
            e.Show();
        }

    }
}


