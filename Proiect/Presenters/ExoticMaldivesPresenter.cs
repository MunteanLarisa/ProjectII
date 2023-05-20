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
    class ExoticMaldivesPresenter
    {
        IExoticMaldives exoticMaldives;
        public ExoticMaldivesPresenter(IExoticMaldives view)
        {
            exoticMaldives = view;
        }
        public void Populate()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            myCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SUGGESTIONS, TRANSPORT, INSURANCE_PACKAGE AS 'INSURANCE PACKAGE', ACCOMODATION_TYPE AS 'ACCOMODATION', NO_NIGHTS AS 'NIGHTS', (SUGESTII.BUDGET+CAZARE.BUDGET+TRANSPORT.BUDGET+ASIGURARE.BUDGET) AS 'TOTAL (EURO)' FROM SUGESTII INNER JOIN CAZARE ON SUGESTII.ID=CAZARE.ID JOIN TRANSPORT ON CAZARE.ID=TRANSPORT.ID JOIN ASIGURARE ON ASIGURARE.ID=CAZARE.ID WHERE CAZARE.ID=20", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            exoticMaldives.gridView = dt;
            myCon.Close();

        }
    }
}
