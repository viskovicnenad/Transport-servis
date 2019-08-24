using KlasePodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrezentacionaLogika
{
    public class UnosServisa
    {
        // atributi
        private string pID;
        private int pCena;
        private string pIme;
        private string pIdDrzave;
        private string pIdKorisnika;
        private string pStringKonekcije;

        //konstruktor
        public UnosServisa(string NoviStringKonekcije)
        {
            pStringKonekcije = NoviStringKonekcije;
        }

        // javne metode
        public string ID
        {
            get { return pID; }
            set { pID = value; }
        }

        public int Cena
        {
            get { return pCena; }
            set { pCena = value; }
        }
        public string Ime
        {
            get { return pIme; }
            set { pIme = value; }
        }
        public string IdDrzave
        {
            get { return pIdDrzave; }
            set { pIdDrzave = value; }
        }

        public string IdKorisnika
        {
            get { return pIdKorisnika; }
            set { pIdKorisnika = value; }
        }

        public bool SnimiPodatke()
        {
            bool uspeh = false;
            ServisDB objServisDB = new ServisDB(pStringKonekcije);
            Servis objServis = new Servis();
            // prerada ulaznih podataka
            objServis.ID = this.pID;
            objServis.IdKorisnika = this.pIdKorisnika;
            objServis.Ime = this.pIme;
            objServis.Cena = this.pCena;
            objServis.IdDrzave = this.pIdDrzave;

            // snimanje putem DB klase
            uspeh = objServisDB.DodajNovServis(objServis);
            return uspeh;
        }
    }
}
