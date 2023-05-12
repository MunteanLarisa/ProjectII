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
    class CircuitsPresenter
    {
        ICircuits circuitsView;
 
       

        public CircuitsPresenter(ICircuits view)
        {
            circuitsView = view;
        }
        public void Barcelona()
        {
                SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
                myCon.Open();
                SqlDataAdapter daBarcelona = new SqlDataAdapter("SELECT * FROM ACTIVITATI WHERE ID = '" + MainPagePresenter.IdTable() + "'", myCon);
                DataTable dtBarcelona = new DataTable();
                daBarcelona.Fill(dtBarcelona);
                circuitsView.gridView = dtBarcelona;
                myCon.Close();
            
        }  
    }
}
