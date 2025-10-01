using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    public class Jaulas_DAO
    {
        MySqlConnection connection = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarJaula(Jaulas jaula)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO tb_jaulas (Jaula_Ambiente, Jaula_Area, Locacion_Id, Animal_Id) VALUES (@ambiente, @area, @locacionId, @animalId)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ambiente", jaula.Jaula_Ambiente);
                command.Parameters.AddWithValue("@area", jaula.Jaula_Area);
                command.Parameters.AddWithValue("@locacionId", jaula.Locacion_Id);
                command.Parameters.AddWithValue("@animalId", jaula.Animal_Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la jaula: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Jaulas> ObtenerJaulas()
        {
            List<Jaulas> jaulas = new List<Jaulas>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM tb_jaulas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Jaulas jaula = new Jaulas(
                        reader["Jaula_Ambiente"].ToString(),
                        Convert.ToSingle(reader["Jaula_Area"]),
                        Convert.ToInt32(reader["Locacion_Id"]),
                        Convert.ToInt32(reader["Animal_Id"])
                    );
                    jaula.Jaula_Id = Convert.ToInt32(reader["Jaula_Id"]);
                    jaulas.Add(jaula);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las jaulas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return jaulas;
        }

        public void EliminarJaula(int jaulaId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM tb_jaulas WHERE Jaula_Id = @jaulaId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@jaulaId", jaulaId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la jaula: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ActualizarJaula(Jaulas jaula)
        {
            try
            {
                connection.Open();
                string query = "UPDATE tb_jaulas SET Jaula_Ambiente = @ambiente, Jaula_Area = @area, Locacion_Id = @locacionId, Animal_Id = @animalId WHERE Jaula_Id = @jaulaId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ambiente", jaula.Jaula_Ambiente);
                command.Parameters.AddWithValue("@area", jaula.Jaula_Area);
                command.Parameters.AddWithValue("@locacionId", jaula.Locacion_Id);
                command.Parameters.AddWithValue("@animalId", jaula.Animal_Id);
                command.Parameters.AddWithValue("@jaulaId", jaula.Jaula_Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la jaula: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Jaulas> BuscarParametrosJaulas(string parametro, string valor)
        {
            List<Jaulas> jaulas = new List<Jaulas>();
            try
            {
                connection.Open();
                string query = $"SELECT * FROM tb_jaulas WHERE {parametro} = @valor";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@valor", valor);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Jaulas jaula = new Jaulas(
                        reader["Jaula_Ambiente"].ToString(),
                        Convert.ToSingle(reader["Jaula_Area"]),
                        Convert.ToInt32(reader["Locacion_Id"]),
                        Convert.ToInt32(reader["Animal_Id"])
                    );
                    jaula.Jaula_Id = Convert.ToInt32(reader["Jaula_Id"]);
                    jaulas.Add(jaula);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las jaulas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return jaulas;
        }
    }
}
