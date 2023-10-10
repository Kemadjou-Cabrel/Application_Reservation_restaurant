namespace Application_Reservation.Modeles
{
    public class Tables
    {
        #region Proprietes
        public int NumeroTable { get; set; }
        public string NomTables { get; set; }


        #endregion

        #region Constructeurs
        public Tables()
        {

        }
        public Tables(int NumeroTable, string nom)
        {
            this.NumeroTable = NumeroTable;
            this.NomTables = nom;


        }


        #endregion






    }
}