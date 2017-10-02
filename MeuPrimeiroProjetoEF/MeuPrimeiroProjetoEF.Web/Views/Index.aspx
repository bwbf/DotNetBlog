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

      


            <asp:ListView runat="server" ID="ListView1">
                  <ItemTemplate>
                    <tr runat="server">
                      <td runat="server">
                        <%-- Data-bound content. --%>
                          <p>
                          <asp:Label ID="NomePost" runat="server"/>
                              </p>
                          <p>
                          <asp:Label ID="Label2" runat="server" 
                          Text='<%#Eval("Conteudo") %>' />
                              </p>
                          <p>
                        <asp:Label ID="NameLabel" runat="server" 
                          Text='<%#Eval("DataPost") %>' />
                              </p>
                      </td>
                    </tr>
                  </ItemTemplate>
           </asp:ListView>
                   

    </form>
</body>
</html>
