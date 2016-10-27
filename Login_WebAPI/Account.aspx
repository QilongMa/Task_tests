<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Panda.Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.1.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>User Information</h2>
        <asp:Label Text="UserName" runat="server" />
        <asp:TextBox ID="txt_usrname" runat="server" />
        <br />
        <asp:Label Text="PassWord" runat="server" />
        <asp:TextBox ID="txt_pwd" runat="server" />
        <br />
        <asp:Button Text="Save" OnClick="btnSave_Click" runat="server" />
        <input type="button" name="name" id="btncancle" value="Cancle" />
    </div>
    </form>
    <script>
        $("#btncancle").on("click", function () {
            $("#form1")[0].reset();            
        });
    </script>
</body>
</html>
