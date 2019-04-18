<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewUpdateProduct.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Products.AddNewProduct.AddNewProduct" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

<div class="container-fluid">
    <div class="panel panel-info">
        <div class="panel-heading text-center">
            <h5><strong>THÊM SẢN PHẨM MỚI</strong></h5>
        </div>
        <div class="panel-body">
            <form method="post">
                <div class="form-group">
                    <label for="ProductName">Tên Sản Phẩm: </label>
                    <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtPrice">Giá Sản Phẩm: </label>
                    <asp:TextBox ID="txtProductPrice" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="">Upload Ảnh:  </label>
                    <asp:ScriptManager ID="s" runat="server"></asp:ScriptManager>
                    <ajaxToolkit:AjaxFileUpload ID="AfulListImage" runat="server" AllowedFileTypes="jpg,png,jpeg,gif" MaximumNumberOfFiles="100" OnUploadComplete="AfulListImage_UploadComplete" OnUploadCompleteAll="AfulListImage_UploadCompleteAll" />
                </div>
                <div>
                    <asp:LinkButton ID="lbtnShowImage" runat="server" CssClass="btn btn-success" OnClick="lbtnShowImage_Click"><span class="glyphicon glyphicon-eye-open"></span><span> Xem ảnh</span></asp:LinkButton>
                    &nbsp;&nbsp;<asp:LinkButton ID="lbtnDeleteImage" runat="server" CssClass="btn btn-danger" OnClick="lbtnDeleteImage_Click"><span class="glyphicon glyphicon-remove-sign"></span><span> Xóa ảnh</span></asp:LinkButton>
                </div>
                <br />
                <div class="container-fluid">
                    <asp:Table ID="tblShowImage" CssClass="table table-responsive" runat="server">
                    </asp:Table>
                </div>
                <br />
                <div class="form-group">
                    <label for="ckeDecription">Mô tả: </label>
                    <CKEditor:CKEditorControl ID="ckeDecription" runat="server" CssClass="form-control-feedback"></CKEditor:CKEditorControl>
                </div>
                <div class="form-group">
                    <label for="drpCategory">Chọn Danh Mục: </label>
                    <asp:DropDownList ID="drpCategory" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="form-inline">
                    <label for="rblSex">Giới tính: </label>
                    <asp:RadioButtonList ID="rblSex" runat="server" CssClass="radio" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0" Selected="True">Nam &nbsp;</asp:ListItem>
                        <asp:ListItem Value="1">Nữ</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;<label for="drpColor">Chọn Màu: </label>
                    <asp:DropDownList ID="drpColor" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                    &nbsp;<label for="drpSize">Chọn Size: </label>
                    <asp:DropDownList ID="drpSize" runat="server" CssClass="form-control"></asp:DropDownList>
                    <br />
                    <label class="switch">
                        <asp:CheckBox ID="cbShow" runat="server" />
                        <span class="slider round"></span>

                    </label>
                    <span><strong class="text-primary">Hiển thị sản phẩm </strong></span>
                </div>
                <br />
                <asp:CheckBox ID="cbContinue" runat="server" Text=" Tiếp tục thêm sản phẩm khác" />
                <br />
                <br />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" CssClass="btn btn-primary" OnClick="btnThem_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Hủy" CssClass="btn btn-danger" />
                <br />
                <asp:Label ID="lblNotice" runat="server" ForeColor="Red"></asp:Label>
            </form>
        </div>
    </div>
</div>
