using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MapsV3.Prototyping.DAL;

namespace MapsV3.Prototyping
{
    public partial class route_search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MapsDevEntities entities = new MapsDevEntities();

            rptPOICetagories.DataSource = entities.POISet.ToList();
            rptPOICetagories.DataBind();
        }
    }
}
