using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.txtDate.Text = DateTime.Now.ToShortDateString();
           // this.PopulateStudentDetails();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 7 && DropDownList3.SelectedIndex != 0 && DropDownList4.SelectedIndex != 0)
        {

            if (DropDownList4.SelectedValue == "1")
            {

                advancedcomputerarchitecture();
            }

            else if (DropDownList4.SelectedValue == "2")
            {
                softwareprojectmanagement();

            }
            else if (DropDownList4.SelectedValue == "3")
            {

                compiledesign();
            }
            else if (DropDownList4.SelectedValue == "4")
            {
                neuralnetwork();

            }
            else if (DropDownList4.SelectedValue == "5")
            {
                advancedjava();

            }
            else if (DropDownList4.SelectedValue == "6")
            {

                diskoperatingsystem();
            }
            else if (DropDownList4.SelectedValue == "7")
            {
                cdlab();

            }
            else if (DropDownList4.SelectedValue == "8")
            {
                matlab();

            }
            else if (DropDownList4.SelectedValue == "9")
            {
                advancedjavalab();

            }
            else
            {
                practicaltraining();

            }
        }
        else
        {
            Response.Write("<script> alert ('Please select the required fields') </script>");
        }

     
    }
    private void PopulateStudentDetails()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT RollNo,StudentName FROM Table_Student", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }

    private void advancedcomputerarchitecture()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM advancedcomputerarchitecture", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void softwareprojectmanagement()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM softwareprojectmanagement", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void compiledesign()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM compiledesign", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void neuralnetwork()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM neuralnetwork", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void advancedjava()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM advancedjava", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void diskoperatingsystem()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM diskoperatingsystem", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void cdlab()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM cdlab", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void matlab()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM matlab", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void advancedjavalab()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM advancedjavalab", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }
    private void practicaltraining()
    {
        SqlConnection con = new SqlConnection("Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true");
        SqlDataAdapter da = new SqlDataAdapter("SELECT distinct RollNo,StudentName FROM practicaltraining", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvStudents.DataSource = ds.Tables[0];
        gvStudents.DataBind();
    }



    
     

    protected void SaveStudentAttendance(object sender, EventArgs e)
    {


        if (DropDownList4.SelectedIndex == 1)
        {

                foreach (GridViewRow row in gvStudents.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                        string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                        int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                        string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                        string sttendenceDate = (this.txtDate.Text.Trim());
                        string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            string query = "INSERT INTO advancedcomputerarchitecture VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                con.Open();
                                cmd.Parameters.AddWithValue("@StudentName", studentName);
                                cmd.Parameters.AddWithValue("@rollno", rollNo);
                                cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                                cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                }

            }
        else if (DropDownList4.SelectedIndex == 2)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO softwareprojectmanagement VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 3)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO compiledesign VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 4)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO neuralnetwork VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 5)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO advancedjava VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 6)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO diskoperatingsystem VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 7)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO cdlab VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 8)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO matlab VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else if (DropDownList4.SelectedIndex == 9)
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO advancedjavalab VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }
        else
        {

            foreach (GridViewRow row in gvStudents.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkAttendance = row.FindControl("chkAttendence") as CheckBox;
                    string attendanceStatus = chkAttendance.Checked ? "Present" : "Absent";
                    int rollNo = int.Parse((row.FindControl("lblRollNo") as Label).Text.Trim());
                    string studentName = ((row.FindControl("lblStudentName") as Label).Text.Trim());
                    string sttendenceDate = (this.txtDate.Text.Trim());
                    string constring = "Data Source=KETAN-PC;initial catalog=studentwebsite;integrated security=true";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        string query = "INSERT INTO practicaltraining VALUES(@StudentName ,@rollno,@AttendenceDate ,@attendence)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@StudentName", studentName);
                            cmd.Parameters.AddWithValue("@rollno", rollNo);
                            cmd.Parameters.AddWithValue("@AttendenceDate", this.txtDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@attendence", attendanceStatus);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }

        }

     
    
         

        Response.Write("<script> alert ('Record enter sucessfully ') </script>");
        
            
           
            

        }
    
    protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txtDate_TextChanged(object sender, EventArgs e)
    {

    }
}