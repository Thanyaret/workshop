<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <a href="CalendarInsert.aspx"><input type="button" value="UploadFile"></a>
    <br />
    <br />
    <br />
    <asp:Label ID="LabelOnclick" runat="server"></asp:Label>
    <br />
    <br />
<asp:Calendar ID="Calendar1" runat="server" Height="376px" Width="862px" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>

</asp:Content>
