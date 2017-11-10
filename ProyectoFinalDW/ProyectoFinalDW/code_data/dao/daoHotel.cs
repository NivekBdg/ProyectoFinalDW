using MySql.Data.MySqlClient;
using ProyectoFinalDW.code_data.objetos;
using System;

namespace ProyectoFinalDW.code_data.dao
{
    public class daoHotel
    {
        public string strMensajeError { get; set; }

        public daoHotel() { }

        public bool ConsultarUsuario(objUsuario Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) resultado from usuario WHERE username = '" + Usuario.strUser + "'";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                strMensajeError = erro.Message;
                dbConn.Close();
            }
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idnumber = reader.HasRows;
                }

                return idnumber;
            }
            catch(Exception ex)
            {
                strMensajeError = ex.Message;
                return false;
            }
           
        }

        public bool InsertarUsuario(objUsuario Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "INSERT INTO usuario(username, password, email, dni, nombre, apellidos, direccion, tlf, enabled)  VALUES('" + Usuario.strUser + "', '" + Usuario.strPass + "', 'test', 1234, 'Rick', 'Bol', 'Z5', 123456, 1)";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                dbConn.Close();
            }
            try
            {
                int reader = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return false;
            }
            return idnumber;
        }

    }
}