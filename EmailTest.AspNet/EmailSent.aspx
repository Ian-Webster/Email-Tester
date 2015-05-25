<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailSent.aspx.cs" Inherits="EmailTest.AspNet.EmailSent" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Email Sent</h1>
        <asp:Button ID="btnSendAnother" runat="server" Text="Send Another" OnClick="btnSendAnother_Click" />
    </div>
    </form>
</body>
</html>
