using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using Proyecto_Zoologico.Datos;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Plantilla_DAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarPlantilla(Plantilla plantilla)
        {
            try
            {
                string query = "INSERT INTO Tb_Plantillas (Plantilla_Sueldo, Plantilla_Bonos, Plantilla_Deduccion) VALUES (@Sueldo, @Bonos, @Deduccion)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Sueldo", plantilla.Plantilla_Sueldo);
                cmd.Parameters.AddWithValue("@Bonos", (object)plantilla.Plantilla_Bonos ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Deduccion", (object)plantilla.Plantilla_Deduccion ?? DBNull.Value);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar plantilla: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Plantilla> ObtenerPlantillas()
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            try
            {
                string query = "SELECT * FROM Tb_Plantillas";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Plantilla plantilla = new Plantilla
                    {
                        Plantilla_Id = Convert.ToInt32(reader["Plantilla_Id"]),
                        Plantilla_Sueldo = Convert.ToSingle(reader["Plantilla_Sueldo"])
                    };
                    try 
                    {
                        plantilla.Plantilla_Bonos = reader["Plantilla_Bonos"] != DBNull.Value ? Convert.ToSingle(reader["Plantilla_Bonos"]) : (float?)null;
                        plantilla.Plantilla_Deduccion = reader["Plantilla_Deduccion"] != DBNull.Value ? Convert.ToSingle(reader["Plantilla_Deduccion"]) : (float?)null;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al convertir bonos o deduccion: " + ex.Message);
                    }
                    plantillas.Add(plantilla);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener plantillas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return plantillas;
        }

        public void ActualizarPlantilla(Plantilla plantilla)
        {
            try
            {
                string query = "UPDATE Tb_Plantillas SET Plantilla_Sueldo = @Sueldo, Plantilla_Bonos = @Bonos, Plantilla_Deduccion = @Deduccion WHERE Plantilla_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Sueldo", plantilla.Plantilla_Sueldo);
                cmd.Parameters.AddWithValue("@Bonos", (object)plantilla.Plantilla_Bonos ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Deduccion", (object)plantilla.Plantilla_Deduccion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", plantilla.Plantilla_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar plantilla: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarPlantilla(int plantillaId)
        {
            try
            {
                string query = "DELETE FROM Tb_Plantillas WHERE Plantilla_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", plantillaId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar plantilla: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Plantilla> buscarParametrosPlantilla(string parametro, string valor)
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            try
            {
                string query = $"SELECT * FROM Tb_Plantillas WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Plantilla plantilla = new Plantilla
                    {
                        Plantilla_Id = Convert.ToInt32(reader["Plantilla_Id"]),
                        Plantilla_Sueldo = Convert.ToSingle(reader["Plantilla_Sueldo"])
                    };
                    try 
                    {
                        plantilla.Plantilla_Bonos = reader["Plantilla_Bonos"] != DBNull.Value ? Convert.ToSingle(reader["Plantilla_Bonos"]) : (float?)null;
                        plantilla.Plantilla_Deduccion = reader["Plantilla_Deduccion"] != DBNull.Value ? Convert.ToSingle(reader["Plantilla_Deduccion"]) : (float?)null;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al convertir bonos o deduccion: " + ex.Message);
                    }
                    plantillas.Add(plantilla);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener plantillas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return plantillas;
        }
    }
}
