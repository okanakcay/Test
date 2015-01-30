<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scroll.aspx.cs" Inherits="lazyloadingtest.scroll" %>

<%@ Import Namespace="lazyloadingtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.js"></script>
    <script src="Scripts/jquery.infinitescroll.js"></script>
    <script>
        $(document).ready(function() {
            $('#category').infinitescroll({
                navSelector: "#page-nav",
                nextSelector: "#page-nav a",
                itemSelector: "#category .item",
                loading: {
                    finished: undefined,
                    finishedMsg: "bitti",
                    msg: null,
                    msgText: "",
                    selector: null,
                    speed: 'slow',
                    start: undefined
                }
                
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 400px;">
            <asp:Repeater runat="server" ID="rptTest">
                <HeaderTemplate>
                    <div id="category">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="item">
                        <%# (GetDataItem() as Products).ProductName%>
                    </div>
                </ItemTemplate>
                <FooterTemplate></div></FooterTemplate>
            </asp:Repeater>
            <div id="page-nav" >
                <a href="<%= NextPage() %>">devam</a>
            </div>
        </div>
    </form>
</body>
</html>
