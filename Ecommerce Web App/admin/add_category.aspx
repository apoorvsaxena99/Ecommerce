<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="add_category.aspx.cs" Inherits="Ecommerce_Web_App.admin.add_category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
        <tr>
            <td>Enter Category Name</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" ID="Input" Width="148px"></asp:TextBox></td>
        </tr>
<tr>
            <td colspan="2" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button runat="server" Text="Add Category" ID="b1" OnClick="b1_Click"/></td>
        </tr>

    </table>

    <asp:DataList ID="d1" runat="server">
        <HeaderTemplate>
            <table>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("category")%></td><br />
                <td><a href="delete.aspx?category=<%#Eval("category")%>>">Delete</a></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:DataList>
</asp:Content>
