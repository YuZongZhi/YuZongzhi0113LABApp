<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="LabAss6.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Convert:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Label ID="Label2" runat="server" Text="Chinese Yuan to Dollars:"></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Label runat="server" ID="Label3"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
