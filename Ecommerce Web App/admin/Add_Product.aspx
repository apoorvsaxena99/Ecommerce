<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="Ecommerce_Web_App.admin.Add_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
<h1>Add Product Page</h1>
<table>
    <tr>
        <td>Product Name</td>
        <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td>Product Description</td>
        <td><asp:TextBox ID="description" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td>Product Price</td>
        <td><asp:TextBox ID="price" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td>Product Quantity</td>
        <td><asp:TextBox ID="quantity" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td>Product Image</td>
        <td><asp:FileUpload runat="server" ID="image" /></td>
    </tr>
<tr>
    <td>Select Category</td>
    <td><asp:DropDownList ID="dd" runat="server"></asp:DropDownList></td>
</tr>
    <tr>
        <td colspan="2" align="center">
        <asp:Button ID="Upload" Text="Upload" runat="server" OnClick="Upload_Click"></asp:Button></td>
    </tr>
</table>





</asp:Content>
