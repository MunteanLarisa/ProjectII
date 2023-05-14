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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Sugestions FROM SUGESTII WHERE ID = 10 AND BUDGET < 150 ", myCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hotDealsAnkara.gridView = dt;
            myCon.Close();

        }
    }
}
