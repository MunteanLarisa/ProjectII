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
        public static IMainPage mainPageView;

        public CircuitsPresenter(ICircuits view)
        {
            circuitsView = view;
        }
        public CircuitsPresenter(ICircuits view, IMainPage view2)
        {
            circuitsView = view;
            mainPageView = view2;
        }
     
    }
}
