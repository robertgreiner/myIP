<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="myIP.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My IP Address</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="ClientIP" runat="server" Text="IP Address Unknown"></asp:Label>
    </div>
    </form>
</body>
</html>
