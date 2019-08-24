using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasePodataka
{
    public class ServisDB
    {
        private string pStringKonekcije;

        // konstruktor
        public ServisDB(string NoviStringKonekcije)
        {
            pStringKonekcije = NoviStringKonekcije;
        }

        // javne metode
        public DataSet DajSveServise()
        {
            DataSet dsPodaci = new DataSet();

            SqlConnection Veza = new SqlConnection(pStringKonekcije);
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajSveServise", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }

        public DataSet DajServisePoID(string ID)
        {
            // MOGU biti jos neke procedure, mogu SE VRATITI VREDNOSTI I U LISTU, DATA TABLE...
            DataSet dsPodaci = new DataSet();

            SqlConnection Veza = new SqlConnection(pStringKonekcije);
            Veza.Open();
            SqlCommand Komanda = new SqlCommand("DajServisePoID", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Komanda;
            da.Fill(dsPodaci);
            Veza.Close();
            Veza.Dispose();

            return dsPodaci;
        }

        public bool DodajNovServis(Servis objNovServis)
        {
            // LOKALNE PROMENLJIVE UVEK NA VRHU
            int brojSlogova = 0;

            SqlConnection Veza = new SqlConnection(pStringKonekcije);
            Veza.Open();

            SqlCommand Komanda = new SqlCommand("DodajNoviServis", Veza);
            Komanda.CommandType = CommandType.StoredProcedure;
            Komanda.Parameters.Add("@ID", SqlDbType.NVarChar).Value = objNovServis.ID;
            Komanda.Parameters.Add("@IDKorisnika", SqlDbType.NVarChar).Value = objNovServis.IdKorisnika;
            Komanda.Parameters.Add("@IdDrzave", SqlDbType.NVarChar).Value = objNovServis.IdDrzave;
            Komanda.Parameters.Add("@Cena", SqlDbType.Int).Value = objNovServis.Cena;
            Komanda.Parameters.Add("@Ime", SqlDbType.NVarChar).Value = objNovServis.Ime;

            brojSlogova = Komanda.ExecuteNonQuery();
            Veza.Close();
            Veza.Dispose();

            return (brojSlogova > 0);
        }
    }
}
