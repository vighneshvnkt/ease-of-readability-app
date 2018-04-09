<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OtherPage.aspx.cs" Inherits="OtherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
    <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="WordText" HeaderText="Word Text" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Gloss" HeaderText="Meaning" />
    </Columns>
</asp:GridView>

    </form>
    </body>
</html>
