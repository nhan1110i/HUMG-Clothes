<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageColor.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Products.ShowColor.ShowColor" %>
<%@ Register Assembly="Karpach.WebControls" Namespace="Karpach.WebControls" TagPrefix="cc1" %>

<link href="../../../Plugin/ColorPicker/colorpicker.css" rel="stylesheet" />
<script src="../../../Plugin/ColorPicker/colorpicker.js"></script>
<div class="container-fluid">
    <div class="row">
    <div class="col-lg-8">
        <div class="panel panel-info">
            <div class="panel-heading text-center">
                <h5><strong>QUẢN LÝ MÀU SẢN PHẨM</strong></h5>
            </div>
            <div class="panel-body">
                <div class="table-reponsive">
                    <asp:Repeater ID="rptColorList" runat="server" OnItemCommand="rptColorList_ItemCommand1">
                        <HeaderTemplate>
                            <table class="table table-hover">
                                <tr class="bg-primary">
                                    <th>#</th>
                                    <th>Tên Màu</th>
                                    <th>Màu</th>
                                    <th>Sửa</th>
                                    <th>Xóa</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><% =x++  %></td>
                                <td><%#: Eval("ColorName") %></td>
                                <td>
                                    <div style='<%# "background-color:" + Eval("ColorCode") +";" %>' class="ColorBox"></div>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbtnEditColor" CommandName="editColor" CommandArgument='<%#: Eval("ColorID") %>' runat="server"><span class="glyphicon glyphicon-edit"></span></asp:LinkButton></td>
                                <td>
                                    <asp:LinkButton ID="lbtnDeleteColor" CommandName="deleteColor" CommandArgument='<%#: Eval("ColorID") %>' runat="server"><span class="glyphicon glyphicon-remove"></span></asp:LinkButton></td>
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

    </div>
    <div class="col-lg-4">

        <div class="panel panel-success">
            <div class="panel-heading text-center">
                <h5><strong>THÊM MỚI MÀU SẢN PHẨM</strong></h5>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>Tên Màu</label>
                    <asp:TextBox ID="txtColorName" runat="server" CssClass="form-control"></asp:TextBox>
                    <label>Mã Màu</label>
                    <asp:TextBox ID="txtColorCode" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    <br />
                    <label>Màu</label>
                    <cc1:ColorPicker ID="clColor" runat="server" CssClass="form-control" BorderStyle="Solid" BorderWidth="2px" OnColorChanged="clColor_ColorChanged" />
                    <br />
                    <asp:Button ID="btnAdd" CssClass="btn btn-block btn-success" runat="server" Text="THÊM MỚI MÀU SẢN PHẨM" Font-Bold="True" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
         <div class="panel panel-warning">
            <div class="panel-heading text-center">
                <h5><strong>CHỈNH SỬA MÀU SẢN PHẨM</strong></h5>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>Tên Màu</label>
                    <asp:TextBox ID="txtColorNameEdit" runat="server" CssClass="form-control"></asp:TextBox>
                    <label>ID Màu</label>
                    <asp:TextBox ID="txtColorEditID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                    <br />
                    <label>Màu</label>
                    <cc1:ColorPicker ID="clColorEdit" runat="server" BorderStyle="Solid" BorderWidth="2px" OnColorChanged="clColor_ColorChanged" />
                    <br />
                    <asp:Button ID="btnEditColor" CssClass="btn btn-block btn-warning" runat="server" Text="CHỈNH SỬA MÀU SẢN PHẨM" Font-Bold="True" OnClick="btnEditColor_Click" />
                </div>
            </div>
        </div>

    </div>
</div>
</div>
