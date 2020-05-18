<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ecommerce_Web_App.user.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
        <tr>
            <td><asp:Label runat="server" Text="Enter Email" Font-Size="Larger"/></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="email" CssClass="active" BorderStyle="Groove" Width="195px" Placeholder="Enter an E-mail.." Font-Size="Larger"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Invalid Email(Please Enter Correct E-Mail)" Font-Bold="True" Font-Underline="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="Enter Password" Font-Size="Larger"/></td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="password" TextMode="Password" BorderStyle="Groove" Width="197px" Placeholder="Enter a Password..!!" Font-Size="Larger"></asp:TextBox>
                &nbsp;&nbsp;  <input type="checkbox" id="pass" onclick="showpass(this);" />
            Show password

                &nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ErrorMessage="Password Can't Be Blank" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" style="height: 39px"><asp:Button runat="server" ID="Login" OnClick="Login_Click" Text="Login" BackColor="Gray" Font-Bold="True" Font-Italic="True" Font-Names="Franklin Gothic Book" Height="32px" Width="154px" BorderStyle="Ridge"/>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center"><asp:Label runat="server" ID="Label" Text=""></asp:Label>
            </td>

        </tr>
    </table>
    <div class="box">
        <asp:Button runat="server" ID="Registration" OnClick="Registration_Click" Text="New User?..Sign Up Now" BorderStyle="Solid" Font-Size="Larger" ForeColor="#CC3399" />
    </div>
    <script type="text/javascript">
        function showpass(check_box) {
            var spass = document.getElementById("password");
            if (check_box.checked)
                spass.setAttribute("type", "text");
            else
                spass.setAttribute("type", "password");
        }
           </script>
</asp:Content>
