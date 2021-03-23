<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border: 1px solid double">
            <tr>
                <td>
                    Country Code:
                </td>
                <td>
                    <asp:TextBox ID="txtCountryCode" runat="server" AutoPostBack="True" OnTextChanged="txtCountryCode_TextChanged" />
                </td>
            </tr>
            <tr>
                <td>
                    Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" />  
                </td>
            </tr>
            <tr>
                <td>
                    Captial:
                </td>
                <td>
                    <asp:TextBox ID="txtCapital" runat="server" />  
                </td>
            </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="label1" runat="server"  ForeColor="Red"/>
                    </td>
                </tr>
                </table>
        </div>
    </form>

</body>
</html>
