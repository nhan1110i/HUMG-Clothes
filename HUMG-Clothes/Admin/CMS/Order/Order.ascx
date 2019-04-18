<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Order.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Order.Order" %>
<link href="../../../../Boostrap/bootstrap.css" rel="stylesheet" />
<div class="container-fluid">
    <div class="panel panel-success">
        <div class="panel-heading">
            <h5><strong>QUẢN LÝ ĐƠN HÀNG</strong></h5>
        </div>
        <div class="panel-body">
            <div class="row container">
                <div class="form-inline">
                    <asp:DropDownList ID="drpRecord" runat="server" CssClass="form-control">
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="drpFilterOrder" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpFilterOrder_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    &nbsp;
                    <asp:LinkButton ID="lbtnFilterOrder" runat="server" CssClass="btn btn-success"><span class="glyphicon glyphicon-flag"></span> Lọc đơn hàng</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-warning"><span class="glyphicon glyphicon-download"></span> Xuất File</asp:LinkButton>
                </div>
                <hr />
            </div>
            <table class="table table-responsive">
                <asp:Repeater ID="rptOrder" runat="server" OnItemCommand="rptOrder_ItemCommand">
                    <HeaderTemplate>

                        <tr class="bg-info">
                            <th>STT</th>
                            <th>Mã đơn</th>
                            <th>Khách hàng</th>
                            <th>Ngày giờ đặt</th>
                            <th>Số lượng</th>
                            <th>Tổng tiền</th>
                            <th>Thanh toán</th>
                            <th>Mã giảm giá</th>
                            <th>Trạng thái</th>
                            <th>&nbsp;&nbsp;&nbsp;Thao tác</th>
                        </tr>

                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <% = od++ %>
                            </td>
                            <td>DH<%#: Eval("OrderID") %></td>
                            <td>
                                <%#: Eval("CustomerName") %>
                            </td>
                            <td>
                                <%#: Eval("OrderDate") %>
                            </td>
                            <td>
                                <%#: Eval("TotalQuantity") %>
                            </td>
                            <td>
                                <%#: Eval("TotalMoney") %>
                            </td>
                            <td>
                                <%#: Eval("PaymentName") %>
                            </td>
                            <td><%#: Eval("DiscountCode") %></td>
                            <td>
                                <%#: Eval("OrderStatus") %>
                            </td>
                            <td class="text-center">
                                <asp:LinkButton ID="lbtnShowOrder" runat="server" CssClass="btn btn-primary" CommandName="ViewOrderDetail" CommandArgument='<%#: Eval("OrderID") %>'><span class="glyphicon glyphicon-search"></span></asp:LinkButton>
                                <asp:LinkButton ID="lbtnSent" runat="server" CssClass="btn btn-success" CommandName="Sent" CommandArgument='<%#: Eval("OrderID") %>'><span class="glyphicon glyphicon-send"></span></asp:LinkButton>
                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning" CommandName="Deline" CommandArgument='<%#: Eval("OrderID") %>'><span class="glyphicon glyphicon-remove-circle" ></span></asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
        </div>
    </div>
</div>
<asp:Label ID="lblTest" runat="server" Text="Label"></asp:Label>