using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIs_Click(object sender, EventArgs e)
        {
            Response.Redirect("isBasvurusu2.aspx");  
        }

        protected void btnStaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("stajBasvurusu2.aspx");
        }

        protected void btnIs_Click1(object sender, EventArgs e)
        {
            Response.Redirect("isBasvurusu2.aspx");
        }
    }
}