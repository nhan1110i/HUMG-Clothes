﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductReports.aspx.cs" Inherits="HUMG_Clothes.Admin.ReportsForms.ProductReports" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.1.Web, Version=16.1.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" ReportTypeName="HUMG_Clothes.Admin.Reports.ProductReports" Theme="iOS"></dx:ASPxDocumentViewer>
    </div>
    </form>
</body>
</html>
