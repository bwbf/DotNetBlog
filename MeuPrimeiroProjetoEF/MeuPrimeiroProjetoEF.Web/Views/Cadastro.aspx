<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="MeuPrimeiroProjetoEF.Web.Views.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Email<asp:TextBox ID="txtEmai" runat="server" Width="401px"></asp:TextBox>
        <p>
            Nome<asp:TextBox ID="txtNome" runat="server" Width="400px"></asp:TextBox>
        </p>
        <p>
            Usuario<asp:TextBox ID="txtUsusario" runat="server" Width="387px"></asp:TextBox>
        </p>
        <p>
            Senha<asp:TextBox ID="txtSenha" runat="server" Width="399px"></asp:TextBox>
        </p>
        <p>
            Confirmar Senha<asp:TextBox ID="txtConfirmaSenha"  runat="server" Width="329px"></asp:TextBox>
        </p>
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
    </form>
</body>
</html>

