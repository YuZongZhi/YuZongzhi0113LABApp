<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowListControls.aspx.cs" Inherits="LabAss4.ShowListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div><h1>ListBox</h1> </div>
        <asp:ListBox runat="server" ID="ListBox1" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource1"></asp:ListBox>
        
        <div><h1> DropDownList</h1></div>
        <asp:DropDownList runat="server" ID="DropDownList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource1"></asp:DropDownList>  
        
        <div><h1>BulletedList</h1></div>
        <asp:BulletedList runat="server" ID="BulletedList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource1"></asp:BulletedList>
        
        <div><h1>CheckBoxList</h1></div>
        <asp:CheckBoxList runat="server" ID="CheckBoxList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource1"></asp:CheckBoxList>

        <div><h1>RadioButtonList</h1></div>
        <asp:RadioButtonList runat="server" ID="RadioButtonList1" DataTextField="UserName" DataValueField="UserName" DataSourceID="SqlDataSource1"></asp:RadioButtonList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:SimpleDatabseConnectionString %>" SelectCommand="SELECT [UserName], [passward] FROM [Logon]"></asp:SqlDataSource>
    </form>
</body>
</html>
