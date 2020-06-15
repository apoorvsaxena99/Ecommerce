<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ecommerce_Web_App.user.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
        <tr>
            <td><asp:Label runat="server" Text="Email" Font-Size="Larger"/></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="email" CssClass="active" BorderStyle="Groove" Width="195px" Placeholder="Enter an E-mail.." Font-Size="Larger"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email Can't Be Blank" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Invalid Email(Please Enter Correct E-Mail)" Font-Bold="True" Font-Underline="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Login"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="Password" Font-Size="Larger"/></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server"  ID="password" TextMode="Password" BorderStyle="Groove" Width="197px" Placeholder="Enter a Password..!!" Font-Size="Larger" ValidationGroup="Login"></asp:TextBox>
                &nbsp;&nbsp;  <input type="checkbox" id="pass" onchange="shwpass(this)"  />
            Show password

                &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ErrorMessage="Password Can't Be Blank" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" style="height: 39px"><asp:Button runat="server" ID="Login" OnClick="Login_Click" Text="Login" style="font-family:Franklin Gothic Book;font-weight:bold;font-style:italic;height:32px;width: 199px;margin-right: 259px;" ValidationGroup="Login" CssClass="search-submit" />&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center"><asp:Label runat="server" ID="Label" Text=""></asp:Label>
            </td>

        </tr>
    </table>
    <div >
        <asp:Button runat="server" Text="New User..? Sign Up Now..!!" OnClick="SignUp_Click" ID="SignUp"  CssClass="search-submit" style="width: 220px;
    height: 43px;"/>
    </div>
    <script type="text/javascript">
        function shwpass(check_box) {
            var spass = document.getElementById('<%=password.ClientID %>');
            console.log(spass, check_box);
            if ($(check_box).is(":checked"))
                spass.setAttribute("type", "text");
            else
                spass.setAttribute("type", "password");
        }
           </script>
</asp:Content>
