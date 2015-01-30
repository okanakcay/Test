<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="lazyloadingtest.test" %>
<%@ Import Namespace="lazyloadingtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lblTitle"></asp:Label>

    <asp:Repeater runat="server" ID="rptCustomer">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
            <li>
                <%# Eval("CategoryName") %> - <%# (GetDataItem() as CustomerEntity).City.Name %>
            </li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
