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
    class PackagesPresenter
    {
        IPackages packagesView;
        public PackagesPresenter(IPackages view)
        {
            packagesView = view;
        }
        public void Db()
        {
            //SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Proiect_II\ProjectII\Proiect\Database.mdf;Integrated Security=True");
            //myCon.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PLECARE WHERE Oras = CLUJ-NAPOCA", myCon);
            //myCon.Close();
        }
    }
}
