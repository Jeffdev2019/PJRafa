<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="UI.Pages.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar Clientes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="">
                    <h3 class="well">Consulta de Cliente</h3>
                    <br />

                    <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#DCDCDC">
                        <Columns>
                            <asp:BoundField DataField="Nome" HeaderText="Nome" /> 
                            <asp:Button  Id="oi" /> 
                            <asp:BoundField DataField="RG" HeaderText="RG" />
                            <asp:BoundField DataField="CPF" HeaderText="CPF" />
                            <asp:BoundField DataField="Telefone" HeaderText="Telefone" /> 

                        </Columns>

                        <RowStyle CssClass="cursor-pointer" />
                    </asp:GridView>
                    <br /><br />
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                            <asp:Button ID="btnConsultar" runat="server" Text="Consultar Clientes" CssClass="btn btn-primary btn-lg"/>

                    <a href="../Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
