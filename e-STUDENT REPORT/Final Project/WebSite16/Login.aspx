<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<p>
        <br />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 46px; top: 143px; position: absolute" Text="User Name" ForeColor="#0066FF"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 46px; top: 183px; position: absolute" Text="Password" ForeColor="#0066FF"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 176px; top: 143px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 176px; top: 186px; position: absolute" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 241px; top: 229px; position: absolute" Text="Login" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>



</asp:Content>


