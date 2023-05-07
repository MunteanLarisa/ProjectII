using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Proiect.Views;


namespace Proiect.Views
{
    public interface ILogin
    {
        string LoginUsername { get; set; }
        string LoginPassword { get; set;  }
        
    }
    
}
