using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Horarios_DAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);
        public int AgregarHorario(Horarios horario)
        {
            int idGenerado = 0;

            try
            {
                string query = "INSERT INTO Tb_Horarios (Horario_Duracion, Horario_Dias) VALUES (@Duracion, @Dias); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Duracion", horario.Horario_Duracion);
                cmd.Parameters.AddWithValue("@Dias", horario.Horario_Dias);
                conexion.Open();
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar horario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return idGenerado;
        }
        public List<Horarios> ObtenerHorarios()
        {
            List<Horarios> horarios = new List<Horarios>();
            try
            {
                string query = "SELECT * FROM Tb_Horarios";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Horarios horario = new Horarios
                    {
                        Horario_Id = Convert.ToInt32(reader["Horario_Id"]),
                        Horario_Duracion = (TimeSpan)reader["Horario_Duracion"],
                        Horario_Dias = reader["Horario_Dias"].ToString()
                    };
                    horarios.Add(horario);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener horarios: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return horarios;
        }

        public void EliminarHorario(int horarioId)
        {
            try
            {
                string query = "DELETE FROM Tb_Horarios WHERE Horario_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", horarioId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar horario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarHorario(Horarios horario)
        {
            try
            {
                string query = "UPDATE Tb_Horarios SET Horario_Duracion = @Duracion, Horario_Dias = @Dias WHERE Horario_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Duracion", horario.Horario_Duracion);
                cmd.Parameters.AddWithValue("@Dias", horario.Horario_Dias);
                cmd.Parameters.AddWithValue("@Id", horario.Horario_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar horario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Horarios> BuscarParametrosHorario(string parametro, string valor)
        {
            List<Horarios> horarios = new List<Horarios>();
            try
            {
                string query = $"SELECT * FROM Tb_Horarios WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Horarios horario = new Horarios
                    {
                        Horario_Id = Convert.ToInt32(reader["Horario_Id"]),
                        Horario_Duracion = (TimeSpan)reader["Horario_Duracion"],
                        Horario_Dias = reader["Horario_Dias"].ToString()
                    };
                    horarios.Add(horario);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar horarios por parámetros: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return horarios;
        }
    }
}
