using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Empleados_DAO
    {
        MySqlConnection connection = new MySqlConnection(ConexionSQL.cadenaConexion);
        public void AgregarEmpleado(Empleados empleado)
        {
            try
            {
                string query = "INSERT INTO Tb_Empleados (Empleado_NIT, Empleado_DPI, Empleado_Nombre, Empleado_Cargo, Plantilla_Id, Horario_Id) " +
                               "VALUES (@NIT, @DPI, @Nombre, @Cargo, @PlantillaId, @HorarioId)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NIT", empleado.Empleado_NIT);
                cmd.Parameters.AddWithValue("@DPI", empleado.Empleado_DPI);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Empleado_Nombre);
                cmd.Parameters.AddWithValue("@Cargo", empleado.Empleado_Cargo);
                cmd.Parameters.AddWithValue("@PlantillaId", empleado.Plantilla_Id);
                cmd.Parameters.AddWithValue("@HorarioId", empleado.Horario_Id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar empleado: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Empleados> ObtenerEmpleados()
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                string query = "SELECT * FROM Tb_Empleados";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Empleados empleado = new Empleados
                    {
                        Empleado_Id = Convert.ToInt32(reader["Empleado_Id"]),
                        Empleado_NIT = reader["Empleado_NIT"].ToString(),
                        Empleado_DPI = reader["Empleado_DPI"].ToString(),
                        Empleado_Nombre = reader["Empleado_Nombre"].ToString(),
                        Empleado_Cargo = reader["Empleado_Cargo"].ToString(),
                        Plantilla_Id = Convert.ToInt32(reader["Plantilla_Id"]),
                        Horario_Id = Convert.ToInt32(reader["Horario_Id"])
                    };
                    empleados.Add(empleado);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleados: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return empleados;
        }

        public void ActualizarEmpleado(Empleados empleado)
        {
            try
            {
                string query = "UPDATE Tb_Empleados SET Empleado_NIT = @NIT, Empleado_DPI = @DPI, Empleado_Nombre = @Nombre, " +
                               "Empleado_Cargo = @Cargo, Plantilla_Id = @PlantillaId, Horario_Id = @HorarioId WHERE Empleado_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NIT", empleado.Empleado_NIT);
                cmd.Parameters.AddWithValue("@DPI", empleado.Empleado_DPI);
                cmd.Parameters.AddWithValue("@Nombre", empleado.Empleado_Nombre);
                cmd.Parameters.AddWithValue("@Cargo", empleado.Empleado_Cargo);
                cmd.Parameters.AddWithValue("@PlantillaId", empleado.Plantilla_Id);
                cmd.Parameters.AddWithValue("@HorarioId", empleado.Horario_Id);
                cmd.Parameters.AddWithValue("@Id", empleado.Empleado_Id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar empleado: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void EliminarEmpleado(int empleadoId)
        {
            try
            {
                string query = "DELETE FROM Tb_Empleados WHERE Empleado_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", empleadoId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar empleado: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Empleados> BuscarParametrosEmpleados(string parametro, string valor)
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                string query = $"SELECT * FROM Tb_Empleados WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@valor", valor);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Empleados empleado = new Empleados
                    {
                        Empleado_Id = Convert.ToInt32(reader["Empleado_Id"]),
                        Empleado_NIT = reader["Empleado_NIT"].ToString(),
                        Empleado_DPI = reader["Empleado_DPI"].ToString(),
                        Empleado_Nombre = reader["Empleado_Nombre"].ToString(),
                        Empleado_Cargo = reader["Empleado_Cargo"].ToString(),
                        Plantilla_Id = Convert.ToInt32(reader["Plantilla_Id"]),
                        Horario_Id = Convert.ToInt32(reader["Horario_Id"])
                    };
                    empleados.Add(empleado);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar empleados por nombre: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return empleados;
        }
    }
}
