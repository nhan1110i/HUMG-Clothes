<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HUMG_Clothes.Admin.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Admin</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link href="CSS/AdminCSS.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="form-login center-block fa-border">
                <div class="container-fluid">
                    <br />
                    <div class="container-fluid">
                        
                        <img src="IMG/AdminImage/AvaLogin.jpg" class="img-circle img-responsive center-block ava-login" />
                    </div>
                    <div class="form-group">
                        <label>Account :</label>
                        <asp:TextBox runat="server" ID="txtAccount" CssClass="form-control" Height="36px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAccount" ErrorMessage="Tên đăng nhập không được trống" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <br />
                        <label>Password :</label>
                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mật khẩu không được trống" ForeColor="Red" ControlToValidate="txtPassword">*</asp:RequiredFieldValidator>
                        <asp:Label runat="server" ID="lblWrongPass" CssClass="text-danger"></asp:Label>
                    </div>
                    <asp:Button runat="server" ID="btnLogin" CssClass="btn-block btn btn-primary" Text="Login" OnClick="btnLogin_Click" />
                    <span class="text-danger">Forgot Password ?</span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
