using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            Response.Redirect("enterresult.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        {
            Response.Redirect("getresult.aspx");
        }
    }
}