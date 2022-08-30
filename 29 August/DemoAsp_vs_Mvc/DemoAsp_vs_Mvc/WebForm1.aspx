<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoAsp_vs_Mvc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Send next page" />
            <br />
            <br />
            <br />
            For Cookie<br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="SetCookie" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="height: 35px" Text="GetCookie" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            For Session<br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Session Visit" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
