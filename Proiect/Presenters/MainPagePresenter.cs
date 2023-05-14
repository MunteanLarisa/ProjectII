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
         IPackages packagesView;

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
 
        public void Paris()
        {
            
                SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                myCon.Open();
                SqlDataAdapter daParis = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 1", myCon);
                DataTable dtParis = new DataTable();
                daParis.Fill(dtParis);
                packagesView.gridView = dtParis;
                myCon.Close();
            
        }
        public void Ankara()
        {
            HotDeals_Ankara h = new HotDeals_Ankara();
            h.Show();
        }
        public void Budapest()
        {
            HotDeals_Budapest b = new HotDeals_Budapest();
            b.Show();
        }
        public void Bucharest()
        {
            HotDeals_Bucharest b = new HotDeals_Bucharest();
            b.Show();
        }
        public void Bruxelles()
        {
            HotDeals_Bruxelles h = new HotDeals_Bruxelles();
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
        public void Search()
        {
            Packages p = new Packages();
            p.Show();
        }
        public void Departure_ClujNapoca()
        {

            //SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            //myCon.Open();
           // SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PLECARE WHERE Oras = CLUJ-NAPOCA", myCon);
           // myCon.Close();
        } 
    }
}


