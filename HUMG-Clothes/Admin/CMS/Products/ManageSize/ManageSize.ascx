<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageSize.ascx.cs" Inherits="HUMG_Clothes.Admin.CMS.Products.ManageSize.ManageSize" %>
<div class="container-fluid row">
    <div class="col-lg-8">
        <div class="panel panel-info">
            <div class="panel-heading text-center">
                <h5><strong>QUẢN LÝ SIZE SẢN PHẨM</strong></h5>
            </div>
            <div class="panel-body">
                <div class="table-reponsive">
                    <asp:Repeater ID="rptSizeList" runat="server" OnItemCommand="rptSizeList_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-hover">
                                <tr class="bg-primary">
                                    <th>#</th>
                                    <th>Size</th>
                                    <th>Chiều cao (cm)</th>
                                    <th>Cân nặng (kg)</th>
                                    <th>Sửa</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%=x++%></td>
                                <td><%#: Eval("SizeName") %></td>
                                <td><%#: Eval("Height") %> </td>
                                <td><%#: Eval("Weight") %> </td>
                                <td>
                                    <asp:LinkButton ID="lbtnEditSize" runat="server" CommandName="editSize" CommandArgument='<%#: Eval("SizeID") %>'><span class="glyphicon glyphicon-edit"></span></asp:LinkButton></td>
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
                <h5><strong>CHỈNH SỬA SIZE</strong></h5>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label>Tên Size</label>
                    <asp:TextBox ID="txtSizeName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-inline">
                    <label>Chiều cao :</label>
                    <asp:DropDownList ID="drpBeginHeight" runat="server" CssClass="form-control"></asp:DropDownList>&nbsp; <span class="glyphicon glyphicon-arrow-right"></span>
                    &nbsp;<asp:DropDownList ID="drpEndHeight" runat="server" CssClass="form-control"></asp:DropDownList>
                    <br />
                    <br />
                    
                    <label>Cân nặng : </label>
                    <asp:DropDownList ID="drpBeginWeight" runat="server" CssClass="form-control"></asp:DropDownList>&nbsp; <span class="glyphicon glyphicon-arrow-right"></span>
                    &nbsp;<asp:DropDownList ID="drpEndWeight" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <br />
                <asp:HiddenField ID="hfSizeID" runat="server" />
                <div class="form-group">
                    <asp:Button ID="btnEditSize" runat="server" CssClass="btn btn-success btn-block" Text="CHỈNH SỬA SIZE" OnClick="btnEditSize_Click" />
                </div>
            </div>
        </div>
    </div>
</div>
