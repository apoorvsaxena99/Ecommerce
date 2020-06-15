<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="payment_gateway.aspx.cs" Inherits="Ecommerce_Web_App.user.payment_gateway" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <form>
                <div class="form-group">
                <asp:Label runat="server" Text="Total Amount You Have To Pay: Rs." style="font-size: 20px;"></asp:Label>
                    <asp:Label runat="server" Text="" ID="Total" style="font-size: 20px;"></asp:Label>
            <!--<asp:TextBox class="form-control" runat="server" ID="email" Placeholder="Write an E-mail"></asp:TextBox>!-->
                    </div> 
         <br /><br /><br />
               <div class="form-group">
            <asp:Label runat="server" Text="Confirm Your Password Again:-" style="font-size: 20px;"></asp:Label>
          <asp:TextBox class="form-control" runat="server" ID="TextBox1" Placeholder="Please Enter Your Password Again..!!" TextMode="Password" style="font-size:20px;    width: 350px;
    height: 30px;"></asp:TextBox>
                    </div>
         <br />
              <input type="checkbox" id="pass" onchange="shwpass(this)" style="margin-left:400px" />  Show Password
         <div>
                <asp:Button class="btn btn-primary " runat="server" Text="Pay Now" ID="Button1" OnClick="pay_Click" CssClass="search-submit" style="       width: 400px;
    height: 30px;
    margin-left: 130px;"/>
         </div>
             </form>
     <script type="text/javascript">
         function shwpass(check_box) {
             var spass = document.getElementById('<%=TextBox1.ClientID %>');
             console.log(spass, check_box);
             if ($(check_box).is(":checked"))
                 spass.setAttribute("type", "text");
             else
                 spass.setAttribute("type", "password");
         }
         function Show() {
             alert("Registered Successfully");
         }
           </script>
</asp:Content>
