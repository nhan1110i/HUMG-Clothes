<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageCategory.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Products.ShowCategory.ShowCategory" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div class="container-fluid row">
    <div class="col-lg-8">
        <div class="panel panel-info">
            <div class="panel-heading text-center">
                <h5><strong>QUẢN LÝ DANH MỤC SẢN PHẨM</strong></h5>
            </div>
            <div class="panel-body">
                <div class="table-responsive">
                    <asp:Repeater ID="rptCategoryList" runat="server" OnItemCommand="rptCategoryList_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-hover">
                                <tr class="bg-primary">
                                    <th>#</th>
                                    <th>
                                        <asp:CheckBox ID="checkAll" runat="server" /></th>
                                    <th>Tên Danh Mục</th>
                                    <th>Sửa</th>
                                    <th>Xóa</th>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%=x++ %></td>
                                <td>
                                    <asp:CheckBox runat="server"  /></td>
                                <td><%#: Eval("ProductCategoryName") %></td>
                                <td>
                                    <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="editCategory" CommandArgument='<%#: Eval("ProductCategoryID") %>'><i class="glyphicon glyphicon-edit" data-toggle="collapse" data-target="#test"></i></asp:LinkButton></td>
                                <td>
                                    <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="deleteCategory" CommandArgument='<%#: Eval("ProductCategoryID") %>'><i class="glyphicon glyphicon-remove"></i></asp:LinkButton>
                                    <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" ConfirmText="Xóa danh mục sẽ xóa toàn bộ các sản phẩm thuộc danh mục đó. Bạn vẫn muốn xóa?" TargetControlID="lbtnDelete" runat="server" />
                                </td>
                            </tr>

                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
                <br />
            </div>
        </div>

    </div>
    <div class="col-lg-4">
        <div class="panel panel-success">
            <div class="panel-heading text-center">
                <h5><strong>THÊM MỚI DANH MỤC</strong></h5>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>Tên Danh Mục</label>
                    <asp:TextBox ID="txtCategoryName" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnAdd" CssClass="btn btn-block btn-success" runat="server" Text="THÊM MỚI DANH MỤC" OnClick="btnAdd_Click" Font-Bold="True" />
                </div>
            </div>
        </div>
        <div class="panel panel-warning">
            <div class="panel-heading text-center">
                <h5><strong>CHỈNH SỬA DANH MỤC</strong></h5>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>ID Danh Mục</label>
                    <asp:TextBox ID="txtCategoryIDEdit" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    <label>Tên Danh Mục</label>
                    <asp:TextBox ID="txtCategoryNameEdit" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnEditCategory" CssClass="btn btn-block btn-warning" runat="server" Text="CHỈNH SỬA DANH MỤC" OnClick="btnEditCategory_Click" Font-Bold="True" />
                </div>
            </div>
        </div>
        <div class="<% =ClassAlert %>" id="AlertNoticeDefault">
            <strong><% =Action %></strong><% =NoticeAction %>
        </div>
    </div>
</div>
