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
       //PARIS
        public void Paris_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();  
        }
        public void Paris_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Paris_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=1 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //MILANO
        public void Milano_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Milano_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=2 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //BARCELONA
        public void Barcelona_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Barcelona_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=5 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //LONDON
        public void London_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void London_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=6 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //BERLIN
        public void Berlin_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Berlin_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=7 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //ABU DHABI
        public void AbuDhabi_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void AbuDhabi_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=8 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //AMSTERDAM
        public void Amsterdam_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Amsterdam_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=9 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //ANKARA
        public void Ankara_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Ankara_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=10 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //BELGRAD
        public void Belgrad_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Belgrad_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=11 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //BRUSSELS
        public void Brussels_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Brussels_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=12 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //BUDAPEST
        public void Budapest_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Budapest_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=13 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //COPENHAGA
        public void Copenhaga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Copenhaga_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=14 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //OSLO
        public void Oslo_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Oslo_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=15 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        //PRAGA
        public void Praga_menu()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu2()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=2 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu3()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu4()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=1 AND CAZARE.PET_FRIENDLY LIKE 'Y%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu5()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu6()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=3 AND CAZARE.NO_NIGHTS=3 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=2 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu7()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'C%'", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            packagesView.gridView = dt;
            myCon.Close();
        }
        public void Praga_menu8()
        {
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESTINATII.CITY, PLECARE.CITY AS DEPARTURE, ACCOMODATION_TYPE AS ACCOMODATION, NO_NIGHTS, NO_ROOMS, ADULTS, CHILDREN, PET_FRIENDLY, PERIOD, CAZARE.BUDGET AS TOTAL FROM CAZARE JOIN DESTINATII ON CAZARE.ID=DESTINATII.ID JOIN PLECARE ON CAZARE.ID=PLECARE.ID WHERE CAZARE.ID=16 AND CAZARE.NO_ROOMS=1 AND CAZARE.NO_NIGHTS=5 AND CAZARE.ADULTS=2 AND CAZARE.CHILDREN=0 AND CAZARE.PET_FRIENDLY LIKE 'N%' AND PLECARE.CITY LIKE 'B%'", myCon);
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


