using ProyectoFinalDW.code_data.controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmReservar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                ctrlHotel objHotel = new ctrlHotel();
                gvReserva.DataSource = objHotel.consultarHabitacion();
                
                gvReserva.DataBind();
            }
            
        }
    }
}