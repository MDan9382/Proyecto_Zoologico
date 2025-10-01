using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Locaciones_DAO
    {
        MySqlConnection connection = new MySqlConnection(ConexionSQL.cadenaConexion);
        public void AgregarLocacion(Locaciones locacion)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO tb_locaciones (Locacion_Nombre, Locacion_Tipo) VALUES (@nombre, @tipo)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", locacion.Locacion_Nombre);
                command.Parameters.AddWithValue("@tipo", locacion.Locacion_Tipo);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la locación: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Locaciones> ObtenerLocaciones()
        {
            List<Locaciones> locaciones = new List<Locaciones>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM tb_locaciones";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Locaciones locacion = new Locaciones(
                        reader["Locacion_Nombre"].ToString(),
                        reader["Locacion_Tipo"].ToString()
                    );
                    locacion.Locacion_Id = Convert.ToInt32(reader["Locacion_Id"]);
                    locaciones.Add(locacion);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las locaciones: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return locaciones;
        }

        public void EliminarLocacion(int locacionId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM tb_locaciones WHERE Locacion_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", locacionId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la locación: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ActualizarLocacion(Locaciones locacion)
        {
            try
            {
                connection.Open();
                string query = "UPDATE tb_locaciones SET Locacion_Nombre = @nombre, Locacion_Tipo = @tipo WHERE Locacion_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", locacion.Locacion_Nombre);
                command.Parameters.AddWithValue("@tipo", locacion.Locacion_Tipo);
                command.Parameters.AddWithValue("@id", locacion.Locacion_Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la locación: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public List<Locaciones> BuscarParamatrosLocaciones(string parametro, string valor)
        {
            List<Locaciones> locaciones = new List<Locaciones>();
            try
            {
                connection.Open();
                string query = $"SELECT * FROM tb_locaciones WHERE {parametro} = @valor";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@valor", valor);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Locaciones locacion = new Locaciones(
                        reader["Locacion_Nombre"].ToString(),
                        reader["Locacion_Tipo"].ToString()
                    );
                    locacion.Locacion_Id = Convert.ToInt32(reader["Locacion_Id"]);
                    locaciones.Add(locacion);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las locaciones: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return locaciones;
        }

    }
}
