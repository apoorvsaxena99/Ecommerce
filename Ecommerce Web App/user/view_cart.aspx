<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="view_cart.aspx.cs" Inherits="Ecommerce_Web_App.user.view_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    <div>
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table border="1">
                    <tr style="background-color:silver;color:white;font-weight:bold;">
                        <td>product image</td>
                        <td>product name</td>
                        <td>product description</td>
                        <td>product price</td>
                        <td>product qty</td>
                        <td>delete</td>

                        </tr>
            </HeaderTemplate>
            <ItemTemplate>
              <tr>
                  <td><img src="../<%#Eval("product_images")%>" height="100" width="100"</td>
                  <td><%#Eval("product_name")%></td>
                  <td><%#Eval("product_desc")%></td>
                  <td><%#Eval("product_price")%></td>
                  <td><%#Eval("product_qty")%></td>
                  <td>
                      <a href="delete_cart.aspx?id=<%#Eval("id")%>">delete</a>
                  </td>
              </tr>
            </ItemTemplate>
            <FooterTemplate>
            </table>
                </FooterTemplate>
        </asp:DataList>
        <br />
        <p align="center"></p>
        <asp:Label runat="server" ID="l1" style="font-size:25px;font-family:'Arial Rounded MT'"></asp:Label>
        <asp:button runat="server" Text="Checkout" ID="b1" OnClick="b1_Click" CssClass="search-submit" style="    width: 201px;
    height: 50px;
    font-size: 20px;"/>
    </div>
    </asp:Content>