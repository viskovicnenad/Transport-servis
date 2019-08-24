using System;

namespace KlasePodataka
{
    public class Servis
    {
        // atributi
        private string pID;
        private int pCena;
        private string pIme;
        private string pIdDrzave;
        private string pIdKorisnika;

        //konstruktor
        public Servis()
        {

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
    }
}
