<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderDetail.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.OrderDetail.OrderDetail" %>
<link href="../../../Boostrap/bootstrap.css" rel="stylesheet" />
<div class="container-fluid row">
    <div class="col-lg-6">
        <div class="panel panel-success">
            <div class="panel-heading">
                <h5><strong>CHI TIẾT ĐƠN HÀNG</strong></h5>
            </div>
            <div class="panel-body">
                <asp:LinkButton ID="lbtnPrintBill" runat="server" CssClass="btn btn-success"><span class="glyphicon glyphicon-print"></span> In đơn hàng</asp:LinkButton>
                <br />
                <h5 class="text-success"><strong>
                    <asp:Label ID="lblOrderID" runat="server" Text="Label"></asp:Label></strong></h5>
                <hr />
                <table class="table table-responsive">
                    <asp:Repeater ID="rptOrderDetail" runat="server">
                        <HeaderTemplate>
                            <tr class="bg-primary">
                                <th>STT</th>
                                <th>Mã sản phẩm</th>
                                <th>Tên sản phẩm</th>
                                <th>Đơn giá</th>
                                <th>Số lượng</th>
                                <th>Thành tiền</th>
                            </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><% =od++ %></td>
                                <td><%#: Eval("ProductID") %></td>
                                <td><%#: Eval("ProductName") %></td>
                                <td><%#: Eval("ProductPrice") %></td>
                                <td><%#: Eval("Quantity") %></td>
                                <td><%#: Eval("ProductTotalMoney") %></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>
                    </asp:Repeater>
                    <tr>
                        <td colspan="4" class="text-center"><strong>Tổng:</strong></td>
                        <td>
                            <strong>
                                <asp:Label ID="lblTotalQuantity" runat="server" Text="Label"></asp:Label></strong></td>
                        <td>
                            <strong>
                                <asp:Label ID="lblTotalMoney" runat="server" Text="Label"></asp:Label></strong>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="col-lg-6">
        <div class="panel panel-warning">
            <div class="panel-heading">
                <h5><strong>THÔNG TIN KHÁCH HÀNG</strong></h5>
            </div>
            <div class="panel-body">
                <asp:LinkButton ID="lbtnPrintCustomer" runat="server" CssClass="btn btn-warning"><span class="glyphicon glyphicon-print"></span> In thông tin khách hàng</asp:LinkButton>
                <br />
                <h5 class="text-success"><strong>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></strong></h5>
                <hr />
                <table class="table table-responsive">
                    <tr>
                        <td>Họ tên:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lblTen" runat="server" Text="Label"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td>Số điện thoại:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td>Mail:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lblMail" runat="server" Text="Label"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td>Địa chỉ:
                        </td>
                        <td>
                            <strong>
                                <asp:Label ID="lblAdd" runat="server" Text="Label"></asp:Label>
                            </strong>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
