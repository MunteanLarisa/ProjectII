using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Views;
using Proiect.Models;

namespace Proiect.Presenters
{
    public class PachetePresenter
    {
        IPachete pacheteView;
        public PachetePresenter(IPachete view)
        {
            pacheteView = view;
        }
    }

}
