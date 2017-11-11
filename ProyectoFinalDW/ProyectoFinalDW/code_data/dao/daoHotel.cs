using MySql.Data.MySqlClient;
using ProyectoFinalDW.code_data.objetos;
using System;
using System.Data;

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

        public DataTable ConsultarUsuarioRol()
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = " SELECT id, username from usuario ";

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
                DataTable dtResultado = new DataTable();
                dtResultado.Columns.Add("id");
                dtResultado.Columns.Add("username");
                while (reader.Read())
                {
                    DataRow dr = dtResultado.NewRow();
                    dr["id"] = reader.GetValue(0);
                    dr["username"] = reader.GetValue(1);
                    dtResultado.Rows.Add(dr);
                }
                dtResultado.AcceptChanges();
                return dtResultado;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return new DataTable();
            }
        }

        public DataTable ConsultarRol()
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = " SELECT id, authority from role ";

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
                DataTable dtResultado = new DataTable();
                dtResultado.Columns.Add("id");
                dtResultado.Columns.Add("authority");
                while (reader.Read())
                {
                    DataRow dr = dtResultado.NewRow();
                    dr["id"] = reader.GetValue(0);
                    dr["authority"] = reader.GetValue(1);
                    dtResultado.Rows.Add(dr);
                }
                dtResultado.AcceptChanges();
                return dtResultado;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return new DataTable();
            }
        }

        public bool InsertarUsuario(objNuevoUsuario Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @" INSERT INTO usuario(username, password, email, dni, nombre, apellidos, direccion, tlf, enabled)  
                                VALUES('" + Usuario.strUser + "', '" + Usuario.strPass + "', '" + Usuario.strCorreo + "', " + Usuario.int64Dni + "," +
                                " '" + Usuario.strNombre + "', '" + Usuario.strApellidos + "', '" + Usuario.strDireccion + "', " + Usuario.strTelefono + ", 1)";

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
                int reader = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                strMensajeError = e.Message;
                return false;
            }
            return idnumber;
        }

        public DataTable ConsultarHabitacion()
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = " SELECT id, codigo from habitacion where ocupada = 0 ";

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
                DataTable dtResultado = new DataTable();
                dtResultado.Columns.Add("id");
                dtResultado.Columns.Add("codigo");
                while (reader.Read())
                {
                    DataRow dr = dtResultado.NewRow();
                    dr["id"] = reader.GetValue(0);
                    dr["codigo"] = reader.GetValue(1);
                    dtResultado.Rows.Add(dr);
                }
                dtResultado.AcceptChanges();
                return dtResultado;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return new DataTable();
            }
        }

        public DataTable ConsultarTiempoReserva()
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = " SELECT id, unidad from periodo ";

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
                DataTable dtResultado = new DataTable();
                dtResultado.Columns.Add("id");
                dtResultado.Columns.Add("unidad");
                while (reader.Read())
                {
                    DataRow dr = dtResultado.NewRow();
                    dr["id"] = reader.GetValue(0);
                    dr["unidad"] = reader.GetValue(1);
                    dtResultado.Rows.Add(dr);
                }
                dtResultado.AcceptChanges();
                return dtResultado;
            }
            catch (Exception ex)
            {
                strMensajeError = ex.Message;
                return new DataTable();
            }
        }

        public bool InsertarRol(objUsuarioRol Usuario)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @" INSERT INTO user_role(user_id, role_id)  
                                VALUES(" + Usuario.strUser + ", " + Usuario.strRol + ") ";

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
                int reader = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                strMensajeError = e.Message;
                return false;
            }
            return idnumber;
        }

        public bool InsertarHotel(objHotel Hotel)
        {
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=hotel_bd;uid=conexion;password=pruebas1.");
            bool idnumber = false;
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @" INSERT INTO hotel(nombre, estrellas, direccion, ciudad, telefono, precio_supletoria, tiempo_reserva_id)  
                                VALUES('" + Hotel.strNombreHotel + "', '" + Hotel.strEstrellas + "', '" + Hotel.strDireccion + "', '" + Hotel.strCiudad + @"', 
                                '" + Hotel.strTelefono + "', '" + Hotel.strPrecio + "', " + Hotel.strTiempoReserva + ") ";

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
                int reader = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                strMensajeError = e.Message;
                return false;
            }
            return idnumber;
        }

    }
}