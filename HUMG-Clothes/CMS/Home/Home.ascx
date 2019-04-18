<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Home.ascx.cs" Inherits="HUMG_Clothes.CMS.Home.Home" %>
    <!--Slide ảnh-->
    <div id="myCarousel" class="carousel slide index__slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
            <li data-target="#myCarousel" data-slide-to="3"></li>
        </ol>
        <div class="carousel-inner index__slide">
            <div class="item active">
                <img src="HomeImage/slide1.png">
            </div>
            <div class="item">
                <img src="HomeImage/slide2.png">
            </div>
            <div class="item">
                <img src="HomeImage/slide3.png">
            </div>
            <div class="item">
                <img src="HomeImage/slide4.png">
            </div>
        </div>
    </div>
    
    <!--Danh sách hàng mới-->
    <div class="container index__main-product ff">
        <hr>
        <p class="index__main-product--title">HÀNG MỚI</p>
        <hr>
        <div class="row">
            <asp:Repeater ID="rptNewProductList" runat="server" OnItemCommand="rptNewProductList_ItemCommand">
                <ItemTemplate>
                    <div class="col-lg-3 col-md-4 col-sm-6 index__main-product--item">
                        <div class="card">
                            <a href='?page=ProductDetail&Product=<%#: Eval("ProductID") %>'>
                            <img src='<%#: "Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' style="width: 255px"></a>
                            <p class="mb-0 mt-10"><a href="#" class="index__main-product--name"><%#: Eval("ProductName") %></a></p>
                            <p class="index__main-product--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ <span class="index__main-product--price-sale"><%#: Eval("PriceFake") %> VNĐ</span></p>
                            <span>
                                <asp:LinkButton ID="lbtnAddtoCart" runat="server" CommandName="AddtoCart" CommandArgument='<%#: Eval("ProductID") %>'><span class="icon ion-md-cart index__main-product--cart-icon"></span></asp:LinkButton></span>
                            <%--<span><a href="#"><i class="icon ion-md-cart index__main-product--cart-icon"></i></a></span>--%>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="container index__main-product ff">
        <hr>
        <p class="index__main-product--title">QUẦN ÁO NAM</p>
        <hr>
        <div class="row">
            <asp:Repeater ID="rptMaleProductList" runat="server" OnItemCommand="rptMaleProductList_ItemCommand">
                <ItemTemplate>
                    <div class="col-lg-3 col-md-4 col-sm-6 index__main-product--item">
                        <div class="card">
                            <a href='?page=ProductDetail&Product=<%#: Eval("ProductID") %>'>
                            <img src='<%#: "Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' style="width: 255px"></a>
                            <p class="mb-0 mt-10"><a href="#" class="index__main-product--name"><%#: Eval("ProductName") %></a></p>
                            <p class="index__main-product--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ <span class="index__main-product--price-sale">310,000 VNĐ</span></p>
                            <span><asp:LinkButton ID="lbtnAddtoCart1" runat="server" CommandName="AddtoCart" CommandArgument='<%#: Eval("ProductID") %>'><span class="icon ion-md-cart index__main-product--cart-icon"></span></asp:LinkButton></span>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="container index__main-product ff">
        <hr>
        <p class="index__main-product--title">QUẦN ÁO NỮ</p>
        <hr>
        <div class="row">
            <asp:Repeater ID="rptFemaleProductList" runat="server" OnItemCommand="rptFemaleProductList_ItemCommand">
                <ItemTemplate>
                    <div class="col-lg-3 col-md-4 col-sm-6 index__main-product--item">
                        <div class="card">
                            <a href='?page=ProductDetail&Product=<%#: Eval("ProductID") %>'>
                            <img src='<%#: "Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' style="width: 255px"></a>
                            <p class="mb-0 mt-10"><a href="#" class="index__main-product--name"><%#: Eval("ProductName") %></a></p>
                            <p class="index__main-product--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ <span class="index__main-product--price-sale">310,000 VNĐ</span></p>
                            <span><asp:LinkButton ID="lbtnAddtoCart2" runat="server" CommandName="AddtoCart" CommandArgument='<%#: Eval("ProductID") %>'><span class="icon ion-md-cart index__main-product--cart-icon"></span></asp:LinkButton></span>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!-- Category Male Female-->
    <div class="container index__main-product ff">
        <hr>
        <div class="row">
            <div class="col-lg-6 containerr">
                <img src="HomeImage/Menu-Female.jpg" class="imgg" />
                <div class="overlayy">
                    <div class="text">HƯỚNG DẪN MUA HÀNG</div>
                </div>
            </div>
            <div class="col-lg-6 containerr">
                <img src="HomeImage/Menu-Male.jpg" class="imgg" />
                <div class="overlayy">
                    <div class="text">HƯỚNG DẪN MUA HÀNG</div>
                </div>
            </div>
        </div>
    </div>