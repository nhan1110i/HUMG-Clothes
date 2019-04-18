<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Male.ascx.cs" Inherits="HUMG_Clothes.CMS.Male.Male" %>
<hr />
<div class="container">
    <div class="row">
        <div class="col-lg-3 nu__category ff">
            <p class="nu__category--title">DANH MỤC</p>
            <div class="nu__category--list">
                <ul>
                    <li>
                        <a href="#">ÁO</a>
                        <ul>
                            <li><a href="?page=MaleClothes&Category=4">Áo sát nách</a></li>
                            <li><a href="?page=MmaleClothes&Category=5">Áo thun</a></li>
                            <li><a href="?page=MaleClothes&Category=7">Áo dài tay - Hoodies</a></li>
                            <li><a href="?page=MaleClothes&Category=8">Sơ mi</a></li>
                            <li><a href="?page=MaleClothes&Category=9">Áo len</a></li>
                            <li><a href="?page=MaleClothes&Category=10">Áo khoác</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="#">QUẦN</a>
                        <ul>
                            <li><a href="#">Quần váy</a></li>
                            <li><a href="?page=MaleClothes&Category=11">Quần shorts</a></li>
                            <li><a href="?page=MaleClothes&Category=15">Quần dài</a></li>
                            <li><a href="?page=MaleClothes&Category=13">Jogger</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <div class="col-lg-9 nu__listproduct ff">
            <p style="display: inline-block">Sắp xếp theo</p>
            <span>
                <select>
                    <option>Bỏ lọc</option>
                    <option>Giá tăng dần</option>
                    <option>Giá giảm dần</option>
                    <option>Sale</option>
                </select>
            </span>
            <div class="row">
                <asp:Repeater ID="rptMale" runat="server" OnItemCommand="rptFemale_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-4 nu__listproduct--product">
                            <div class="card">
                                <a href='?page=ProductDetail&Product=<%#: Eval("ProductID") %>'>
                                    <img src='<%#: "Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' class="nu__listproduct--image"></a>
                                <p class="mb-0 mt-10"><a href="#" class="nu__listproduct--name"><%#: Eval("ProductName") %></a></p>
                                <p class="nu__listproduct--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ </p>
                                <asp:LinkButton ID="lbtnAddtoCart" runat="server" CommandName="AddtoCart" CommandArgument='<%#: Eval("ProductID") %>'><i class="icon ion-md-cart nu__listproduct--cart-icon"></i></asp:LinkButton>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>