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
using Application_Reservation.Business;
using Application_Reservation.Modeles;
using Application_Reservation.Views.MyUserControls;

namespace Application_Reservation
{
    
    /// Logique d'interaction pour MainWindow.xaml
    
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // gerer ma logique metier 
            Business.MainWindowBusiness windowBusiness=new Business.MainWindowBusiness();
           
    
        }

        // Gestionnaire evenments Click Reservations
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            // Interaction avec mon controleur 
            Views.MyUserControls.UCReservation reservation = new Views.MyUserControls.UCReservation();

            // Gestion de la loqique metier 
            Business.UCReservationbusiness reservationbusiness=new Business.UCReservationbusiness();

            reservation.DataContext = reservationbusiness; 
            
            grContent.Children.Clear();

            // juste de m'affiche le controleur a la fenetre principale
            grContent.Children.Add(reservation); 


        }

        private void btnTables_Click(object sender, RoutedEventArgs e)
        {
            
            Views.MyUserControls.UTable tables = new Views.MyUserControls.UTable();

            //Business.UTablebusiness tablesbusiness=new Business.UTablebusiness();

            tables.DataContext = new UTablebusiness();
            


            grContent.Children.Clear();

            grContent.Children.Add(tables);
        }
    }
}
