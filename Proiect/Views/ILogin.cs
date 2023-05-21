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
        public String LoginUsername { get; set; }
        public String LoginPassword { get; set;  }
        public String ErrorMessageLogin { get; set; }
        public bool ShowErrorMessageLogin { get; set; }
        public event EventHandler LoginAttempted;


    }
    
}
