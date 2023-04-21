<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowTabularDataBound.aspx.cs" Inherits="LabAss4.ShowTabularDataBound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>GridView<asp:GridView runat="server" ID="GridView1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"></asp:BoundField>
                    <asp:BoundField DataField="passward" HeaderText="passward" SortExpression="passward"></asp:BoundField>
                </Columns>
            </asp:GridView>
            </h1>
        </div>
        <div>
            <h1>DataList<asp:DataList runat="server" ID="DataList1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    UserName:
                    <asp:Label Text='<%# Eval("UserName") %>' runat="server" ID="UserNameLabel" /><br />
                    passward:
                    <asp:Label Text='<%# Eval("passward") %>' runat="server" ID="passwardLabel" /><br />
                    <br />
                </ItemTemplate>
            </asp:DataList></h1>
        </div>
        <div>
            <h1>DetailsView<asp:DetailsView runat="server" Width="125px" Height="50px" ID="DetailsView1" AutoGenerateRows="False" DataSourceID="SqlDataSource1">
                <Fields>
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"></asp:BoundField>
                    <asp:BoundField DataField="passward" HeaderText="passward" SortExpression="passward"></asp:BoundField>
                </Fields>
            </asp:DetailsView>
            </h1>
        </div>
        <div>
            <h1>FromView<asp:FormView runat="server" ID="FromView1" DataSourceID="SqlDataSource1">
                <EditItemTemplate>
                    UserName:
                    <asp:TextBox Text='<%# Bind("UserName") %>' runat="server" ID="UserNameTextBox" /><br />
                    passward:
                    <asp:TextBox Text='<%# Bind("passward") %>' runat="server" ID="passwardTextBox" /><br />
                    <asp:LinkButton runat="server" Text="更新" CommandName="Update" ID="UpdateButton" CausesValidation="True" />&nbsp;<asp:LinkButton runat="server" Text="取消" CommandName="Cancel" ID="UpdateCancelButton" CausesValidation="False" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    UserName:
                    <asp:TextBox Text='<%# Bind("UserName") %>' runat="server" ID="UserNameTextBox" /><br />
                    passward:
                    <asp:TextBox Text='<%# Bind("passward") %>' runat="server" ID="passwardTextBox" /><br />
                    <asp:LinkButton runat="server" Text="插入" CommandName="Insert" ID="InsertButton" CausesValidation="True" />&nbsp;<asp:LinkButton runat="server" Text="取消" CommandName="Cancel" ID="InsertCancelButton" CausesValidation="False" />
                </InsertItemTemplate>
                <ItemTemplate>
                    UserName:
                    <asp:Label Text='<%# Bind("UserName") %>' runat="server" ID="UserNameLabel" /><br />
                    passward:
                    <asp:Label Text='<%# Bind("passward") %>' runat="server" ID="passwardLabel" /><br />

                </ItemTemplate>
            </asp:FormView>
            </h1>
        </div>
        <div>
            <h1>Repeater<asp:Repeater runat="server" ID="Repeater1" DataSourceID="SqlDataSource1">
                <ItemTemplate><%#Eval("Username") %>
                                    <i>-->y</i>
                             <%#Eval("passward") %>
                </ItemTemplate>
                        </asp:Repeater>
            </h1>
        </div>
        <div>
            <h1>ListView<asp:ListView runat="server" ID="ListView1" DataSourceID="SqlDataSource1">
                 <ItemTemplate><%#Eval("Username") %>
                                    <i>--></i>
                             <%#Eval("passward") %>
                </ItemTemplate>
                        </asp:ListView>
                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:SimpleDatabseConnectionString %>" SelectCommand="SELECT [UserName], [passward] FROM [Logon]"></asp:SqlDataSource>
            </h1>
        </div>
    </form>
</body>
</html>
