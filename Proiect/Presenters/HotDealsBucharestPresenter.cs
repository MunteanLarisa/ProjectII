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
    class HotDealsBucharestPresenter
    {
        IHotDealsBucharest hotDealsBucharest;
        public HotDealsBucharestPresenter(IHotDealsBucharest view)
        {
            hotDealsBucharest = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUGGESTIONS, ACCOMODATION_TYPE AS 'ACCOMODATION', REVIEW AS 'REVIEW OUT OF 5', CENTER_DISTANCE AS 'DISTANCE FROM CENTER(m)', MEALS_INCLUDED AS 'MEALS INCLUDED', NO_NIGHTS AS 'NIGHTS', (SUGESTII.BUDGET+CAZARE.BUDGET) AS 'TOTAL(EURO)' FROM SUGESTII FULL OUTER JOIN CAZARE ON SUGESTII.ID=CAZARE.ID WHERE SUGESTII.ID=3 AND (SUGESTII.BUDGET+CAZARE.BUDGET) BETWEEN 80 AND 159", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hotDealsBucharest.gridView = dt;
            myCon.Close();

        }
    }
}
