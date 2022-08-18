<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Project_Webform.Product" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Selected="True">Fashion</asp:ListItem>
        <asp:ListItem>Shirts</asp:ListItem>
        <asp:ListItem>Tshirts</asp:ListItem>
        <asp:ListItem>Pants</asp:ListItem>
    </asp:DropDownList>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem Selected="True">Footwear</asp:ListItem>
        <asp:ListItem>Sleeper</asp:ListItem>
        <asp:ListItem>Shoes</asp:ListItem>
        <asp:ListItem>Shocks</asp:ListItem>


    </asp:DropDownList>

    &nbsp;&nbsp;&nbsp;

    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem Selected="True">Electronics</asp:ListItem>
        <asp:ListItem>Mobile</asp:ListItem>
        <asp:ListItem>Tablet</asp:ListItem>
        <asp:ListItem>Laptop</asp:ListItem>
    </asp:DropDownList>

    
    &nbsp;&nbsp;&nbsp;

    <asp:DropDownList ID="DropDownList4" runat="server">
        <asp:ListItem Selected="True">Home</asp:ListItem>
        <asp:ListItem>Badsheets</asp:ListItem>
        <asp:ListItem>Blanket</asp:ListItem>
        <asp:ListItem>Pillow</asp:ListItem>
    </asp:DropDownList>

    &nbsp;&nbsp;&nbsp;
     <asp:DropDownList ID="DropDownList5" runat="server">
        <asp:ListItem Selected="True">Grooming</asp:ListItem>
        <asp:ListItem>Facewash</asp:ListItem>
        <asp:ListItem>Beard oil</asp:ListItem>
        <asp:ListItem>Shampoo</asp:ListItem>
    </asp:DropDownList>



   


&nbsp;


</asp:Content>
