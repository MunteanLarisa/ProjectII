﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Proiect.Models;
using Proiect.Views;

namespace Proiect.Views
{
    interface IHotDealsAnkara
    {
        DataTable gridView
        {
            get; set;
        }
       
    }
}