<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="payment_gateway.aspx.cs" Inherits="Ecommerce_Web_App.user.payment_gateway" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Pay Now</button>
     <div class="modal fade" data-keyboard="false" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Amount To Pay</h4>
        </div>
        <div class="modal-body">
            <form>
                <div class="form-group">
                <asp:Label runat="server" Text="Total Amount You Have To Pay" style="animation-name:movearound">&nbsp; $</asp:Label>
                    <asp:Label runat="server" Text="" ID="Total" style="animation-fill-mode:backwards"></asp:Label>
            <!--<asp:TextBox class="form-control" runat="server" ID="email" Placeholder="Write an E-mail"></asp:TextBox>!-->
                    </div> 
               <div class="form-group">
            <asp:Label runat="server" Text="Password"></asp:Label>
          <asp:TextBox class="form-control" runat="server" ID="TextBox1" Placeholder="Please Enter Your Password Again..!!"></asp:TextBox>
                    </div>
             </form>
        </div>
        <div class="modal-footer">
            <asp:Button class="btn btn-primary " runat="server" Text="Pay Now" ID="pay" OnClick="pay_Click"/>
          <button type="button" class="btn btn-primary" data-dismiss="modal">Cancel</button>
        </div>
      </div>
      
    </div>
  </div>
</asp:Content>
