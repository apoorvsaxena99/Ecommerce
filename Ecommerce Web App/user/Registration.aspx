<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Ecommerce_Web_App.user.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
    <tr>
        <td><asp:Label runat="server" Text="First Name" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="fname" Placeholder="Enter First Name" Font-Size="Larger"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fname" ErrorMessage="First Name Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="Last Name" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="lname" Placeholder="Enter Last Name" Font-Size="Larger"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lname" ErrorMessage="Last Name Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="E-Mail" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="email" TextMode="Email" Placeholder="Enter E-Mail" Font-Size="Larger"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Please Write Correct E-Mail Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="Password" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="password" TextMode="Password" Placeholder="Enter Password" Font-Size="Larger"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="password" ErrorMessage="Password Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="Address" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="address" Height="124px" Placeholder="Enter Address" TextMode="MultiLine" Font-Size="Larger"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="address" ErrorMessage="Address Can't Be Blank" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="City" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="city" Font-Size="Larger" Placeholder="Enter City"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="city" ErrorMessage="City Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="State" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="state" Font-Size="Larger" Placeholder="Enter State"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="state" ErrorMessage="State Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="Pincode" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="pincode" Font-Size="Larger" Placeholder="Enter Pincode"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="pincode" ErrorMessage="Pincode Can't Be Blank" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td><asp:Label runat="server" Text="Mobile Number" Font-Size="Larger"/></td>
        <td><asp:TextBox runat="server" ID="mobile" TextMode="Phone" Font-Size="Larger" Placeholder="Enter a Mobile Number"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" BorderColor="#FF3300" ControlToValidate="mobile" ErrorMessage="Mobile Number Should Be Correct" ForeColor="Red" MaximumValue="9999999999" MinimumValue="6000000000" SetFocusOnError="True" Type="Double"></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="b1" OnClick="b1_Click" runat="server" Text="Register" BorderColor="#666699" BorderStyle="Groove" Font-Size="Larger" Width="153px" />
            </td>
    </tr>
    <tr>
        <td colspan="2" align="center"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
        
    </tr>
</table>
</asp:Content>
