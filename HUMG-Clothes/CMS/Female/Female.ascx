<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Female.ascx.cs" Inherits="HUMG_Clothes.CMS.Female.Female" %>
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
                            <li><a href="?page=FemaleClothes&Category=4">Áo sát nách</a></li>
                            <li><a href="?page=FemaleClothes&Category=5">Áo thun</a></li>
                            <li><a href="?page=FemaleClothes&Category=7">Áo dài tay - Hoodies</a></li>
                            <li><a href="?page=FemaleClothes&Category=8">Sơ mi</a></li>
                            <li><a href="?page=FemaleClothes&Category=9">Áo len</a></li>
                            <li><a href="?page=FemaleClothes&Category=10">Áo khoác</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="#">QUẦN</a>
                        <ul>
                            <li><a href="#">Quần váy</a></li>
                            <li><a href="?page=FemaleClothes&Category=11">Quần shorts</a></li>
                            <li><a href="?page=FemaleClothes&Category=15">Quần dài</a></li>
                            <li><a href="?page=FemaleClothes&Category=13">Jogger</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="#">VÁY</a>
                        <ul>
                            <li><a href="#">Váy/ Đầm</a></li>
                            <li><a href="#">Chân váy</a></li>
                        </ul>
                    </li>
                    <li><a href="#">DENIM</a>
                    </li>
                </ul>
            </div>
            <br />
            <p class="nu__category--title">MÀU SẮC</p>
            <div>
                <asp:Repeater ID="rptColor" runat="server">
                    <ItemTemplate>
                        <a href='?page=FemaleClothes&Color=<%#: Eval("ColorID") %>' title='<%#: Eval("ColorName") %>' class="nu__color--list" style='<%# "background-color:" + Eval("ColorCode") +";" %>'></a>
                    </ItemTemplate>
                </asp:Repeater>
                
            </div>
        </div>
        <div class="col-lg-9 nu__listproduct ff">
            <p style="display: inline-block">Sắp xếp theo</p>
            <span>
                <asp:DropDownList ID="drpPrice" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpPrice_SelectedIndexChanged">
                    <asp:ListItem Value="0">Bỏ lọc</asp:ListItem>
                    <asp:ListItem Value="1">Tăng dần</asp:ListItem>
                    <asp:ListItem Value="2">Giảm dần</asp:ListItem>
                </asp:DropDownList>
            </span>
            <div class="row">
                <asp:Repeater ID="rptFemale" runat="server" OnItemCommand="rptFemale_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-4 nu__listproduct--product">
                            <div class="card">
                                <a href='?page=ProductDetail&Product=<%#: Eval("ProductID") %>'>
                                    <img src='<%#: "Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' class="nu__listproduct--image"></a>
                                <p class="mb-0 mt-10"><a href="#" class="nu__listproduct--name"><%#: Eval("ProductName") %></a></p>
                                <p class="nu__listproduct--price"><%#: Eval("ProductPriceFormatMoney") %> VNĐ </p>
                                <asp:LinkButton ID="lbtnAddtoCart" runat="server" CommandName="AddtoCart" CommandArgument='<%#: Eval("ProductID") %>'><i class="icon ion-md-cart nu__listproduct--cart-icon"></i></asp:LinkButton>
                                
<%--                                <span><a href="#"><i class="icon ion-md-cart nu__listproduct--cart-icon"></i></a></span>--%>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>


