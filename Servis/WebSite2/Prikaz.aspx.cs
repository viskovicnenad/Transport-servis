using PrezentacionaLogika;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Prikaz : System.Web.UI.Page
{
    private string pStringKonekcije;
    private TabelarniprikazServisa obj;
    private DataSet data;

    public void PrikaziPodatkeTabelarno(DataSet dsPodaci)
    {
        GridView1.DataSource = dsPodaci.Tables[0];
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        pStringKonekcije = ConfigurationManager.ConnectionStrings["Konekcija"].ConnectionString;
        obj = new TabelarniprikazServisa(pStringKonekcije);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        data = obj.DajPodatkeZaGrid(TextBox1.Text);
        PrikaziPodatkeTabelarno(data);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        data = obj.DajPodatkeZaGrid("");
        PrikaziPodatkeTabelarno(data);
    }
}