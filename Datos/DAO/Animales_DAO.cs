using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    public class Animales_DAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarAnimal(Animales animal)
        {
            try
            {
                string query = "INSERT INTO Tb_Animales (Animal_Especie, Animal_Tamaño, Animal_Peso, Animal_Dieta) " +
                               "VALUES (@Especie, @Tamaño, @Peso, @Dieta)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Especie", animal.Animal_Especie);
                cmd.Parameters.AddWithValue("@Tamaño", animal.Animal_Tamaño);
                cmd.Parameters.AddWithValue("@Peso", animal.Animal_Peso);
                cmd.Parameters.AddWithValue("@Dieta", animal.Animal_Dieta);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar animal: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Animales> ObtenerAnimales()
        {
            List<Animales> animales = new List<Animales>();
            try
            {
                string query = "SELECT * FROM Tb_Animales";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Animales animal = new Animales(
                        reader["Animal_Especie"].ToString(),
                        Convert.ToSingle(reader["Animal_Tamaño"]),
                        Convert.ToSingle(reader["Animal_Peso"]),
                        Convert.ToString(reader["Animal_Dieta"])
                    );
                    animal.Animal_Id = Convert.ToInt32(reader["Animal_Id"]);
                    animales.Add(animal);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener animales: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return animales;
        }

        public void ActualizarAnimal(Animales animal)
        {
            try
            {
                string query = "UPDATE Tb_Animales SET Animal_Especie = @Especie, Animal_Tamaño = @Tamaño, " +
                               "Animal_Peso = @Peso, Animal_Dieta = @Dieta WHERE Animal_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Especie", animal.Animal_Especie);
                cmd.Parameters.AddWithValue("@Tamaño", animal.Animal_Tamaño);
                cmd.Parameters.AddWithValue("@Peso", animal.Animal_Peso);
                cmd.Parameters.AddWithValue("@Dieta", animal.Animal_Dieta);
                cmd.Parameters.AddWithValue("@Id", animal.Animal_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar animal: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarAnimal(int animalId)
        {
            try
            {
                string query = "DELETE FROM Tb_Animales WHERE Animal_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", animalId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar animal: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Animales> BuscarParametrosAnimales(string parametro, string valor)
        {
            List<Animales> animales = new List<Animales>();
            try
            {
                string query = $"SELECT * FROM Tb_Animales WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Animales animal = new Animales(
                        reader["Animal_Especie"].ToString(),
                        Convert.ToSingle(reader["Animal_Tamaño"]),
                        Convert.ToSingle(reader["Animal_Peso"]),
                        Convert.ToString(reader["Animal_Dieta"])
                    );
                    animal.Animal_Id = Convert.ToInt32(reader["Animal_Id"]);
                    animales.Add(animal);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar animales: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return animales;
        }
        public List<string> BuscarAnimales() 
        {
            List<string> animales = new List<string>();
            try 
            {
                string query = "select Animal_Especie from db_zoologico.tb_animales;";
                MySqlCommand cmd = new MySqlCommand(query, conexion);                
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string animal = reader["Animal_Especie"].ToString();                    
                    animales.Add(animal);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error al buscar animales: " + ex.Message);
            }
            finally 
            {
                conexion.Close();
            }
            return animales;
        }

        public int ObtenerAnimalIdPorEspecie(string especie)
        {
            int animalId = -1;
            try
            {
                string query = "SELECT Animal_Id FROM db_zoologico.tb_animales WHERE Animal_Especie = @Especie LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Especie", especie);
                conexion.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    animalId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el ID del animal: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return animalId;
        }

    }
}
