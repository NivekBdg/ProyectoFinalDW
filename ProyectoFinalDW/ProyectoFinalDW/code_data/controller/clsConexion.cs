using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace ProyectoFinalDW.code_data
{
    

    public class clsConexion
    {
        
        public static MySqlConnection IniciarConexion()
        {
            MySqlConnection Conexion = new MySqlConnection("Server=localhost;Uid=conexion;Database=hotel_bd;Password=pruebas1.");
            Conexion.Open();
            return Conexion;
        }
    }
}