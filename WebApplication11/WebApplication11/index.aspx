<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication11.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        Username : <asp:TextBox ID="username" runat="server"></asp:TextBox>
        Password : <asp:TextBox ID="pwd11111" runat="server"></asp:TextBox>

    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    
        <asp:Label runat="server" ID="lbl1"></asp:Label>
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" /> 
    </div>
    </form>
</body>
</html>
