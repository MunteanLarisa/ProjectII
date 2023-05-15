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
    class ExoticBaliPresenter
    {
        IExoticBali exoticBali;
        public ExoticBaliPresenter(IExoticBali view)
        {
            exoticBali = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUGGESTIONS, ACCOMODATION_TYPE, NO_NIGHTS, ADULTS, (SUGESTII.BUDGET+CAZARE.BUDGET) AS TOTAL FROM SUGESTII INNER JOIN CAZARE ON SUGESTII.ID=CAZARE.ID WHERE SUGESTII.ID=18", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            exoticBali.gridView = dt;
            myCon.Close();

        }
    }
}
