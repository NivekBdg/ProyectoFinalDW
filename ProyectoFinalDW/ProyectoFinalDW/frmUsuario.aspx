<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="ProyectoFinalDW.frmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento a Usuarios</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 text-center modal-body">
            <asp:Label runat="server" Text="Mantenimiento a Usuarios"></asp:Label>
        </div>
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Ingreso de nuevo Usuario"></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre de Usuario: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombreUsuario" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Contraseña: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TxtPass" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Email: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Apellidos: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtApellidos" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Dirección: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-12 modal-body">
            <div class="col-md-4 col-md-offset-5">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
