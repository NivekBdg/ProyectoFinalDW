﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalDW.code_data.objetos
{
    public class objBebida
    {
        public string strBebida { get; set; }
        public string strMarca { get; set; }
        public string strPrecio { get; set; }
        public string strFecha { get; set; }

        public objBebida() { }

        public objBebida(string strBebida, string strMarca, tring strPrecio, tring strFecha)
        {
            this.strUser = strBebida;
            this.strPass = strMarca;
            this.strPass = strPrecio;
            this.strPass = strFecha;
        }

    }
}