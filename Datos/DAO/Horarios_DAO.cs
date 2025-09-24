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
        public void AgregarHorario(Horarios horario)
        {
            try
            {
                string query = "INSERT INTO Tb_Horarios (Horario_Duracion, Horario_Dias) VALUES (@Duracion, @Dias)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Duracion", horario.Horario_Duracion);
                cmd.Parameters.AddWithValue("@Dias", horario.Horario_Dias);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar horario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
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
    }
}
