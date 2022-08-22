<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LInqAssesment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem>red</asp:ListItem>
                <asp:ListItem>green</asp:ListItem>
                <asp:ListItem>blue</asp:ListItem>
                <asp:ListItem>yellow</asp:ListItem>
                <asp:ListItem>pink</asp:ListItem>
                <asp:ListItem>black</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple">
                <asp:ListItem>white</asp:ListItem>
                <asp:ListItem>red</asp:ListItem>
                <asp:ListItem>blue</asp:ListItem>
                <asp:ListItem>pink</asp:ListItem>
                <asp:ListItem>grey</asp:ListItem>
                <asp:ListItem>yellow</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="44px" Text="Submit" Width="146px" />
        </div>
    </form>
</body>
</html>
