<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MarkAttendence.aspx.cs" Inherits="Default4" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 21px; top: 180px; position: absolute; height: 17px; width: 52px;" Text="Branch" ForeColor="#0066FF"></asp:Label>
    <asp:Label ID="Label2" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 241px; top: 179px; position: absolute" Text="Sem"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" style="z-index: 1; left: 295px; top: 178px; position: absolute">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Sem1</asp:ListItem>
        <asp:ListItem>Sem2</asp:ListItem>
        <asp:ListItem>sem3</asp:ListItem>
        <asp:ListItem>Sem4</asp:ListItem>
        <asp:ListItem>Sem5</asp:ListItem>
        <asp:ListItem>Sem6</asp:ListItem>
        <asp:ListItem>Sem7</asp:ListItem>
        <asp:ListItem>Sem8</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label3" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 416px; top: 179px; position: absolute" Text="Faculty"></asp:Label>
    <asp:DropDownList ID="DropDownList3" runat="server" style="z-index: 1; left: 483px; top: 178px; position: absolute">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Meenakshi Ahlawat</asp:ListItem>
        <asp:ListItem>Rajan Kakkar</asp:ListItem>
        <asp:ListItem>Asha</asp:ListItem>
        <asp:ListItem>Dinesh </asp:ListItem>
        <asp:ListItem>Archana</asp:ListItem>
        <asp:ListItem>Sanjay parmar</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label4" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 661px; top: 179px; position: absolute" Text="Subject"></asp:Label>
    <asp:DropDownList ID="DropDownList4" runat="server" style="z-index: 1; left: 735px; top: 178px; position: absolute">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>Advanced Computer Architecture</asp:ListItem>
        <asp:ListItem>Software Project Management</asp:ListItem>
        <asp:ListItem>Compile Design</asp:ListItem>
        <asp:ListItem>Neural Network</asp:ListItem>
        <asp:ListItem>Advanced Java</asp:ListItem>
        <asp:ListItem>Disk Operating System</asp:ListItem>
        <asp:ListItem>C.D LAB</asp:ListItem>
        <asp:ListItem>MATLAB</asp:ListItem>
        <asp:ListItem>Advanced Java LAB</asp:ListItem>
        <asp:ListItem>Practical Training</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 98px; top: 178px; position: absolute">
        <asp:ListItem>--Select--</asp:ListItem>
        <asp:ListItem>C.S.E</asp:ListItem>
        <asp:ListItem>E.C.E </asp:ListItem>
        <asp:ListItem>CIVIL</asp:ListItem>
        <asp:ListItem>MECHANICAL</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 370px; top: 241px; position: absolute" Text="Show List" />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
    <p>
</p>
    <p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
<p>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="false" Width="683px" OnSelectedIndexChanged="gvStudents_SelectedIndexChanged" ForeColor="Black">
            <Columns>
                <asp:TemplateField HeaderText="Roll No">
                    <ItemTemplate>
                        <asp:Label ID="lblRollNo" runat="server" Text='<%#Eval("RollNo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student Name">
                    <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Attendence">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkAttendence" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</p>
    <p>
          <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 293px; top: 521px; position: absolute" OnTextChanged="txtDate_TextChanged"></asp:TextBox>
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>
    <p>
        <asp:Button ID="btnSave" runat="server" style="z-index: 1; left: 716px; top: 520px; position: absolute; height: 26px" Text="Save" OnClick="SaveStudentAttendance" />
</p>
    <p>
</p>
    <p>
</p>
    <p>
</p>



</asp:Content>

