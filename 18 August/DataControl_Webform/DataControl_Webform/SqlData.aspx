<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlData.aspx.cs" Inherits="DataControl_Webform.SqlData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Sid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Sid" HeaderText="Sid" InsertVisible="False" ReadOnly="True" SortExpression="Sid" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="Semail" HeaderText="Semail" SortExpression="Semail" />
                    <asp:BoundField DataField="Spassword" HeaderText="Spassword" SortExpression="Spassword" />
                    <asp:BoundField DataField="Departments_Did" HeaderText="Departments_Did" SortExpression="Departments_Did" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:demo5ConnectionString %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
