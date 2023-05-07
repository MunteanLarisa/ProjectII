using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Views;
using Proiect.Models;


namespace Proiect.Views
{
    public interface IPachete
    {
        string Destinatia
        {
            get; set;
        }
        string OrasDePlecare
        {
            get; set;
        }
        string Transport
        {
            get; set;
        }
        DateTime DataPlecarii
        {
            get; set;
        }
        int NrDeNopti
        {
            get; set;
        }
        int NrDeCamere
        {
            get; set;
        }
        int Adulti
        {
            get; set;
        }
        int Copii
        {
            get; set;
        }
        string PetFriendly
        {
            get; set;
        }
    }
}
