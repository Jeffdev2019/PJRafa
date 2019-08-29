<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto Crud WCF</h1>

            <asp:Button ID="btnConsultar" runat="server" Text="Consultar Clientes" CssClass="btn btn-primary btn-lg" OnClick="btnConsultar_Click"/>

            <p> 
            <asp:Label ID="lblMenssagem" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
