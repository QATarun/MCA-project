using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    string name;
    int ACA, SPM, CD, NN, AJ, DOS;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0 && TextBox2.Text.Length == 0)
        {
            Response.Write("<script> alert ('Please fill the required details') </script>");
        }
        else
        {
            SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
            SqlCommand cmd = new SqlCommand("select * from attendence where rollno=" + TextBox1.Text, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr[0].ToString();
                ACA = Convert.ToInt32(dr[2].ToString());
                SPM = Convert.ToInt32(dr[3].ToString());
                CD = Convert.ToInt32(dr[4].ToString());
                NN = Convert.ToInt32(dr[5].ToString());
                AJ = Convert.ToInt32(dr[6].ToString());
                DOS = Convert.ToInt32(dr[7].ToString());

            }
            SendMail();
            con.Close();
        }

    }
    protected void SendMail()
    {
        // Gmail Address from where you send the mail
        var fromAddress = "dummyprojectt@gmail.com";
        // any address where the email will be sending
        var toAddress = TextBox2.Text;
        //Password of your gmail address
        const string fromPassword = "yatin123";
        // Passing the values and make a email formate to display
        string subject = "Sessional Report";
        string body = "Hello your attendence percentage of each subject is as follows\n";
        body += "ACA=" + ACA + "\n";
        body += "SPM=" + SPM + "\n";
        body += "CD=" + CD + "\n";
        body += "NN=" + NN + "\n";
        body += "AJ=" + AJ + "\n";
        body += "DOS=" + DOS + "\n";
        // smtp settings
        var smtp = new System.Net.Mail.SmtpClient();
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

        smtp.Timeout = 20000;

        // Passing values to smtp object
        smtp.Send(fromAddress, toAddress, subject, body);
        Response.Write("<script> alert ('Mail sent succesfully') </script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}