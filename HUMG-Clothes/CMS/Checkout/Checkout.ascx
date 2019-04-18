<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Checkout.ascx.cs" Inherits="HUMG_Clothes.CMS.Pay.Pay" %>
<link href="../../CSSJS/Checkout.css" rel="stylesheet" />
<hr />
<div class="container ff checkout">
    <hr>
    <p class="checkout__title fw-700">Thanh toán trực tuyến an toàn</p>
    <hr>
    <div class="row">

        <!--Thông tin khách hàng-->
        <div class="col-md-3 checkout__info">
            <p class="fs-18 fw-700">1. THÔNG TIN KHÁCH HÀNG</p>
            <label>Họ và tên: *</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="checkout__input--name"></asp:TextBox>
            <label>Điện thoại: *</label>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="checkout__input--telephone"></asp:TextBox>
            <label>Email: *</label>
            <asp:TextBox ID="txtMail" runat="server" CssClass="checkout_input--email"></asp:TextBox>
            <label>Tỉnh/Thành phố: *</label>
            <asp:DropDownList ID="drpCity" runat="server" CssClass="checkout__input--city" AutoPostBack="True" OnSelectedIndexChanged="drpCity_SelectedIndexChanged1"></asp:DropDownList>
            <label>Quận/ Huyện: *</label>
            <asp:DropDownList ID="drpTown" runat="server" CssClass="checkout__input--district"></asp:DropDownList>
            <label>Địa chỉ: *</label>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="checkout__input--address" TextMode="MultiLine"></asp:TextBox>
        </div>
        <!--Hình thức thanh toán-->
        <div class="col-md-3 checkout__payment-method">
            <p class="fs-18 fw-700">2. HÌNH THỨC THANH TOÁN</p>
            <asp:RadioButtonList ID="rblPayment" runat="server">
            </asp:RadioButtonList>
        </div>

        <!--Xác nhận đơn hàng-->
        <div class="col-md-3 checkout__confirm">
            <p class="fs-18 fw-700">3. XÁC NHẬN ĐƠN HÀNG</p>
            <asp:Repeater ID="rptCheckOut" runat="server">
                <ItemTemplate>
                    <img src='<%#: "Admin/IMG/ProductImage/"+Eval("Img") %>' class="checkout__confirm--img">
                    <p class="checkout__confirm--img--name fw-700"><%#: Eval("ProductName") %></p>
                    <p class="checkout__confirm--price fw-700 fs-16"><%#: Eval("ProductPrice") %> VNĐ</p>
                    <p class="fs-16">Số lượng: <%#: Eval("ProductQuantity") %></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <!--Xác nhận thanh toán-->
        <div class="col-md-3 checkout__price">
            <p class="fs-18 fw-700">4. XÁC NHẬN THANH TOÁN</p>
            <p class="fs-16">
                Tiền hàng <span class="checkout__price--price"><b>
                    <asp:Label ID="lblTotalMoney" runat="server" Text="Label"></asp:Label>
                    đ</b></span>
            </p>
            <p class="fs-16">Phí vận chuyển <span class="checkout__price--price"><b>0 đ</b></span></p>
            <hr>
            <p class="fs-16">
                Tổng cộng <span class="checkout__price--total-price"><b>
                    <asp:Label ID="lblTotalMoney2" runat="server" Text="Label"></asp:Label>
                    đ</b></span>
            </p>
            <br>
            <label class="fs-16">Sử dụng mã giảm giá nếu có</label>
            <input type="text" name="discount" placeholder="Mã giảm giá" class="checkout__price--discount">
            <button class="checkout__price--btn fs-16">Sử dụng</button>
            <br>
            <label class="fs-16">Ghi chú</label>
            <textarea placeholder="Ghi chú" class="checkout__price--input-note"></textarea>
            <asp:Button ID="btnConfirm" runat="server" Text="Xác nhận đơn hàng" CssClass="checkout__price--confirm-btn fs-16" OnClick="btnConfirm_Click" />
        </div>
    </div>
</div>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>