<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchOrder.ascx.cs" Inherits="HUMG_Clothes.CMS.SearchOrder.SearchOrder" %>
<link href="../../CSSJS/SearchOrder.css" rel="stylesheet" />
<link href="../../CSSJS/Cart.css" rel="stylesheet" />
<hr />
<div class="container">
    <div class="row">
        <div class="col-lg-12">
            <div class="find-order ff">
                <p class="find-order__title">TRA CỨU ĐƠN HÀNG</p>
                <p class="find-order__note"><i>Hãy nhập <b>Số điện thoại</b> hoặc <b>Mã đơn hàng</b> để tra cứu tình trạng đơn hàng của bạn nhé ! ^ ^</i></p>
                <div class="find-order__form">
                    <asp:TextBox ID="txtOrderID" runat="server" CssClass="find-order__form--input"></asp:TextBox>
                    
                    <asp:Button ID="btnSearch" runat="server" Text="KIỂM TRA" CssClass="find-order__form--check-btn" OnClick="btnSearch_Click" />
                </div>

                <div class="find-order__table">
                    <div class="table-responsive">
                        <table class="table table-bordered">
                            <thead>
                                <tr>
                                    <td>Ảnh sản phẩm</td>
                                    <td>Đơn giá</td>
                                    <td>Số lượng</td>
                                    <td>Thành tiền</td>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptSearch" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><a href="#" class="giohang__table--link">
                                                <img src='<%#: "Admin/IMG/ProductImage/"+Eval("Image") %>' class="giohang__table--img"><%#: Eval("ProductName") %></a></td>
                                            <td><%#: Eval("ProductPrice") %> VNĐ</b></td>
                                            <td><%#: Eval("Quantity") %></td>
                                            <td><b><%#: Eval("ProductTotalMoney") %> VNĐ</b></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <tr>
                                    <td colspan="4" class="find-order__table--notfound">
                                        <strong><asp:Label ID="Label1" runat="server" Text="TRẠNG THÁI ĐƠN HÀNG: " Visible="False"></asp:Label></strong>
                                        <span class="text-danger">
                                            <asp:Label ID="lblNotice" runat="server" Text="Không tìm thấy đơn hàng yêu cầu"></asp:Label></span></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
