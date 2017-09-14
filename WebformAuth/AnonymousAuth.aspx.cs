using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformAuth
{
    public partial class AnonymousAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Requested Executed Context" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br>");
                Response.Write("Is Authenticated?" + User.Identity.IsAuthenticated + "<br>");
                Response.Write("Authentication Type" + User.Identity.AuthenticationType + "<br>");
                Response.Write("User Name" + User.Identity.Name + "<br>");
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("Countries.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}