<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="view_full_order.aspx.cs" Inherits="Ecommerce_Web_App.admin.view_full_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     
    <asp:Repeater ID="r2" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr style="background-color:Gray; color:white">
                    <td>Id</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Email</td>
                    <td>Address</td>
                    <td>City</td>
                    <td>State</td>
                    <td>pincode</td>
                    <td>mobile</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("id")%></td>
                <td><%#Eval("fname")%></td>
                <td><%#Eval("lname")%></td>
                <td><%#Eval("email")%></td>
                <td><%#Eval("address")%></td>
                <td><%#Eval("city")%></td>
                <td><%#Eval("state")%></td>
                <td><%#Eval("pincode")%></td>
                <td><%#Eval("mobile")%></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
            </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr style="background-color:Gray; color:white">
                    <td>Product Image</td>
                    <td>Product Name</td>
                    <td>Product Price</td>
                    <td>Product Quantity</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><img src="../<%#Eval("product_images")%>" height="100" width="100"</td>
                <td><%#Eval("product_name")%></td>
                <td><%#Eval("product_price")%></td>
                <td><%#Eval("product_qty")%></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
            </FooterTemplate>
    </asp:Repeater>
    <asp:Label ID="ll" runat="server" Text=""></asp:Label>
</asp:Content>
