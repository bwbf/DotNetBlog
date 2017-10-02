<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MeuPrimeiroProjetoEF.Web.Views.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblNomeUser" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="txtPost" runat="server" Width="579px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Publicar" />
    </form>
</body>
</html>
