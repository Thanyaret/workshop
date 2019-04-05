<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CalendarInsert.aspx.cs" Inherits="CalendarInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <p>
        <asp:DropDownList ID="DropDownListDay" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListMonth" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListYear" runat="server">
        </asp:DropDownList>
        <br />
    </p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="บันทึก" CssClass="btn-primary" />
        <asp:Label ID="Labelupload" runat="server" ForeColor="#00CC00" Text="อัพโหลดสำเร็จ" Visible="False"></asp:Label>
        <asp:LinkButton ID="LinkButton1" href="Default.aspx" runat="server">ย้อนกลับ</asp:LinkButton>
    </p>
    <p>
        
    </p>

</asp:Content>

