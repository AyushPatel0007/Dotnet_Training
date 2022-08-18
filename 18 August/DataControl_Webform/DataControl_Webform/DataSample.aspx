<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSample.aspx.cs" Inherits="DataControl_Webform.DataSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="_first" HeaderText="_first" SortExpression="_first" />
                    <asp:BoundField DataField="_last" HeaderText="_last" SortExpression="_last" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="AddedList" TypeName="DataControl_Webform.Publisher">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="s" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <br />
            <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
                <EditItemTemplate>
                    _first:
                    <asp:TextBox ID="_firstTextBox" runat="server" Text='<%# Bind("_first") %>' />
                    <br />
                    _last:
                    <asp:TextBox ID="_lastTextBox" runat="server" Text='<%# Bind("_last") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    _first:
                    <asp:TextBox ID="_firstTextBox" runat="server" Text='<%# Bind("_first") %>' />
                    <br />
                    _last:
                    <asp:TextBox ID="_lastTextBox" runat="server" Text='<%# Bind("_last") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    _first:
                    <asp:Label ID="_firstLabel" runat="server" Text='<%# Bind("_first") %>' />
                    <br />
                    _last:
                    <asp:Label ID="_lastLabel" runat="server" Text='<%# Bind("_last") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
