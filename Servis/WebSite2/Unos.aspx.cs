using PrezentacionaLogika;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unos : System.Web.UI.Page
{
    UnosServisa obj;
    protected void Page_Load(object sender, EventArgs e)
    {
        string StringKonekcije = ConfigurationManager.ConnectionStrings["Konekcija"].ConnectionString;
        obj = new UnosServisa(StringKonekcije);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        obj.ID = TextBox1.Text;
        obj.IdKorisnika = TextBox3.Text;
        obj.IdDrzave = TextBox6.Text;
        obj.Ime =TextBox2.Text;
        obj.Cena = int.Parse(TextBox5.Text);

        bool UspehSnimanja = obj.SnimiPodatke();
        if (UspehSnimanja)
        {
            //objLoto.GenerisanjeLotoKombinacije();
            Label1.Text = "USPESNO SNIMLJENI NOVI PODACI!";
        }
        else
        {
            Label1.Text = "NEUSPEH SNIMANJA!";
        }
    }
}