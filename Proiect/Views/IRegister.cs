using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Views
{
    interface IRegister
    {
        string Username { get; set; }
        string Password { get; set; }
        string ConfPassword { get; set; }
    }
}
