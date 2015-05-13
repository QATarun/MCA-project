using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SendMail()
    {
        // Gmail Address from where you send the mail
        var fromAddress = "dummyprojectt@gmail.com";
        // any address where the email will be sending
        var toAddress = "dummyprojectt@gmail.com";
        //Password of your gmail address
        const string fromPassword = "yatin123";
        // Passing the values and make a email formate to display
        string subject = TextBox3.Text.ToString();
        string body = "From: " + TextBox1.Text + "\n";
        body += "Email: " + TextBox2.Text + "\n";
        body += "Subject: " + TextBox3.Text + "\n";
        body += "Question: \n" + TextBox4.Text + "\n";
        // smtp settings
        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
            smtp.Timeout = 20000;
        }
        // Passing values to smtp object
        smtp.Send(fromAddress, toAddress, subject, body);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0 && TextBox2.Text.Length == 0 && TextBox3.Text.Length == 0 && TextBox4.Text.Length == 0)
        {
            Response.Write("<script> alert ('Please fill the required details') </script>");
        }
        else
        {
            try
            {
                //here on button click what will done 
                SendMail();
            }
            catch (Exception) { }
            Response.Write("<script> alert ('Thank you for your comment we will revert soon') </script>");
        }
    }
}
   