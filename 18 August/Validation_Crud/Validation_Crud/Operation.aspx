<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operation.aspx.cs" Inherits="Validation_Crud.Operation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            height: 32px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            height: 36px;
            width: 795px;
        }
        .auto-style5 {
            height: 38px;
            width: 795px;
        }
        .auto-style6 {
            height: 78px;
        }
        .auto-style7 {
            width: 795px;
        }
        .auto-style8 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table class="auto-style1">
                 <tr>
                     <td colspan="2" class="auto-style6">Add the details</td>
                 </tr>
                 <tr>
                     <td class="auto-style2">Name</td>
                     <td class="auto-style7">
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="**Enter the Name**" ForeColor="Red"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style8">Email</td>
                     <td class="auto-style5">
                         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="**Enter the mail**" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="**Invalid Email**" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2">Password</td>
                     <td class="auto-style7">
                         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="**Enter the Password**" ForeColor="Red"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2">Confirm Password</td>
                     <td class="auto-style7">
                         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                         &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="**Enter the confirm password**" ForeColor="Red"></asp:RequiredFieldValidator>
                     &nbsp;&nbsp;&nbsp;
                         <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="*Password Not match**"></asp:CompareValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">Department Id</td>
                     <td class="auto-style4">
                         <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                         &nbsp;&nbsp;&nbsp;
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="**Enter the Dept id**" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="1&gt; and &lt; 3" ForeColor="Blue" MaximumValue="3" MinimumValue="1"></asp:RangeValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>
                     <td class="auto-style4">
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>
                     <td class="auto-style4">
                         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style3">&nbsp;</td>
                     <td class="auto-style4">
                         <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                     </td>
                 </tr>
             </table>
             <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="6" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  width="800px"  OnRowCancelingEdit="GridView1_RowCancelingEdit1" >  
            <Columns>  
                
                <asp:TemplateField HeaderText="ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("Sid") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Name">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("Sname") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("Sname") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Email">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Email" runat="server" Text='<%#Eval("Semail") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Email" runat="server" Text='<%#Eval("Semail") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Password">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_pswd" runat="server" Text='<%#Eval("Spassword") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_pswd" runat="server" Text='<%#Eval("Spassword") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Did">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Did" runat="server" Text='<%#Eval("Departments_Did") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Did" runat="server" Text='<%#Eval("Departments_Did") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Edit">  
                    <ItemTemplate>  
                        
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server" Text="Delete" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>

 
            </Columns>  
             
            <HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#e7ceb6"/>  
        </asp:GridView>  
        </div>
    </form>
</body>
</html>
