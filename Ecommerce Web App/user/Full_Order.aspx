<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Full_Order.aspx.cs" Inherits="Ecommerce_Web_App.user.Full_Order" %>
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
                    <td>Add Review</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><img src="../<%#Eval("product_images")%>" height="100" width="100"</td>
                <td><%#Eval("product_name")%></td>
                <td><%#Eval("product_price")%></td>
                <td><%#Eval("product_qty")%></td>
                <td><button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Review</button></td>
            </tr>

        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
                <div class="modal fade" data-keyboard="false" id="myModal" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Write A Review</h4>
        </div>
        <div class="modal-body">
               <div class="form-group">
            <asp:Label runat="server" Text="Product's Review"></asp:Label>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                   </div>
            </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancel</button>
            <asp:Button ID="Button1" runat="server" Text="Post A Review" OnClick="Button1_Click" />
            </div>
      </div>
      
    </div>
  </div>
</asp:Content>
