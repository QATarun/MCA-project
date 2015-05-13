<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="getattendence.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <p>
        <br />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 46px; top: 143px; position: absolute" Text="Enter your rollno" ForeColor="#0066FF"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 46px; top: 183px; position: absolute" Text="Email address" ForeColor="#0066FF"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 176px; top: 143px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 176px; top: 186px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 215px; top: 244px; position: absolute; margin-top: 0px;" Text="Send Mail" OnClick="Button1_Click" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>

</asp:Content>

