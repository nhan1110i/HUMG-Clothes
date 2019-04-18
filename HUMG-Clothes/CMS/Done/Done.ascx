<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Done.ascx.cs" Inherits="HUMG_Clothes.CMS.Done.Done" %>
<link href="../../CSSJS/SearchOrder.css" rel="stylesheet" />
<link href="../../CSSJS/Cart.css" rel="stylesheet" />
<hr />
<div class="container">
    <div class="row">
        <div class="col-lg-12">
            <div class="find-order ff">
                <p class="find-order__title">BẠN ĐÃ ĐẶT HÀNG THÀNH CÔNG </3</p>
                <p class="find-order__note"><i>Mã đơn hàng của bạn là: <b>
                    <asp:Label ID="lblOrder" runat="server" Text="Label"></asp:Label></b>  để tra cứu tình trạng đơn hàng của bạn nhé ! ^ ^</i></p>
            </div>
        </div>
    </div>
</div>
