<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Default6" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <p>
        <br />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 168px; position: absolute; height: 16px; width: 52px;" Text="Name" ForeColor="#0066FF"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 150px; top: 166px; position: absolute; height: 22px; width: 377px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 22px; top: 226px; position: absolute; height: 17px; width: 109px;" Text="Email Address" ForeColor="#0066FF"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 149px; top: 223px; position: absolute; height: 22px; width: 377px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" ForeColor="#0066FF" style="z-index: 1; left: 22px; top: 331px; position: absolute; width: 83px; height: 22px;" Text="Your Question"></asp:Label>
    </p>
    <p>
        
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 22px; top: 278px; position: absolute; height: 17px; width: 57px;" Text="Subject" ForeColor="#0066FF"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 150px; top: 281px; position: absolute; height: 22px; width: 377px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 149px; top: 332px; position: absolute; height: 94px; width: 512px" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 616px; top: 442px; position: absolute; margin-top: 0px" Text="Send" OnClick="Button1_Click" />
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
    <p>
        &nbsp;</p>



</asp:Content>

