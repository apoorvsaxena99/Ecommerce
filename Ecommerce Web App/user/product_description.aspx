<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="product_description.aspx.cs" Inherits="Ecommerce_Web_App.user.product_description" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
        <asp:Repeater ID="d1" runat="server">
    <HeaderTemplate>

    </HeaderTemplate>
    <ItemTemplate>
    <div style="height:300px;width:600px;border-style:solid;border-width:1px;">

        <div style="height:300px;width:200px;float:left;border-style:solid;border-width:1px;">
            <img src='../<%#Eval("product_images")%>' height="300" width="200" />
        </div>
        <div style="height:300px;width:395px;float:left;border-style:solid;border-width:1px;">
            Item Name=<%#Eval("product_name")%><br />product_desc=<%#Eval("product_desc")%><br />product_price=<%#Eval("product_price")%><br />product_qty=<%#Eval("product_qty")%><br /></div>
         
    </div>
    </ItemTemplate>
    <FooterTemplate>
        
    </FooterTemplate>
        </asp:Repeater>
    <br />
    <div> 
       <table>
        <tr>
            <td><asp:Label ID="l2" runat="server" Text="Enter Quantity"/></td>
            <td><asp:TextBox runat="server" ID="t1" /></td>
            <td><asp:Button runat="server" ID="Cart" Text="Add To Cart" OnClick="Cart_Click" /></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="l1" runat="server" ForeColor="Red" Text="" />
            </td>
        </tr>
    </table></div> 
    <br />

   <asp:Repeater ID="d2" runat="server">
       <HeaderTemplate>
       </HeaderTemplate>
       <ItemTemplate>
         
           <div style="height:100px;width:600px;border-style:solid;border-width:1px;">

        <div style="height:100px;width:200px;float:left;border-style:solid;border-width:1px;">
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("name")%>' />
        </div>
        <div style="height:100px;width:395px;float:left;border-style:solid;border-width:1px;">
            <asp:Label ID="DescLabel" runat="server" Text='<%#Eval("review")%>' />
            
        </div>
         
    </div>
       </ItemTemplate>
       <FooterTemplate>
       </FooterTemplate>
   </asp:Repeater>
    

</asp:Content>
