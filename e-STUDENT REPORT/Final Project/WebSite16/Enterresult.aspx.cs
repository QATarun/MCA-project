using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0 && TextBox2.Text.Length == 0 && TextBox3.Text.Length == 0 && TextBox4.Text.Length == 0 && TextBox5.Text.Length == 0 && TextBox6.Text.Length == 0 && TextBox7.Text.Length == 0 && TextBox8.Text.Length == 0)
        {
            Response.Write("<script> alert ('Please fill the required details') </script>");
        }
        else
        {
            SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into sessional values ('" + TextBox1.Text + "'," + Convert.ToInt32(TextBox2.Text) + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text + "," + TextBox6.Text + "," + TextBox7.Text + "," + TextBox8.Text + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script> alert ('Record enter sucessfully ') </script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }
    }
}