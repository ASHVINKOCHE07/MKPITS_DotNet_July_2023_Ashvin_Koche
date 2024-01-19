<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Billingorder.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            text-decoration: underline;
            text-align: center;
        }
        .auto-style2 {
            width: 99%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
            height: 325px;
            background-color: #FFCCCC;
        }
        .newStyle1 {
            font-family: "Vladimir Script";
            font-size: 10px;
            font-weight: bolder;
            font-style: oblique;
            font-variant: inherit;
            text-transform: none;
            color: #FF3300;
            text-decoration: underline overline;
            border-style: dotted;
        }
        .auto-style4 {
            font-family: "Vladimir Script";
            font-size: xx-large;
            font-weight: bolder;
            font-style: oblique;
            font-variant: inherit;
            text-transform: none;
            color: #FF3300;
            text-decoration: underline overline;
            border-style: dotted;
        }
        .auto-style6 {
            height: 29px;
            width: 186px;
        }
        .auto-style8 {
            height: 29px;
            text-align: center;
            width: 731px;
            background-color: #FFFFFF;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            width: 186px;
            height: 32px;
        }
        .auto-style13 {
            width: 186px;
            height: 33px;
            background-color: #FFFFCC;
        }
        .auto-style14 {
            height: 32px;
            width: 731px;
            background-color: #FFFFFF;
        }
        .auto-style15 {
            height: 33px;
            width: 186px;
        }
        .auto-style16 {
            height: 33px;
            width: 731px;
            background-color: #FFFFFF;
        }
        .auto-style17 {
            float: left;
            width: 883px;
            height: 243px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="width: 878px; height: 648px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h4>
            <strong class="auto-style4">&nbsp;&nbsp; Billing Order&nbsp;&nbsp;&nbsp;&nbsp; </strong></h4>
        </div>
            <strong class="auto-style4">
        <img alt="" class="auto-style17" src="electronics-store-sale-shopping-shop-with-offers-vector-28045120.jpg" /></strong><table class="auto-style2" align="left">
            <tr>
                <td class="auto-style12">1.Order No.</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style11" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">2.Custumer Name</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">3.Order Date</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Date" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">4.Product</td>
                <td class="auto-style14">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="150px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Mouse</asp:ListItem>
                        <asp:ListItem>Keyboard</asp:ListItem>
                        <asp:ListItem>AC</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">5.Price</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">6.Quantity</td>
                <td class="auto-style16">
                    <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" Width="98px" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style16"></td>
            </tr>
        </table>
    </form>
</body>
</html>
