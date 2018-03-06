<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Forms.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <style>
        body{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Admin" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Data List" />
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />
    
    </div>
    </form>
</body>
</html>
