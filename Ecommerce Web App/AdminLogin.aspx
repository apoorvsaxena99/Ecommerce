<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Ecommerce_Web_App.AdminLogin" %>

<!DOCTYPE html>
<html >
  <head>
    <meta charset="UTF-8">
    <title>Admin Login</title>
        <link rel="stylesheet" href="logincss/style.css">
  </head>
  <body>
<form id="f1" runat="server">
  <header>Login</header>
  <label>Username <span>*</span></label>
  <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
  <div class="help">At least 6 character</div>
  <label>Password <span>*</span></label>
  <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
  <br /><br />
    <asp:Button runat="server" ID="b1" OnClick="b1_Click" Text="Login" />
    
    <br /><asp:Label runat="server" ID="msg" Text="" CssClass="help"></asp:Label>
    <br />
</form>
  </body>
</html>
