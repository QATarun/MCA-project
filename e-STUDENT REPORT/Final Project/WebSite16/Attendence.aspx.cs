using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            Response.Redirect("markattendence.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {

            Response.Redirect("enterattendence.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        {
            Response.Redirect("getattendence.aspx");
        }
    }
}