<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="display_order.aspx.cs" Inherits="Ecommerce_Web_App.admin.display_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater ID="r1" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr style="background-color:Gray; color:white">
                    <td>Id</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>City</td>
                    <td>State</td>
                    <td>pincode</td>
                    <td>View Full Order</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("id")%></td>
                <td><%#Eval("fname")%></td>
                <td><%#Eval("lname")%></td>
                <td><%#Eval("city")%></td>
                <td><%#Eval("state")%></td>
                <td><%#Eval("pincode")%></td>
                <td><a href="view_full_order.aspx?id=<%#Eval("id")%>>">View Full Order</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
            </FooterTemplate>
    </asp:Repeater>
</asp:Content>
