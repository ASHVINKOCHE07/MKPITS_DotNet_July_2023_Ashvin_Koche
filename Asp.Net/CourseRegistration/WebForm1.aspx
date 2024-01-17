<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CourseRegistration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
            text-decoration: underline;
            color: #CC6600;
        }
        .newStyle1 {
            font-family: Arial;
        }
        .auto-style2 {
            width: 1915%;
            border-collapse: collapse;
            height: 169px;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style5 {
            width: 166px;
            height: 77px;
        }
        .auto-style6 {
            width: 100%;
            height: 202px;
        }
        .auto-style7 {
            height: 26px;
            text-decoration: underline;
            text-align: center;
        }
        .auto-style8 {
            text-align: left;
        }
        .auto-style9 {
            width: 140px;
        }
        .auto-style10 {
            width: 801px;
        }
        .auto-style11 {
            width: 140px;
            height: 26px;
        }
        .auto-style12 {
            width: 801px;
            height: 26px;
        }
        .auto-style13 {
            height: 243px;
            width: 166px;
        }
        .auto-style14 {
            width: 100%;
            border-collapse: collapse;
            height: 265px;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style15 {
            height: 27px;
        }
        .auto-style16 {
            font-weight: normal;
            text-decoration: underline;
        }
        .auto-style17 {
            height: 377px;
        }
        .auto-style18 {
            width: 100%;
        }
        .auto-style19 {
            text-decoration: underline;
        }
        .newStyle2 {
            font-family: "Arial Black";
        }
        .newStyle3 {
            font-family: "Arial Black";
        }
        .newStyle4 {
            font-family: "Arial Black";
        }
        .auto-style21 {
            height: 27px;
            width: 187px;
        }
        .auto-style22 {
            width: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong class="newStyle1"><em>COURSE REGISTRATION</em></strong></div>
        <table class="auto-style14">
            <tr>
                <td class="auto-style5">
                    <asp:Panel ID="Panel1" runat="server" Height="198px" Width="490px">
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style7" colspan="2">
                                    <h4 class="auto-style8"><span class="newStyle3">USER DETAILS</span></h4>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Full Name</td>
                                <td class="auto-style12">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">Gender</td>
                                <td class="auto-style10">
                                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Other" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">Category</td>
                                <td class="auto-style12">
                                    <asp:RadioButton ID="RadioButton4" runat="server" Text="Student" />
                                    <asp:RadioButton ID="RadioButton5" runat="server" Text="IT Professional" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td rowspan="2">
                    <asp:Panel ID="Panel3" runat="server">
                        <div class="auto-style17">
                            <table class="auto-style18">
                                <tr>
                                    <td class="auto-style19" colspan="2">
                                        <h4><strong class="newStyle2">Fees Details</strong></h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Payment Date</td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Total Amount</td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Fess Paid</td>
                                    <td>
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Balance Amount</td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:Panel ID="Panel2" runat="server" Height="108px" Width="26px">
                        <table class="auto-style2">
                            <tr>
                                <td colspan="2">
                                    <h4 class="auto-style16"><strong class="newStyle4">Address</strong></h4>
                                </td>
                            </tr>
                            <tr>
                                <td>Country</td>
                                <td class="auto-style22">
                                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>State</td>
                                <td class="auto-style22">
                                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style15">City</td>
                                <td class="auto-style21">
                                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
