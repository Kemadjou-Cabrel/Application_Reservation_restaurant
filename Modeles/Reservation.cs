using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Reservation.Modeles
{
    public class Reservation
    {
        #region Proprietes
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Menu { get; set; }

        public int Numero { get; set; }

        public DateTime DateReservation { get; set; }

        public int Table { get; set; }

        #endregion

        #region Constructeurs
        public Reservation()
        {

        }
        public Reservation(string nom)
        {
            this.Nom = nom;


        }

        public Reservation(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;

        }


        #endregion






    }
}
