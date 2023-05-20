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
        public static IPackages packagesView;
        public static IMainPage mainPageView;
        public PackagesPresenter(IPackages view)
        {
            packagesView = view;
        }
        public PackagesPresenter(IPackages view, IMainPage view2)
        {
            packagesView = view;
            mainPageView = view2;
        }
    }
}
