<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HUMG_Clothes.Admin.Default" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../Boostrap/bootstrap.css" rel="stylesheet" />
    <link href="CSS/AdminCSS.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <script src="../Boostrap/jquery.min.js"></script>
    <script src="../Boostrap/bootstrap.min.js"></script>
    <script src="Plugin/ckeditor/ckeditor.js"></script>
    <script src="CSS/JS.js"></script>
    <%--font --%>
    <link href="https://fonts.googleapis.com/css?family=Merriweather:400,700&amp;subset=vietnamese" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Yanone+Kaffeesatz:700&amp;subset=vietnamese" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,600&amp;subset=vietnamese" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Muli&amp;subset=vietnamese" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <%--navbar admin--%>
        <div>
            <div id="mySidenav" class="sidenav">
                <a href="javascript:void(0)" class="closebtn" onclick="closeNav()"><span class="glyphicon glyphicon-arrow-left"></span></a>
                <div class="admin-info">
                    <img src="IMG/AdminImage/avatarAdmin.jpg" class="img-circle" />
                    <div class="admin-text">
                        <span><strong>Login : ADMIN</strong></span>
                        <br />
                        <a href="#"><span class="glyphicon glyphicon-log-out"></span><strong></strong> Đăng xuất</a>
                        <br />
                        <a href="#"><span class="glyphicon glyphicon-map-marker"></span> Đổi mật khẩu</a>
                    </div>
                </div>
                <div class="container-fluid">
                    <ul class="nav nav-pills nav-stacked">
                        <li><a href="?page=Order" class="item-sidebar"><span class="glyphicon glyphicon-shopping-cart"></span>&nbsp;Đơn Hàng</a></li>
                        <li><a href="?page=ManageProduct" class="item-sidebar"><span class="glyphicon glyphicon-align-justify"></span>&nbsp;Danh mục Sản Phẩm</a></li>
                        <li><a href="?page=AddNewProduct" class="item-sidebar"><span class="glyphicon glyphicon-plus"></span>&nbsp;Thêm sản phẩm</a></li>
                        <li><a href="?page=ManageCategory" class="item-sidebar"><span class="glyphicon glyphicon-tags"></span>&nbsp;Quản lý danh mục</a></li>
                        <li><a href="?page=ManageColor" class="item-sidebar"><span class="glyphicon glyphicon-leaf"></span>&nbsp;Quản lý màu</a></li>
                        <li><a href="?page=ManageSize" class="item-sidebar"><span class="glyphicon glyphicon-resize-full"></span>&nbsp;Quản lý Size</a></li>
                        <li><a href="?page=Member" class="item-sidebar"><span class="glyphicon glyphicon-user"></span>&nbsp;Thành viên</a></li>
                        <li><a href="?page=Member" class="item-sidebar"><span class="glyphicon glyphicon-record"></span>&nbsp;Nhân viên</a></li>
                        <li><a href="?page=Home" class="item-sidebar"><span class="glyphicon glyphicon-stats"></span>&nbsp;Thống Kê</a></li>
                        <li><a href="?page=Contact" class="item-sidebar"><span class="glyphicon glyphicon-paperclip"></span>&nbsp;Liên hệ</a></li>
                    </ul>
                </div>
            </div>
 
            <div id="main" class="">
                <nav class="navbar navbar-default container-fluid">
                    <div class="container-fluid">
                        <div class="navbar-header">
                            <a class="navbar-brand" href="#"><span onclick="openNav()" class="glyphicon glyphicon-align-justify "></span></a>
                            <a href="#" class="navbar-brand">HUMG Clothes</a>
                        </div>
                        <div class="">
                            <ul class="nav navbar-nav navbar-right">
                                <li><a href="../Home.aspx"><span class="glyphicon glyphicon-home"></span><strong> Shop</strong> </a></li>
                                <li>
                                    <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click"><span class="glyphicon glyphicon-log-out"></span><strong> Thoát</strong></asp:LinkButton></li>
                            </ul>
                        </div>
                    </div>
                </nav>
                <%--content sb admin--%>
                <div class="container-fluid">
                    <asp:PlaceHolder ID="plLoadAdminControl" runat="server"></asp:PlaceHolder>
                </div>
                <%--footer--%>
                <div class="container-fluid">
                    <h5 class="text-center text-primary"><span class="copyleft">&copy;</span> Copyleft by Nhan1110i 10/2018</h5>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
