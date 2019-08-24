using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KlasePodataka;

namespace PrezentacionaLogika
{
    public class TabelarniprikazServisa
    {
        private string pStringKonekcije;

        public TabelarniprikazServisa(string NoviStringKonekcije)
        {
            //pFilter="";
            //pPodaciZaGrid = new DataSet();
            pStringKonekcije = NoviStringKonekcije;
        }

        public DataSet DajPodatkeZaGrid(string Filter)
        {
            DataSet dsPodaci = new DataSet();
            ServisDB objServisDB = new ServisDB(pStringKonekcije);
            if (Filter.Equals(""))
            {
                dsPodaci = objServisDB.DajSveServise();
            }
            else
            {
                dsPodaci = objServisDB.DajServisePoID(Filter);
            }
            return dsPodaci;
        }
    }
}
