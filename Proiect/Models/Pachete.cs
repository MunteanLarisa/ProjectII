using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Pachete
    {
        public string Destinatia
        {
            get; set;
        }
        public string OrasDePlecare
        {
            get; set;
        }
        public string Transport
        {
            get; set;
        }
        public DateTime DataPlecarii
        {
            get; set;
        }
        public int NrDeNopti
        {
            get; set;
        }
        public int NrDeCamere
        {
            get; set;
        }
        public int Adulti
        {
            get; set;
        }
        public int Copii
        {
            get; set;
        }
        public string PetFriendly
        {
            get; set;
        }
    }
}
