<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="primenumberprint.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    .auto-style1 {
        text-align: center;
        font-size: large;
    }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="auto-style1">
            <strong>Prime Number 1 to 20</strong></div>
        <p class="auto-style2">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press me" />
        </p>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
