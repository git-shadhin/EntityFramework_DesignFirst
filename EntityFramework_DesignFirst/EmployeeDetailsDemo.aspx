<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetailsDemo.aspx.cs" Inherits="EntityFrameworkDemo.EmployeeDetailsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees Detail</title>
    <script src="Scripts/jQuery.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdEmployee" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
        <br />
        <div>
            <table>
                <tr>
                    <td align="right">First Name: </td>
                    <td align="left">
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">Last Name: </td>
                    <td align="left">
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td align="right">Gender: </td>
                    <td align="left">
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right">Salary: </td>
                    <td align="left">
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td align="right">Department: </td>
                    <td align="left">
                        <asp:DropDownList ID="ddlDepartment" runat="server"></asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td align="right"></td>
                    <td align="left">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
