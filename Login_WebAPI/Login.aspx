<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Panda.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="UserName" runat="server" />
        <asp:TextBox ID="txt_username" runat="server" />
        <br />
        <asp:Label Text="PassWord" runat="server" />
        <asp:TextBox ID="txt_pwd" runat="server" />
        <br />
        <asp:Button Text="Login" OnClick="btn_Click" runat="server" />
        <asp:Button Text="Clear" runat="server" />
    </div>
    </form>
</body>
</html>
