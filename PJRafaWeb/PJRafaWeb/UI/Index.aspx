<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript">
        function Start() {
            $('#btnCoC').collapse({
                show: true
            })
            $('#btnCaC').collapse({
                show: true
            })    
        }
        function TabCli() {
            $('#FiltroClienteTb').collapse({
                show: true
            })
            document.getElementById("TxtBxs").style.visibility = "hidden";
            
        }
        function TxtCli() {
            document.getElementById("FiltroClienteTb").style.visibility = "hidden"; 
            $('#TxtBxs').collapse({
                show: true
            })
            $('#ConsultarCliente').collapse({
                show: true
            })
        }
    </script>
    
</head>
<body onload="Start()">
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto Crud WCF</h1>

            

            <p> 
            <asp:Label ID="lblMenssagem" runat="server" />
            </p>
        </div>
        <div class="container">
            <div class="span10 offset1">
                <div class="">
                    <br /><br />
                    <h3 class="well">Consulta de Cliente</h3>
                    <br /><br />
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                    
                        <div id="btnCoC" class="collapse multi-collapse">
                            
                            <p>
                                <button class="btn btn-primary" id="ConsultarCliente" type="button" data-toggle="collapse" data-target="#btnCoC" onclick="TabCli()" aria-expanded="false" aria-controls="collapseExample">
                                   Consultar Cliente
                                </button>                
                            </p>
                        </div>

                    
                    <div id="btnCaC" class="collapse multi-collapse">
                            
                            <p>
                                <button class="btn btn-primary" id="CadastrarCliente" type="button" data-toggle="collapse" data-target="#btnCaC" onclick="TxtCli()" aria-expanded="false" aria-controls="collapseExample">
                                   Cadastrar Cliente
                                </button>
                                
                            </p>
                        </div>
                    <a href="../Index.aspx" class="btn btn-link btn-lg" style="width:150px; position: absolute; left: 1000px; top: 400px;" >Voltar</a>
                    
                    <div id="FiltroClienteTb" class="collapse multi-collapse">
                        <div class="card card-body">

                                Nome: <br />
                             <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" Width="45%" CssClass="form-control" />
                                 RG: <br />
                             <asp:TextBox ID="txtRG" runat="server" placeholder="RG" Width="45%" CssClass="form-control" />
                                 CPF: <br />
                             <asp:TextBox ID="txtCPF" runat="server" placeholder="CPF" Width="45%" CssClass="form-control" />
                             <br /> <br />
                             <button type="button" class="btn btn-primary" style="width:150px; position: absolute; left: 590px; top: 168px;">Buscar Cliente</button>
                             <br /> <br /><hr style=" border-width: 2px; border-color:#363636 "/>
                            
                            

                            
                        
                            <asp:GridView ID="gridClientes" runat="server" HeaderStyle-BackColor="#363636" CssClass="table table-hover table-striped table-bordered table-dark   text-center" GridLines="None" AutoGenerateColumns="false">
                                <Columns>
                                    <asp:BoundField DataField="Nome" HeaderText="Nome" ItemStyle-Height="50px" ItemStyle-Width="100px"/> 
                                    <asp:BoundField DataField="RG" HeaderText="RG" ItemStyle-Height="50px" ItemStyle-Width="100px"/>
                                    <asp:BoundField DataField="CPF" HeaderText="CPF" ItemStyle-Height="50px" ItemStyle-Width="100px"/>
                                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" ItemStyle-Height="50px" ItemStyle-Width="100px"/>                                
                                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-info" Text="Detalhes" ItemStyle-Height="50px" ItemStyle-Width="100px"/>
                                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-warning" Text="Atualizar" ItemStyle-Height="50px" ItemStyle-Width="100px"/>
                                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-danger" Text="Excluir" ItemStyle-Height="50px" ItemStyle-Width="100px"/>
                                </Columns>
                                <RowStyle CssClass="cursor-pointer" />
                            </asp:GridView>
                        </div>
                    </div>

                    

                    <div class="collapse multi-collapse" id="TxtBxs" style="width:1000px; height:1000px; position: absolute; left: 150px; top: 450px; ">
                      <div class="card card-body">
                                 Nome: <br />
                             <asp:TextBox ID="TextBox1" runat="server" placeholder="Nome" Width="45%" CssClass="form-control" />
                                 RG: <br />
                             <asp:TextBox ID="TextBox2" runat="server" placeholder="RG" Width="45%" CssClass="form-control" />
                                 CPF: <br />
                             <asp:TextBox ID="TextBox3" runat="server" placeholder="CPF" Width="45%" CssClass="form-control" />
                                 Telefone: <br /> 
                             <asp:TextBox ID="TextBox4" runat="server" placeholder="Telefone" Width="45%" CssClass="form-control" />
                                 CEP:<br />
                             <asp:TextBox ID="TextBox5" runat="server" placeholder="CEP" Width="45%" CssClass="form-control" />
                             <button type="button" class="btn btn-primary" style="width:150px; position: absolute; left: 750px; top: 293px; ">Buscar CEP</button>
                             <br />
                                 Endereço:<br />
                             <asp:TextBox ID="TextBox6" runat="server" placeholder="Endereço" Width="45%" CssClass="form-control" />
                                 Cidade:<br />
                             <asp:TextBox ID="TextBox7" runat="server" placeholder="Cidade" Width="45%" CssClass="form-control" />
                                 UF:<br />
                             <asp:TextBox ID="TextBox8" runat="server" placeholder="UF" Width="45%" CssClass="form-control" />
                                 Número:<br />
                             <asp:TextBox ID="TextBox9" runat="server" placeholder="Número" Width="45%" CssClass="form-control" />
                      </div><br /><br />
                    </div>
                   
                    
                </div>
            </div>
            
            </div>
        
    </form>
</body>
</html>
