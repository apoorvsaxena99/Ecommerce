<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Ecommerce_Web_App.Payment_Gateway_Dialog.Payment" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form runat="server">
        <asp:Hyperlink id="hl1" runat="server" NavigateUrl="~/user/review.aspx">Review</asp:Hyperlink>
<div class="container">
  <h2>Payment Page</h2>
  <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Pay Now</button>

  <!-- Modal -->
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

                <asp:Label runat="server" Text="Email"></asp:Label>
            <asp:TextBox class="form-control" runat="server" ID="email" Placeholder="Write an E-mail"></asp:TextBox>
                    </div> 
                <div class="form-group">
            <asp:Label runat="server" Text="Password"></asp:Label>
          <asp:TextBox class="form-control" runat="server" ID="TextBox1" Placeholder="Write an Password"></asp:TextBox>
                    </div>
             </form>
        </div>
        <div class="modal-footer">
            <a href="view_full_order.aspx">vIEW fULL ORDER</a>
          <button type="button" class="btn btn-primary" data-dismiss="modal">Cancel</button>
        </div>
      </div>
      
    </div>
  </div>
  
</div>
        </form>
</body>
</html>
