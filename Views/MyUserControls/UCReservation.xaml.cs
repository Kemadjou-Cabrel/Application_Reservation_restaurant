using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application_Reservation.Modeles;

namespace Application_Reservation.Views.MyUserControls
{
    /// <summary>
    /// Logique d'interaction pour UCReservation.xaml
    /// </summary>
    public partial class UCReservation : UserControl
    {
        public UCReservation()
        {
            InitializeComponent();
        }


        private void btnajoutreservation_Click(object sender, RoutedEventArgs e)
        {
            Reservation reservation = new Reservation();

            Views.Donnees.Encodage donnees = new Donnees.Encodage();

            donnees.DataContext = reservation;// nimporte quelle controle peut avoir la valeur de reservation 
            


            if (donnees.ShowDialog()==true)
            {
                Business.UCReservationbusiness res = this.DataContext as Business.UCReservationbusiness; // caste data contexte en using controle busineess 

                res.Listofreservation.Add(reservation);
                // ajout des nouvelle reservation 

            }

        }

        private void btnsupprimer_Click(object sender, RoutedEventArgs e)
        {
            Business.UCReservationbusiness res = this.DataContext as Business.UCReservationbusiness;
            if (res.Selectioner != null)
            {
                res.Listofreservation.Remove(res.Selectioner);
            }
            else
            {
                MessageBox.Show("Veillez Selectionner une Reservation a Supprimer");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)// editer bouton
        {
            Business.UCReservationbusiness res = this.DataContext as Business.UCReservationbusiness;

            if (res.Selectioner!=null)
            {
                Views.Donnees.Encodage donnees = new Donnees.Encodage();

                donnees.DataContext = res.Selectioner;

                donnees.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veillez Selectionner une Reservation a Editer");
            }


        }
    }
}
