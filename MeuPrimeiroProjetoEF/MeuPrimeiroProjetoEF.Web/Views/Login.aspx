<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MeuPrimeiroProjetoEF.Web.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Usuario:
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <p>
            Senha:
            <asp:TextBox ID="txtSenha" runat="server" Width="132px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cadastrar" />
        </p>
    </form>
</body>
</html>
