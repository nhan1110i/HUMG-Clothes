<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowProduct.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Products.ShowProduct.ShowProduct" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<link href="../../../../Boostrap/bootstrap.css" rel="stylesheet" />
<div class="container-fluid">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h5><strong>QUẢN LÝ SẢN PHẨM</strong></h5>
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
            <asp:LinkButton ID="lbtnAddNew" runat="server" CssClass="btn btn-info" OnClick="LinkButton1_Click"><span class="glyphicon glyphicon-plus"></span> Thêm mới</asp:LinkButton>
                    <asp:LinkButton ID="lbtnAopect" runat="server" CssClass="btn btn-success" OnClick="lbtnAopect_Click"><span class="glyphicon glyphicon-check"></span> Áp dụng</asp:LinkButton>
                    <asp:LinkButton ID="lbtnReports" runat="server" CssClass="btn btn-warning" OnClick="lbtnReports_Click"><span class="glyphicon glyphicon-copy"></span> Xuất File</asp:LinkButton>
                    <asp:LinkButton ID="lbtnDeleteSelectProduct" runat="server" CssClass="btn btn-danger right" OnClick="lbtnDeleteSelectProduct_Click"><span class="glyphicon glyphicon-trash"></span> Xóa mục đã chọn</asp:LinkButton>

                </div>
            </div>
            <br />
            <table class="table table-responsive" id="ProductList">
                <tr>
                    <td colspan="2"></td>

                    <td >
                        <asp:TextBox ID="txtSearchProduct" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpCategory" runat="server" CssClass="form-control"></asp:DropDownList>
                    </td>
                    <td></td>
                    <td>
                                                <asp:DropDownList ID="drpSex" runat="server" CssClass="form-control" OnSelectedIndexChanged="drpSex_SelectedIndexChanged">
                            <asp:ListItem Value="3">Tất cả</asp:ListItem>
                            <asp:ListItem Value="0">Nam</asp:ListItem>
                            <asp:ListItem Value="1">Nữ</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>

                    </td>
                    <td>
                        <asp:LinkButton ID="lbtnUnfilter" runat="server" CssClass="btn btn-default" OnClick="lbtnUnfilter_Click"><span class="glyphicon glyphicon-search"></span> Lọc</asp:LinkButton>
                        <asp:LinkButton ID="lbtnFilter" runat="server" CssClass="btn btn-default" OnClick="lbtnFilter_Click"><span class="glyphicon glyphicon-record"></span> Bỏ Lọc</asp:LinkButton>
                    </td>

                    <td></td>
                    <td></td>
                    <td></td>
                    <asp:Repeater ID="rptManageProduct" runat="server" OnItemCommand="rptManageProduct_ItemCommand">
                        <HeaderTemplate>
                            </tr>
                        <tr class="bg-info">
                            <th>#</th>
                            <th>
                                <asp:CheckBox ID="cbCheckAll" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" /></th>
                            <th>Tên</th>
                            <th>Danh Mục</th>
                            <th>Giá bán</th>
                            <th>Giới tính</th>
                            <th>Size</th>
                            <th>Ảnh</th>
                            <th>Màu</th>
                            <th>Active</th>
                            <th>Sửa</th>
                            <th>Xóa</th>
                        </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><% = od++ %></td>
                                <td>
                                    <asp:CheckBox ID="cb" runat="server" CssClass="selectItem" />
                                    <asp:HiddenField ID="hfID" runat="server" Value='<%#: Eval("ProductID") %>' />
                                </td>
                                <td>
                                    <%#: Eval("ProductName") %>
                                </td>
                                <td>
                                    <%#: Eval("CategoryName") %>
                                </td>
                                <td><strong><%#: Eval("ProductPrice") %>.00</strong>
                                </td>
                                <td>
                                    <%#: Eval("Sex") %>
                                </td>
                                <td>
                                    <strong><%#: Eval("SizeName") %></strong>
                                </td>
                                <td>
                                    <asp:Image ID="Image1" CssClass="img-thumbail" runat="server" ImageUrl='<%# "~/Admin/IMG/ProductImage/" + Eval("ImageThumbnail1") %>' />
                                    <asp:Image ID="Image2" CssClass="img-thumbail" runat="server" ImageUrl='<%# "~/Admin/IMG/ProductImage/" + Eval("ImageThumbnail2") %>' />
                                    <asp:Image ID="Image3" CssClass="img-thumbail" runat="server" ImageUrl='<%# "~/Admin/IMG/ProductImage/" + Eval("ImageThumbnail3") %>' />
                                    <asp:Image ID="Image4" CssClass="img-thumbail" runat="server" ImageUrl='<%# "~/Admin/IMG/ProductImage/" + Eval("ImageThumbnail4") %>' />
                                    <asp:Image ID="Image5" CssClass="img-thumbail" runat="server" ImageUrl='<%# "~/Admin/IMG/ProductImage/" + Eval("ImageThumbnail5") %>' />
                                </td>
                                <td>
                                    <div style='<%# "background-color:" + Eval("ColorCode") +";" %>' class="ColorBox"></div>
                                </td>
                                <td>
                                    <label class="switch">
                                        <asp:CheckBox ID="cbActiveProduct" Checked="false" runat="server" />
                                        <span class="slider round"></span>
                                    </label>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="editProduct" CommandArgument='<%#: Eval("ProductID") %>'><i class="glyphicon glyphicon-edit"></i></asp:LinkButton></td>
                                <td>
                                    <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="deleteProduct" CommandArgument='<%#: Eval("ProductID") %>'><i class="glyphicon glyphicon-remove"></i></asp:LinkButton>
                                    <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" TargetControlID="lbtnDelete" ConfirmText="Bạn muốn xóa sản phẩm này? Xóa sẽ không thể khôi phục lại bạn có thể lựa chọn ẩn sản phẩm thay vì xóa." runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                    <asp:Label ID="lblNotice" runat="server" Text="" CssClass="text-center"></asp:Label>
        </div>
    </div>
</div>
</div>
