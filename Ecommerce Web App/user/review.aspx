<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="review.aspx.cs" Inherits="Ecommerce_Web_App.user.review" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server" >
    <div class="container">
        <h4 class="title">Write A Review..!!</h4>
        <asp:TextBox ID="Show" runat="server" TextMode="MultiLine" PlaceHolder="Write A Review" Height="85px" Width="680px" CssClass="active"></asp:TextBox>
    </div>
    <div class="container" >
        <asp:Button runat="server" ID="Cancel" OnClick="Cancel_Click" class="btn btn-danger btn-lg" BorderColor="Red" Font-Size="Larger" ForeColor="Red" Text="Cancel"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" ID="Post" OnClick="Post_Click" class="btn btn-info btn-lg" BackColor="#000099" BorderStyle="Groove" Font-Size="Larger" ForeColor="Yellow" Text="Post A Review"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Show" ErrorMessage="Review Can't Blank..Please Enter A Remark" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    <asp:Label runat="server" ID="abc" Font-Size="Larger" />
    <!--<div class="modal fade" data-keyboard="false" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <!--<div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;tton>
          <h4 class="modal-title">Thank You For The Review..!!!</h4>
        </div>
        <div class="modal-body">
            <form>
               <div class="form-group">
            <h6>SuccessFully You Have Posted A Review..!!</h6>
                    </div>
             </form>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-primary" data-dismiss="modal">Exit</button>
        </div>
      </div>
    </div>
  </div>-->

</asp:Content>
