using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using Proyecto_Zoologico.Datos;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Entradas_DAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarEntrada(Entradas entrada)
        {
            // Lógica para agregar una entrada a la base de datos
            try
            {
                //using (var conn = new MySqlConnection(ConexionSQL.cadenaConexion)) ;
                string query = "INSERT INTO Tb_Entradas (Entrada_Tipo, Entrada_Fecha) VALUES (@Tipo, @Fecha)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Tipo", entrada.Entrada_Tipo);
                cmd.Parameters.AddWithValue("@Fecha", entrada.Entrada_Fecha);
                conexion.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar entrada: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Entradas> ObtenerEntradas()
        {
            List<Entradas> entradas = new List<Entradas>();
            try
            {
                string query = "SELECT * FROM Tb_Entradas";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entradas entrada = new Entradas(
                        reader["Entrada_Tipo"].ToString(),
                        Convert.ToDateTime(reader["Entrada_Fecha"])
                    );
                    entrada.Entrada_Id = Convert.ToInt32(reader["Entrada_Id"]);
                    entradas.Add(entrada);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener entradas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return entradas;
        }

        public List<Entradas> buscarParametrosEntradas(string parametro, string valor)
        {
            List<Entradas> entradas = new List<Entradas>();
            try
            {
                string query = $"SELECT * FROM Tb_Entradas WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entradas entrada = new Entradas(
                        reader["Entrada_Tipo"].ToString(),
                        Convert.ToDateTime(reader["Entrada_Fecha"])
                    );
                    entrada.Entrada_Id = Convert.ToInt32(reader["Entrada_Id"]);
                    entradas.Add(entrada);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener entradas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return entradas;
        }
    

    public void actualizarEntrada(Entradas entrada)
        {
            // Lógica para actualizar una entrada en la base de datos
            try
            {
                string query = "UPDATE Tb_Entradas SET Entrada_Tipo = @Tipo, Entrada_Fecha = @Fecha WHERE Entrada_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Tipo", entrada.Entrada_Tipo);
                cmd.Parameters.AddWithValue("@Fecha", entrada.Entrada_Fecha);
                cmd.Parameters.AddWithValue("@Id", entrada.Entrada_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar entrada: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminarEntrada(int entradaId)
        {
            // Lógica para eliminar una entrada de la base de datos
            try
            {
                string query = "DELETE FROM Tb_Entradas WHERE Entrada_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", entradaId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar entrada: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
