<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="update_order_details.aspx.cs" Inherits="Ecommerce_Web_App.user.update_order_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
    <tr>
        <td>First Name</td>
        <td><asp:TextBox runat="server" ID="fname"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Last Name</td>
        <td><asp:TextBox runat="server" ID="lname"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Address</td>
        <td><asp:TextBox runat="server" ID="address" Height="124px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td>City</td>
        <td><asp:TextBox runat="server" ID="city"></asp:TextBox></td>
    </tr>
    <tr>
        <td>State</td>
        <td><asp:TextBox runat="server" ID="state"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Mobile Number</td>
        <td><asp:TextBox runat="server" ID="mobile" TextMode="Phone"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="b1" OnClick="b1_Click" runat="server" Text="Update And Continue" />
            </td>
    </tr>
    <tr>
        <td colspan="2" align="center"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
        
    </tr>
</table>
</asp:Content>
