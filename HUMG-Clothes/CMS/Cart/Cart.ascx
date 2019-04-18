<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cart.ascx.cs" Inherits="HUMG_Clothes.CMS.Cart.Cart" %>
<link href="../../CSSJS/Cart.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<div class="container">
    <div class="row">
        <div class="col-lg-12">
            <div class="table-responsive giohang__table ff">
                <table class="table table-bordered">
                    <thead>
                        <tr>
                            <td>Sản phẩm</td>
                            <td>Đơn giá</td>
                            <td>Số lượng</td>
                            <td>Thành tiền</td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptCart" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><a href="#" class="giohang__table--link">
                                        <img src='<%#: "Admin/IMG/ProductImage/"+Eval("Img") %>' class="giohang__table--img"><%#: Eval("ProductName") %></a></td>
                                    <td><b><%#: Eval("ProductPrice") %> VNĐ</b></td>
                                    <td>
                                        <input type="number" value='<%#: Eval("ProductQuantity") %>' min="1" max="50"></td>
                                    <td><b><%#: Eval("FormatMoney") %> VNĐ</b></td>
                                    <td>
                                        <asp:LinkButton ID="lbtnDelete" runat="server" CssClass="giohang__table--del-btn"><span class="glyphicon glyphicon-trash"></span> Xoá sản phẩm</asp:LinkButton>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="lbl" runat="server" CssClass="text-danger text-center" Text="Giỏ hàng của bạn hiện đang trống" Visible="False"></asp:Label> </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>Khối lượng: 0g</td>
                            <td></td>
                            <td>Tổng cộng:
                                <asp:Label ID="lblTotalMoney" runat="server" Text=""></asp:Label> đ</td>
                            <td></td>
                        </tr>
                    </tfoot>
                </table>
            </div>
            <div class="giohang__btn">
                <asp:Button ID="Button1" runat="server" Text="Mua sản phẩm khác" CssClass="giohang__btn--buyanother-btn" OnClick="Button1_Click" />
                <asp:Button ID="btnCheckout" runat="server" Text="Tiến hành thanh toán" CssClass="giohang__btn--checkout-btn" OnClick="btnCheckout_Click" />
            </div>
        </div>
    </div>
</div>
