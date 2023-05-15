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
    class HotDealsBruxellesPresenter
    {
        IHotDealsBruxelles hotDealsBruxelles;
        public HotDealsBruxellesPresenter(IHotDealsBruxelles view)
        {
            hotDealsBruxelles = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUGGESTIONS, ACCOMODATION_TYPE, REVIEW, CENTER_DISTANCE, MEALS_INCLUDED, NO_NIGHTS, ADULTS, CHILDREN, (SUGESTII.BUDGET+CAZARE.BUDGET) AS TOTAL FROM SUGESTII FULL OUTER JOIN CAZARE ON SUGESTII.ID=CAZARE.ID WHERE SUGESTII.ID=12 AND (SUGESTII.BUDGET+CAZARE.BUDGET) BETWEEN 300 AND 599 ", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hotDealsBruxelles.gridView = dt;
            myCon.Close();

        }
    }
}
