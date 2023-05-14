using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proiect.Presenters
{
    class HotDealsAnkaraPresenter
    {
        IHotDealsAnkara hotDealsAnkara;
        public HotDealsAnkaraPresenter(IHotDealsAnkara view)
        {
            hotDealsAnkara = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter daAnkara_act = new SqlDataAdapter("SELECT Activity, Transport FROM ACTIVITATI A, TRANSPORT T WHERE A.BUDGET =T.BUDGET AND A.BUDGET < 150", myCon);
            DataTable dtAnkara = new DataTable();
            daAnkara_act.Fill(dtAnkara);
            hotDealsAnkara.gridView = dtAnkara;

           // SqlDataAdapter daAnkara_acc = new SqlDataAdapter("SELECT * FROM CAZARE WHERE ID = 10 AND BUDGET < 150", myCon);
           // DataTable dtAnkara2 = new DataTable();
          //  daAnkara_acc.Fill(dtAnkara2);
           // hotDealsAnkara.gridView2 = dtAnkara2;


           // SqlDataAdapter daAnkara_tr = new SqlDataAdapter("SELECT Transport, Budget FROM TRANSPORT WHERE BUDGET < 150", myCon);
//DataTable dtAnkara3 = new DataTable();
          //  daAnkara_tr.Fill(dtAnkara3);
           // hotDealsAnkara.gridView3= dtAnkara3;

           // SqlDataAdapter daAnkara_in = new SqlDataAdapter("SELECT Insurance_package, Budget FROM ASIGURARE WHERE BUDGET < 150", myCon);
           // DataTable dtAnkara4 = new DataTable();
           // daAnkara_in.Fill(dtAnkara4);
           // hotDealsAnkara.gridView4 = dtAnkara4;


           // SqlDataAdapter daAnkara_r = new SqlDataAdapter("SELECT Car_type, Budget FROM RentACar WHERE BUDGET < 150", myCon);
           /// DataTable dtAnkara5 = new DataTable();
           // daAnkara_r.Fill(dtAnkara5);
           // hotDealsAnkara.gridView5 = dtAnkara5;

            //SqlDataAdapter daAnkara_s = new SqlDataAdapter("SELECT Sugestions, Budget FROM SUGESTII WHERE BUDGET < 150", myCon);
           // DataTable dtAnkara6 = new DataTable();
           // daAnkara_s.Fill(dtAnkara6);
           // hotDealsAnkara.gridView6 = dtAnkara6;
            //myCon.Close();
        }
    }
}
