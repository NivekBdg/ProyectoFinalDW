using ProyectoFinalDW.code_data.controller;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Session["usuario"].ToString() == "")
            //{
            //    Response.Redirect("frmLogin.aspx");
            //}
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreUsuario.Text != "" && TxtPass.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtId.Text != "")
            {
                objNuevoUsuario objUsuario = new objNuevoUsuario()
                {
                    strUser = txtNombreUsuario.Text,
                    strPass = TxtPass.Text,
                    strCorreo = txtEmail.Text,
                    strDireccion = txtDireccion.Text,
                    strNombre = txtNombre.Text,
                    strApellidos = txtApellidos.Text,
                    strTelefono = txtTelefono.Text,
                    int64Dni = Convert.ToInt64(txtId.Text),
                };

                ctrlHotel objHotel = new ctrlHotel();

                if (objHotel.insertarUsuario(objUsuario))
                {
                    dvCorrecto.Visible = true;
                }
                else
                {
                    dvError.Visible = true;
                    lblError.Text = objHotel.strMensaje;
                }
            }
            else
            {
                txtNombreUsuario.ToolTip = "error";
            }
        }
    }
}