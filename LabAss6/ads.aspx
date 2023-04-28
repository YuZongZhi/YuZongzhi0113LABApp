<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ads.aspx.cs" Inherits="LabAss6.ads" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="auto-style2">
            <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/App_Data/AdlistXMLFile.xml" />
        </div>
        <div>
            <h2>This is my advertisement page</h2>
        </div>
        <div class ="auto-style1">
            
            <asp:AdRotator runat="server" ID="AdRotator1" AdvertisementFile="~/App_Data/AdlistXMLFile.xml"></asp:AdRotator>

        </div>
    </form>
</body>
</html>
