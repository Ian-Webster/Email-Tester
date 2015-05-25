<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailTest.aspx.cs" Inherits="EmailTest.AspNet.EmailTest" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="form-horizontal">
        <h4>Email Test</h4>
        <hr />        

        <div class="form-group">
            Email To
            <div class="col-md-10">
                <asp:TextBox ID="txtEmailTo" runat="server" />
            </div>
        </div>

        <div class="form-group">
            Email Fromt
            <div class="col-md-10">
                <asp:TextBox ID="txtEmailFrom" runat="server" />
            </div>
        </div>

        <div class="form-group">
            Email Subject
            <div class="col-md-10">
                <asp:TextBox ID="txtEmailSubject" runat="server" />
            </div>
        </div>

        <div class="form-group">
            Email Body
            <div class="col-md-10">
                <asp:TextBox ID="txtEmailBody" runat="server" />
            </div>
        </div>

        <div class="form-group">
            Email Html Body
            <div class="col-md-10">
                <asp:TextBox ID="txtEmailHtmlBody" runat="server" />
            </div>
        </div>

        <div class="form-group">
            SMTP Server
            <div class="col-md-10">
                <asp:TextBox ID="txtSMTPServer" runat="server" />
            </div>
        </div>

        <div class="form-group">
            STMP Port
            <div class="col-md-10">
                <asp:TextBox ID="txtSMTPPort" runat="server" />
            </div>
        </div>

        <div class="form-group">
            SMTP User
            <div class="col-md-10">
                <asp:TextBox ID="txtSMTPUser" runat="server" />
            </div>
        </div>

        <div class="form-group">
            SMTP Password
            <div class="col-md-10">
                <asp:TextBox ID="txtSMTPPassword" runat="server" />
            </div>
        </div>

        <div class="form-group">
            User SSL
            <div class="col-md-10">
                <asp:CheckBox ID="chkUseSSL" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnSubmit" runat="server" Text="Send Email" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>    
    </div>
    </form>
</body>
</html>
