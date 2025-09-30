using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    public class Inventario_DAO
    {
        MySqlConnection connection = new MySqlConnection(ConexionSQL.cadenaConexion);
        public void AgregarInventario(Inventario inventario)
        {
            try
            {
                string query = "INSERT INTO Tb_Inventario (Inventario_Nombre, Inventario_Tipo, Inventario_Cantidad) " +
                               "VALUES (@Nombre, @Tipo, @Cantidad)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", inventario.Inventario_Nombre);
                cmd.Parameters.AddWithValue("@Tipo", inventario.Inventario_Tipo);
                cmd.Parameters.AddWithValue("@Cantidad", inventario.Inventario_Cantidad);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar inventario: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Inventario> ObtenerInventarios()
        {
            List<Inventario> inventarios = new List<Inventario>();
            try
            {
                string query = "SELECT * FROM Tb_Inventario";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Inventario inventario = new Inventario
                        (
                        reader["Inventario_Nombre"].ToString(),
                        reader["Inventario_Tipo"].ToString(),
                        Convert.ToInt32(reader["Inventario_Cantidad"])
                        );
                    inventario.Inventario_Id = Convert.ToInt32(reader["Inventario_Id"]);
                    inventarios.Add(inventario);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener inventarios: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return inventarios;
        }

        public void ActualizarInventario(Inventario inventario)
        {
            try
            {
                string query = "UPDATE Tb_Inventario SET Inventario_Nombre = @Nombre, Inventario_Tipo = @Tipo, Inventario_Cantidad = @Cantidad " +
                               "WHERE Inventario_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", inventario.Inventario_Nombre);
                cmd.Parameters.AddWithValue("@Tipo", inventario.Inventario_Tipo);
                cmd.Parameters.AddWithValue("@Cantidad", inventario.Inventario_Cantidad);
                cmd.Parameters.AddWithValue("@Id", inventario.Inventario_Id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar inventario: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void EliminarInventario(int inventarioId)
        {
            try
            {
                string query = "DELETE FROM Tb_Inventario WHERE Inventario_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", inventarioId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar inventario: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

       public List<Inventario> BuscarParametrosInventario(string parametro, string valor)
        {
            List<Inventario> inventarios = new List<Inventario>();
            try
            {
                string query = $"SELECT * FROM Tb_Inventario WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@valor", valor);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Inventario inventario = new Inventario(

                        reader["Inventario_Nombre"].ToString(),
                        reader["Inventario_Tipo"].ToString(),
                        Convert.ToInt32(reader["Inventario_Cantidad"])
                        );
                  
                    inventario.Inventario_Id = Convert.ToInt32(reader["Inventario_Id"]);
                    inventarios.Add(inventario);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar inventarios: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return inventarios;
        }

    }
}
