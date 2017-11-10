using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.controller
{
    public class ctrlHotel
    {
        dao.daoHotel objHotel = new dao.daoHotel();
        public string strMensaje { get; set; }

        public bool ConsultarUsuario(objetos.objUsuario Usuario)
        {
            if(!objHotel.ConsultarUsuario(Usuario))
            {
                strMensaje = objHotel.strMensajeError;
                return false;
            }

            return true;
        }
    }
}