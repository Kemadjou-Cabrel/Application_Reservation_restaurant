using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_Reservation.Modeles;

namespace Application_Reservation.Business
{
    public class UTablebusiness
    {

       public List<Tables> ListTables { get; set; }

       public UTablebusiness()
       {
           ListTables= new List<Tables>();

           for (int i = 0; i < 1; i++)
           {
                Tables t = new Tables(1,"VIP");
                ListTables.Add(t);
           }
       }
    }
}
