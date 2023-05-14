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
         public static IMainPage mainPageView;
         IPackages packagesView;
         SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");

        public MenuStrip MainMenuStrip { get; private set; }

        public MainPagePresenter(IMainPage view, IPackages view2)
        {
            mainPageView = view;
            packagesView = view2;
        }
        public MainPagePresenter(IMainPage view)
        {
            mainPageView = view;
        }
        public void Paris_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 1", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 2", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 5", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 6", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 7", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 8", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 9", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 10", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 11", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Bruxelles_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 12", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 13", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 14", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 15", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = 16", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara()
        {
            HotDeals_Ankara h = new HotDeals_Ankara();h.Show();
        }
        public void Budapest()
        {
            HotDeals_Budapest b = new HotDeals_Budapest();b.Show();
        }
        public void Bucharest()
        {
            HotDeals_Bucharest b = new HotDeals_Bucharest();b.Show();
        }
        public void Bruxelles()
        {
            HotDeals_Bruxelles h = new HotDeals_Bruxelles();h.Show();
        }
        public void BoraBora()
        {
            ExoticCircuits e = new ExoticCircuits();e.Show();
        }
        public void Bali()
        {
            ExoticCircuits e = new ExoticCircuits();e.Show();
        }
        public void Dubai()
        {
            ExoticCircuits e = new ExoticCircuits();e.Show();
        }
        public void Maldives()
        {
            ExoticCircuits e = new ExoticCircuits();e.Show();
        }
        public void Search()
        {
            Packages p = new Packages(); p.Show();
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


