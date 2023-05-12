using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Models;
using Proiect.Views;

namespace Proiect.Views
{
    interface ICircuits
    {
        DataTable gridView
        {
            get; set;
        }
   
 
    }
}
