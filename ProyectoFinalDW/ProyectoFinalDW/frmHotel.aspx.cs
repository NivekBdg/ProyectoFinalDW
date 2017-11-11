using ProyectoFinalDW.code_data.controller;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ctrlHotel objHotel = new ctrlHotel();
                ddlTiempoReserva.DataSource = objHotel.consultarTiempoReserva();
                ddlTiempoReserva.DataTextField = "unidad";
                ddlTiempoReserva.DataValueField = "id";
                ddlTiempoReserva.DataBind();
            }
           
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmMenuPrincipal.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objHotel objHotel = new objHotel()
            {
                strCiudad = txtCiudad.Text,
                strDireccion = txtDireccion.Text,
                strEstrellas = TxtEstrellas.Text,
                strNombreHotel = txtNombreHotel.Text,
                strPrecio = txtPrecio.Text,
                strTelefono = txtTelefono.Text,
                strTiempoReserva = ddlTiempoReserva.SelectedValue,
            };

            ctrlHotel ctrlHotel = new ctrlHotel();
            if(!ctrlHotel.insertarHotel(objHotel))
            {
                dvError.Visible = true;
                dvCorrecto.Visible = false;
                lblError.Text = ctrlHotel.strMensaje;
            }
            else
            {
                dvCorrecto.Visible = true;
                dvError.Visible = false;
            }
        }
    }
}