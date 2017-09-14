<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnonymousAuth.aspx.cs" Inherits="WebformAuth.AnonymousAuth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:gridview ID="GridView1" runat="server">
        </asp:gridview>
        <asp:Button ID="Button1" runat="server" Text="Load Data" OnClick="Button1_Click1" />
    </div>
    </form>
</body>
</html>
