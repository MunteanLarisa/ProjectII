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
    class HotDealsBudapestPresenter
    {
        IHotDealsBudapest hotDealsBudapest;
        public HotDealsBudapestPresenter(IHotDealsBudapest view)
        {
            hotDealsBudapest = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ACTIVITY, ACCOMODATION_TYPE, REVIEW, CENTER_DISTANCE,MEALS_INCLUDED, NO_NIGHTS, (ACTIVITATI.BUDGET+CAZARE.BUDGET) AS TOTAL FROM ACTIVITATI FULL OUTER JOIN CAZARE ON ACTIVITATI.ID=CAZARE.ID WHERE ACTIVITATI.ID=13 AND (ACTIVITATI.BUDGET+CAZARE.BUDGET) BETWEEN 200 AND 399", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hotDealsBudapest.gridView = dt;
            myCon.Close();

        }

    }
}
