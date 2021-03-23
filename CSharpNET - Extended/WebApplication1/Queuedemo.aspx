<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Queuedemo.aspx.cs" Inherits="WebApplication1.Queuedemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- my code
                <table  style="border:1px solid black; font-family:Arial; text-align:center">
                <tr>
                    <td>
                        <b>Counter 1</b>
                    </td>
                    <td>
                        <b>Counter 2</b>
                    </td>
                    <td>
                        <b>Counter 3</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtbox1" BackColor="DeepSkyBlue" Width="150px"  ForeColor="White" runat="server" />  
                    </td>
                    <td>
                        <asp:TextBox ID="txtbox2" BackColor="DeepSkyBlue" Width="150px"  ForeColor="White" runat="server" /> 
                    </td>
                    <td>
                        <asp:TextBox ID="txtbox3" BackColor="DeepSkyBlue" Width="150px"  ForeColor="White" runat="server" />  
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="Next" ID="btn1"  runat="server" OnClick="btn1_Click" />
                    </td>
                    <td>
                        <asp:Button Text="Next" ID="btn2"  runat="server" OnClick="btn2_Click" />
                    </td>
                    <td>
                        <asp:Button Text="Next" ID="btn3"  runat="server" OnClick="btn3_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:TextBox ID="counterbox" BackColor="Green" ForeColor="White" Font-Size="Large" Width="500px" runat="server" />  
                    </td>                    
                </tr>
                <tr>        
                    <td></td>
                    <td>
                        <asp:ListBox ID="listtokens" Width="100px"  runat="server">                            
                        </asp:ListBox>
                    </td>  
                    <td></td>
                </tr>
                <tr>
                    <td></td> 
                    <td >
                        <asp:Button Text="Print Token" ID="btnprinttoken" runat="server"  OnClick="btnprinttoken_Click" />
                    </td>  
                    <td></td> 
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="currentStatus" runat="server" />
                    </td>                    
                </tr>
            </table> --%>

            <table style="font-family:Arial; border: 1px solid black; text-align:center">
                <tr>
                    <td>
                        <b>Counter 1</b>
                    </td>
                    <td>
                        <b>Counter 1</b>
                    </td>
                    <td>
                        <b>Counter 1</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCounter1" BackColor="Blue" ForeColor="White" Font-Size="Large" Width="150px" runat="server" />  
                    </td>
                    <td>
                        <asp:TextBox ID="txtCounter2" BackColor="Blue" ForeColor="White" Font-Size="Large" Width="150px" runat="server" />  
                    </td>
                    <td>
                        <asp:TextBox ID="txtCounter3" BackColor="Blue" ForeColor="White" Font-Size="Large" Width="150px" runat="server" />  
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCounter1" Text="Next" Width="100px"  runat="server" OnClick="btnCounter1_Click"  />
                    </td>
                    <td>
                        <asp:Button ID="btnCounter2" Text="Next" Width="100px"  runat="server" OnClick="btnCounter2_Click"  />
                    </td>
                    <td>
                        <asp:Button ID="btnCounter3" Text="Next" Width="100px"  runat="server" OnClick="btnCounter3_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:TextBox ID="txtDisplay" Width="500px" BackColor="Green" ForeColor="White" Font-Size="Large" runat="server" />  
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:ListBox ID="listTokens" Width="100px" Font-Size="Large" runat="server"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Button ID="btnPrintToken" Text="Print Token" runat="server" OnClick="btnPrintToken_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="5"
                        <asp:Label ID="lblStatus" Font-Size="Large" runat="server" />
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
