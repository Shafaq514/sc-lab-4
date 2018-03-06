<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Forms.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <style>
        body{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Admin Login"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="height: 26px" />
    <div>
    
    </div>
    </form>
</body>
</html>
