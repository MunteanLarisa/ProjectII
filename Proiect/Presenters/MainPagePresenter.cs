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
         public static IPackages packagesView;
         ICircuits circuitsView;
         SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");

        //public MenuStrip MainMenuStrip { get; private set; }
        public MainPagePresenter(IMainPage view)
        {
            mainPageView = view;
        }
        public MainPagePresenter(IMainPage view, IPackages view2)
        {
            mainPageView = view;
            packagesView = view2;
        }
        public MainPagePresenter(IMainPage view, ICircuits view2)
        {
            mainPageView = view;
            circuitsView = view2;
        }
       
        public void Paris_menu()
        {
            myCon.Open();
            //string msg1 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in MainPagePresenter.mainPageView.Destinations)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg1 = menuItem.Text;
            //    }
            //}
            //string msg2 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableCitiesToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg2 = menuItem.Text;
            //    }
            //}
            //string msg3 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg3 = menuItem.Text;
            //    }
            //}
            //string msg4 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in availableOptionsToolStripMenuItem1.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg4 = menuItem.Text;
            //    }
            //}
            //string msg5 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg5 = menuItem.Text;
            //    }
            //}
            //string msg6 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem1.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg6 = menuItem.Text;
            //    }
            //}
            //string msg7 = string.Empty;
            //foreach (ToolStripMenuItem menuItem in chooseToolStripMenuItem2.DropDownItems)
            //{
            //    if (menuItem.Checked == true)
            //    {
            //        msg7 = menuItem.Text;
            //    }
            //}
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Accomodation_type, PLECARE.CITY AS DEPARTURE, (ACTIVITATI.BUDGET+CAZARE.BUDGET) AS TOTAL FROM ACTIVITATI INNER JOIN CAZARE ON ACTIVITATI.ID=CAZARE.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID ", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 2", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity,Budget FROM ACTIVITATI WHERE ID = 5", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 6", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 7", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 8", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 9", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 10", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 11", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Bruxelles_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 12", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 13", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 14", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 15", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Activity, Budget FROM ACTIVITATI WHERE ID = 16", myCon);
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
        public void Search2()
        {
            Circuits c = new Circuits(); c.Show();
        }
        public void Departure_ClujNapoca()
        {
            //SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            //myCon.Open();
           // SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PLECARE WHERE Oras = CLUJ-NAPOCA", myCon);
           // myCon.Close();
        }
        public void Budget100()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.City, ACTIVITATI.Activity AS Activity1,SUGESTII.Suggestions AS Activity2, (ACTIVITATI.BUDGET+SUGESTII.BUDGET) AS TOTAL FROM ACTIVITATI JOIN DESTINATII ON ACTIVITATI.ID=DESTINATII.ID JOIN SUGESTII ON SUGESTII.ID=ACTIVITATI.ID JOIN OFERTE ON ACTIVITATI.BUDGET=OFERTE.BUDGET WHERE (ACTIVITATI.BUDGET+SUGESTII.BUDGET) BETWEEN 100 AND 299 ", myCon); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            circuitsView.gridView = dt;
            myCon.Close();
        }
        public void Budget300()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.City, ACTIVITATI.Activity AS Activity1,SUGESTII.Suggestions AS Activity2, (ACTIVITATI.BUDGET+SUGESTII.BUDGET) AS TOTAL FROM ACTIVITATI JOIN DESTINATII ON ACTIVITATI.ID=DESTINATII.ID JOIN SUGESTII ON SUGESTII.ID=ACTIVITATI.ID JOIN OFERTE ON ACTIVITATI.BUDGET=OFERTE.BUDGET WHERE (ACTIVITATI.BUDGET+SUGESTII.BUDGET) BETWEEN 300 AND 499", myCon); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            circuitsView.gridView = dt;
            myCon.Close();
        }
        public void Budget500()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.City, ACTIVITATI.Activity AS Activity1,SUGESTII.Suggestions AS Activity2, (ACTIVITATI.BUDGET+SUGESTII.BUDGET) AS TOTAL FROM ACTIVITATI JOIN DESTINATII ON ACTIVITATI.ID=DESTINATII.ID JOIN SUGESTII ON SUGESTII.ID=ACTIVITATI.ID JOIN OFERTE ON ACTIVITATI.BUDGET=OFERTE.BUDGET WHERE (ACTIVITATI.BUDGET+SUGESTII.BUDGET) BETWEEN 500 AND 699 ", myCon); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            circuitsView.gridView = dt;
            myCon.Close();
        }
        public void Budget700()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.City, ACTIVITATI.Activity AS Activity1,SUGESTII.Suggestions AS Activity2, (ACTIVITATI.BUDGET+SUGESTII.BUDGET) AS TOTAL FROM ACTIVITATI JOIN DESTINATII ON ACTIVITATI.ID=DESTINATII.ID JOIN SUGESTII ON SUGESTII.ID=ACTIVITATI.ID JOIN OFERTE ON ACTIVITATI.BUDGET=OFERTE.BUDGET WHERE (ACTIVITATI.BUDGET+SUGESTII.BUDGET) BETWEEN 700 AND 899", myCon); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            circuitsView.gridView = dt;
            myCon.Close();
        }
        public void Budget900()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.City, ACTIVITATI.Activity AS Activity1,SUGESTII.Suggestions AS Activity2, (ACTIVITATI.BUDGET+SUGESTII.BUDGET) AS TOTAL FROM ACTIVITATI JOIN DESTINATII ON ACTIVITATI.ID=DESTINATII.ID JOIN SUGESTII ON SUGESTII.ID=ACTIVITATI.ID JOIN OFERTE ON ACTIVITATI.BUDGET=OFERTE.BUDGET WHERE (ACTIVITATI.BUDGET+SUGESTII.BUDGET) BETWEEN 900 AND 1000000000", myCon); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            circuitsView.gridView = dt;
            myCon.Close();
        }
    }
}


