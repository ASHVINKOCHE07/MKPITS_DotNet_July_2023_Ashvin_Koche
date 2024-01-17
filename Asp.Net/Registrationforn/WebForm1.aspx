<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registrationforn.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 100%;
            border-collapse: collapse;
            height: 475px;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style4 {
            width: 275px;
        }
        .auto-style5 {
            width: 275px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong><span class="auto-style1">REGISTRATION FORM</span></strong></div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style5">1.Username</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">2.Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">3.Address</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="73px" TextMode="MultiLine" Width="388px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">4.Gender</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Other" GroupName="gender" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">5.Hobby</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Music" />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Reading" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">6.Country</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="150px">
                        <asp:ListItem>Select </asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">7.City</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Width="150px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">8.Courses</td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Width="147px">
                        <asp:ListItem>DotNet</asp:ListItem>
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>PHP</asp:ListItem>
                        <asp:ListItem>Oracle</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">9.Center</td>
                <td class="auto-style6">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Height="16px">
                        <asp:ListItem>Sadar</asp:ListItem>
                        <asp:ListItem>Civil Lines</asp:ListItem>
                        <asp:ListItem>Ramdaspeth</asp:ListItem>
                        <asp:ListItem>Medical Square</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" Width="140px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
