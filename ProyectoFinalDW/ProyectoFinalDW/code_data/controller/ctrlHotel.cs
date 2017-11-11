using System;
using System.Collections.Generic;
using System.Data;
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

        public bool insertarUsuario(objetos.objNuevoUsuario Usuario)
        {
            if(!objHotel.InsertarUsuario(Usuario))
            {
                strMensaje = objHotel.strMensajeError;
                return false;
            }

            return true;
        }

        public DataTable consultarUsuarioRol()
        {

            DataTable dtResultado = objHotel.ConsultarUsuarioRol();
            if(dtResultado.Rows.Count <= 0)
            {
                strMensaje = "No se encontraron registros";
            }

            return dtResultado;

        }

        public DataTable consultarRol()
        {

            DataTable dtResultado = objHotel.ConsultarRol();
            if (dtResultado.Rows.Count <= 0)
            {
                strMensaje = "No se encontraron registros";
            }

            return dtResultado;

        }

        public DataTable consultarHabitacion()
        {
            DataTable dtResultado = objHotel.ConsultarHabitacion();
            if(dtResultado.Rows.Count <= 0)
            {
                strMensaje = "No se encontraron Registros";
            }

            return dtResultado;
        }

        public DataTable consultarTiempoReserva()
        {
            DataTable dtResultado = objHotel.ConsultarTiempoReserva();
            if(dtResultado.Rows.Count <= 0)
            {
                strMensaje = "No se encontraron Registros";
            }

            return dtResultado;
        }

        public bool insertarRol(objetos.objUsuarioRol Usuario)
        {
            if (!objHotel.InsertarRol(Usuario))
            {
                strMensaje = objHotel.strMensajeError;
                return false;
            }

            return true;
        }

        public bool insertarHotel(objetos.objHotel hotel)
        {
            if(!objHotel.InsertarHotel(hotel))
            {
                strMensaje = objHotel.strMensajeError;
                return false;
            }

            return true;
        }
    }
}