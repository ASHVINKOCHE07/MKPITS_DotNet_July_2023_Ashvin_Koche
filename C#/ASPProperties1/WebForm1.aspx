<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPProperties1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            text-decoration: underline;
        }
        .newStyle1 {
            font-family: "Arial Black";
        }
        .auto-style2 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#FFCC99" Height="328px" Width="1044px">
                <div class="auto-style1">
                    <strong class="newStyle1"><em>panel1</em></strong></div>
            </asp:Panel>
        </div>
        <asp:Button ID="Button1" runat="server" Height="69px" OnClick="Button1_Click" Text="Hide" Width="524px" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" Height="69px" OnClick="Button2_Click" Text="Show" Width="524px" />
    </form>
</body>
</html>
