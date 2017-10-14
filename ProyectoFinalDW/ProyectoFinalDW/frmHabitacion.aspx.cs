using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalDW
{
    public partial class frmHabitacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvHabitaciones.DataSource = new DataTable();
            gvHabitaciones.DataBind();
        }
    }
}