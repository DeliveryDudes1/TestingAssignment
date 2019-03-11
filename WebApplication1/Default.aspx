<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>



    </p>

    <asp:Label ID="Label1" runat="server" Text="Age" Height="30px" Width="80px"></asp:Label>

    <asp:TextBox ID="Age" runat="server" Height="30px" Width="80px"></asp:TextBox>

    <asp:Label ID="Label2" runat="server" Text="Gender" Height="30px" Width="80px"></asp:Label>

    <asp:TextBox ID="Gender" runat="server" Height="30px" Width="80px"></asp:TextBox>



    <asp:Button ID="Button1" runat="server" Height="30px" Width="100px" OnClick="Button1_Click" Text="Button" />

    <asp:Label ID="Label3" runat="server" Text="Label" Height="30px" Width="180px"></asp:Label>



</asp:Content>
