<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Teste.WebForm2" %>
  <!DOCTYPE html>
  <html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Clickount</title>
    <link rel="stylesheet" href="bootstrap.css" />
  </head>
  <body>
    <form runat="server">
      <center>
        <h1>Click counter</h1>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />&nbsp;
        <asp:Button ID="btn" runat="server" Text="Add" OnClick="btn_Click" CssClass="btn btn-primary"></asp:Button>
    </form>
  </body>
  </html>
  
  //https://pt.stackoverflow.com/q/91940/101
