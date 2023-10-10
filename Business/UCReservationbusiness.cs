using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Application_Reservation.Modeles;


namespace Application_Reservation.Business
{
    public class UCReservationbusiness :INotifyPropertyChanged
    {
        private Reservation _selectioner;

        public Reservation Selectioner
        {
            get => _selectioner;
            set
            {
                if (Equals(value, _selectioner)) return;
                _selectioner = value;
                OnPropertyChanged();
            }
        }

        // acceder a la lister avec notification de interface
        public ObservableCollection <Reservation> Listofreservation 
        { 
            get; 
            set;
        } 
        public UCReservationbusiness()
        {
            Listofreservation = new ObservableCollection<Reservation>();
            for (int i = 0; i < 3; i++)
            {
                Reservation client = new Reservation();
                client.id = i;
                client.Nom = "Cabrel";
                client.Prenom = "Richelin";
                client.DateReservation = new DateTime(2000, 2, 1, 10, 30, 0);
                client.Numero = 0465457856;
                client.Table = 1;
                client.Menu = "sauce bolonaise ";
                Listofreservation.Add(client);
            }
        }
        public UCReservationbusiness(string name) { }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
