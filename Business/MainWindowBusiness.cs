using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Reservation.Modeles;

namespace Application_Reservation.Business
{
    public class MainWindowBusiness
    {
        public string Titrefenetre { get; set; }

        // je lier ma liste avec le item source de data grid
        
        public List<Modeles.Reservation> Listofreservation { get; set; }

        public MainWindowBusiness()
        {
            Titrefenetre = "Bienvenue Sur Notre Site De Reservation ";

            Listofreservation= new List<Modeles.Reservation>();// je instancier pour la remplir

            for (int i = 0; i < 4; i++)
            {
                Reservation client = new Reservation();
                client.id = i;
                client.Nom = "Cabrel:";
                client.Prenom = "Richelin:";
                client.DateReservation = new DateTime(2000, 2, 1, 10, 30, 0);
                client.Numero = 0465457856;
                client.Table = 1;
                client.Menu = "sauce bolonaise ";
                Listofreservation.Add(client);
            }
            
        }
        // pour afficher dans le datagrille on a besoin d'une list 


    }

   
}
