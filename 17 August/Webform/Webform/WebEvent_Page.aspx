<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebEvent_Page.aspx.cs" Inherits="Webform.WebEvent_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Change events</h1>
            <asp:TextBox ID="TextBox1" AutoPostBack="true" runat="server" OnTextChanged="CtrlChanged"></asp:TextBox>
            
            <br />
            <br />
            
            <asp:CheckBox ID="Chk" runat="server" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />

            <br />
            <br />

            <asp:RadioButton ID="Rd1" runat="server" GroupName="Sample" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />
            <asp:RadioButton ID="Rd2" runat="server" GroupName="Sample" AutoPostBack="true" OnCheckedChanged="CtrlChanged" />
            <h1>&nbsp;</h1>
            <h1>List of events</h1>

            <br />

            <asp:ListBox ID="Lstevents" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
