<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDemo.aspx.cs" Inherits="XmlDemoPractise.XmlDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="" />
    <asp:ListItem Text="USA" Value="USA" />
    <asp:ListItem Text="USA1" Value="USA1" />

    <asp:ListItem Text="UK" Value="UK" />
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="City"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Selected="True">All</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Seattle</asp:ListItem>
                <asp:ListItem>Bareilly</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1" Height="164px" Width="502px">
            <Columns>
                <asp:BoundField HeaderText="Id" />
                <asp:BoundField HeaderText="City" />
                <asp:BoundField HeaderText="Country" />
                <asp:BoundField HeaderText="Name" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Employees.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
