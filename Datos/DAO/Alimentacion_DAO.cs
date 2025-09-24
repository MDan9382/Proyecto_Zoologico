using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    public class Alimentacion_DAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarAlimentacion(Alimentacion alimentacion)
        {
            try
            {
                string query = "INSERT INTO Tb_Alimentacion (Alimentacion_Hora, Alimentacion_Dieta, Inventario_Id) " +
                               "VALUES (@Hora, @Dieta, @InventarioId)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Hora", alimentacion.Alimentacion_Hora);
                cmd.Parameters.AddWithValue("@Dieta", alimentacion.Alimentacion_Dieta);
                cmd.Parameters.AddWithValue("@InventarioId", alimentacion.Inventario_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar alimentación: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Alimentacion> ObtenerAlimentaciones()
        {
            List<Alimentacion> alimentaciones = new List<Alimentacion>();
            try
            {
                string query = "SELECT * FROM Tb_Alimentacion";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Alimentacion alimentacion = new Alimentacion(
                        (TimeSpan)reader["Alimentacion_Hora"],
                        reader["Alimentacion_Dieta"].ToString(),
                        Convert.ToInt32(reader["Inventario_Id"])
                    );
                    alimentacion.Alimentacion_Id = Convert.ToInt32(reader["Alimentacion_Id"]);
                    alimentaciones.Add(alimentacion);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener alimentaciones: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return alimentaciones;
        }

        public void ActualizarAlimentacion(Alimentacion alimentacion)
        {   
            try
            {
                string query = "UPDATE Tb_Alimentacion SET Alimentacion_Hora = @Hora, Alimentacion_Dieta = @Dieta, Inventario_Id = @InventarioId " +
                               "WHERE Alimentacion_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Hora", alimentacion.Alimentacion_Hora);
                cmd.Parameters.AddWithValue("@Dieta", alimentacion.Alimentacion_Dieta);
                cmd.Parameters.AddWithValue("@InventarioId", alimentacion.Inventario_Id);
                cmd.Parameters.AddWithValue("@Id", alimentacion.Alimentacion_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar alimentación: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarAlimentacion(int alimentacionId)
        {
            try
            {
                string query = "DELETE FROM Tb_Alimentacion WHERE Alimentacion_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", alimentacionId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar alimentación: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Alimentacion> BuscarParametrosAlimentacion(string parametro, string valor)
        {
            List<Alimentacion> alimentaciones = new List<Alimentacion>();
            try
            {
                string query = $"SELECT * FROM Tb_Alimentacion WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Alimentacion alimentacion = new Alimentacion(
                        (TimeSpan)reader["Alimentacion_Hora"],
                        reader["Alimentacion_Dieta"].ToString(),
                        Convert.ToInt32(reader["Inventario_Id"])
                    );
                    alimentacion.Alimentacion_Id = Convert.ToInt32(reader["Alimentacion_Id"]);
                    alimentaciones.Add(alimentacion);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar alimentaciones: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return alimentaciones;
        }

    }
}
