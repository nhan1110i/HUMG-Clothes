<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.ascx.cs" Inherits="HUMG_Clothes.CMS.ProductDetail.ProductDetail" %>
<script src="../../CSSJS/ProductDetail.js"></script>
<hr />
<div class="chitietsanpham">
    <div class="row">
        <asp:Repeater ID="rptProduct" runat="server" OnItemCommand="rptProduct_ItemCommand">
            <ItemTemplate>
                <div class="col-lg-4 chitietsanpham__img">
                    <img src='<%# "/Admin/IMG/ProductImage/" + Eval("ImageThumbnail1") %>' style="width: 400px" id="imageThum0">
                    <hr>
                    <div class="chitietsanpham__img--slide-img">
                        <img src='<%# "/Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' class="chitietsanpham__img--slide-small-img" id="imageThum2">
                        <img src='<%# "/Admin/IMG/ProductImage/" + Eval("ImageThumbnail3") %>' class="chitietsanpham__img--slide-small-img" id="imageThum3">
                        <img src='<%# "/Admin/IMG/ProductImage/" + Eval("ImageThumbnail4") %>' class="chitietsanpham__img--slide-small-img" id="imageThum4">
                        <img src='<%# "/Admin/IMG/ProductImage/" + Eval("ImageThumbnail5") %>' class="chitietsanpham__img--slide-small-img" id="imageThum5">
                    </div>
                </div>
                <div class="col-lg-8 chitietsanpham__detail ff">
                    <h3 class="chitietsanpham__detail--name"><%#: Eval("ProductName") %></h3>
                    <hr />
                    <div class="row">
                        <p class="fs-16 fw-500 col-md-2">Mã sản phẩm:</p>
                        <p class="fs-16 fw-500 col-md-10"><%#: Eval("ProductCategoryID") %>.<%#: Eval("ProductSex") %>.<%#: Eval("ProductSizeID") %>.<%#: Eval("ProductColorID") %>.<%#: Eval("ProductID") %></p>
                    </div>
                    <div class="row">
                        <p class="fs-16 fw-500 col-md-2">Màu sắc:</p>
                        <div style='<%# "background-color:" + Eval("ColorCode") +";" %>' class="chitietsanpham__detail--color"></div>
                    </div>
                    <div class="row" style="margin-bottom: 20px">
                        <p class="fs-16 fw-500 col-md-2">Size:</p>
                        <div class="col-md-10" style="margin-top: 5px;">
                            <a href="#" class="chitietsanpham__detail--size"><%#: Eval("SizeName") %></a>
                        </div>
                    </div>
                    <p class="fw-500 chitietsanpham__detail--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ</p>
                    <div class="chitietsanpham__detail--check">
                        <p class="fs-16 fw-500" style="display: inline-block; margin-right: 10px;">Số lượng</p>
                        <span>
                            <input type="number" value="0" min="0" max="50" /></span>
<%--                        <asp:LinkButton ID="lbtnBuyNow" runat="server" CssClass="chitietsanpham__detail--buybtn" CommandName="BuyNow" CommandArgument='<%#: Eval("ProductID") %>'><i class="icon ion-md-cart chitietsanpham__detail--shopicon"></i>MUA NGAY</asp:LinkButton>--%>
                        <asp:Button ID="Button1" runat="server" Text="THÊM VÀO GIỎ" CssClass="chitietsanpham__detail--buybtn" CommandName="BuyNow" CommandArgument='<%#: Eval("ProductID") %>' />
<%--                        <button class="chitietsanpham__detail--buybtn"><i class="icon ion-md-cart chitietsanpham__detail--shopicon"></i>MUA NGAY</button>--%>
                    </div>
                    <hr>
                    <label><i class="icon ion-md-nutrition"></i>Chi tiết sản phẩm</label>
                    <p><%#: Eval("ProductDecription") %>.</p>
                    <p>- Chất liệu: Nỉ cotton</p>
                    <p>- Số đo mẫu: 45kg, 78 - 63 - 89, 168 (cm)</p>
                    <p>- Size mẫu mặc: M</p>
                    <hr>
                    <label><i class="icon ion-md-nutrition"></i> Mua hàng trực tiếp tại cửa hàng</label>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> 113 Thái Hà, Phường Trung Liệt, Quận Đống Đa, Hà Nội <b class="text-success">(Còn hàng)</b></p>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> BS 93 Nguyễn Chí Thanh, Phường Láng Thượng <b class="text-danger">(Hết hàng)</b></p>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> 135 Nguyễn Văn Cù, Phường Ngọc Lâm, Quận Long Biên, Hà Nội <b class="text-success">(Còn hàng)</b></p>
                    <hr>
                    <label><i class="icon ion-md-nutrition"></i> Giao hàng và trả lại hàng</label>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> Đổi hàng trong vòng 24h</p>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> Phí vận chuyển nội thành Hà Nội: 20.000</p>
                    <p class="pd-15"><i class="icon ion-md-paw"></i> Phí vận chuyển ngoại thành/ ngoại tỉnh: 35.000</p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
