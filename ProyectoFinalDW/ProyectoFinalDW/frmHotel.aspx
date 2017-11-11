<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHotel.aspx.cs" Inherits="ProyectoFinalDW.frmHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mantenimiento a Hoteles</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 text-center modal-body bg-primary">
            <asp:ImageButton runat="server" ImageUrl="Imagenes/back.png" Width="50px" Height="50px" ID="btnBack" OnClick="btnBack_Click"/>
           <h1><asp:Label runat="server" Text="Mantenimiento a Hoteles"></asp:Label></h1>
        </div>
        <div class="col-md-12 table-bordered">
            <div class="col-md-12 text-center modal-body">
                <asp:Label runat="server" Text="Ingreso de nuevo Hotel"></asp:Label>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Nombre de Hotel: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtNombreHotel" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Estrellas: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TxtEstrellas"  CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Ciudad: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Teléfono: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Tiempo de reserva: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtReserva" CssClass="form-control" TextMode="Number"></asp:TextBox>
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
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Precio: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="txtPrecio" TextMode="Number" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-3">
                    <asp:Label runat="server" Text="Tiempo de reserva: "></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="ddlTiempoReserva" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="col-md-12 modal-body">
                <div class="col-md-4 col-md-offset-5">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
                </div>
            </div>
        </div>
        <div class="col-md-12">
            <asp:GridView ID="gvHoteles" runat="server" EmptyDataText="No Hay hoteles ingresados" ></asp:GridView>
        </div>
        <div class="alert alert-success col-md-12" runat="server" id="dvCorrecto" visible="false">
            <strong>Error:</strong> Usuario Ingresado correctamente 
        </div>
        <div class="alert alert-danger col-md-12" runat="server" id="dvError" visible="false">
            <strong>Error:</strong><asp:Label runat="server" ID="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>
