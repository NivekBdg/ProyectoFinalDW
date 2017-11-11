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
    public partial class frmBebidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Session["usuario"].ToString() == "")
            //    {
            //        Response.Redirect("Login.aspx");
            //    }
            //}
            //catch
            //{
            //    Response.Redirect("Login.aspx");
            //}

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombreBebida.Text != "" && txtMarca.Text != "" && TxtPrecio.Text != "" && txtFechaCaducidad.Text != "")
            {
                objNuevaBebida objBebidas = new objNuevaBebida()
                {
                    strBebida = txtNombreBebida.Text,
                    strMarca = txtMarca.Text,
                    strPrecio = TxtPrecio.Text,
                    strFecha = txtFechaCaducidad.Text,
                    int64Dni = Convert.ToInt64(txtFechaCaducidad.Text),
                };

                ctrlHotel objHotel = new ctrlHotel();

                if (objHotel.insertarBebida(objBebidas))
                {
                    dvCorrecto.Visible = true;
                    dvError.Visible = false;
                }
                else
                {
                    dvCorrecto.Visible = false;
                    dvError.Visible = true;
                    lblError.Text = objHotel.strMensaje;
                }
            }
            else
            {
                if (txtNombreBebida.Text == "")
                {
                    lblError1.Visible = true;
                }
                if (txtMarca.Text == "")
                {
                    lblError2.Visible = true;
                }
                if (TxtPrecio.Text == "")
                {
                    lblError2.Visible = true;
                }
                if (txtFechaCaducidad.Text == "")
                {
                    lblError2.Visible = true;
                }
                dvCorrecto.Visible = false;
                dvError.Visible = true;
                lblError.Text = "Debe ingresar los campos obligatorios!";
            }
        }

        protected void btnBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmMenuPrincipal.aspx");
        }
    }
}