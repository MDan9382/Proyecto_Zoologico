using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    public class ControlClinico_DAO
    {
        MySqlConnection connection = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarControlClinico(Control_Clinico controlClinico)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO tb_control_clinico (ControlClinico_Fecha, ControlClinico_Tratamiento, ControlClinico_Descripcion, Animal_Id, Empleado_Id) VALUES (@fecha, @tratamiento, @descripcion, @animalId, @empleadoId)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha", controlClinico.ControlClinico_Fecha);
                command.Parameters.AddWithValue("@tratamiento", controlClinico.ControlClinico_Tratamiento);
                command.Parameters.AddWithValue("@descripcion", controlClinico.ControlClinico_Descripcion);
                command.Parameters.AddWithValue("@animalId", controlClinico.Animal_Id);
                command.Parameters.AddWithValue("@empleadoId", controlClinico.Empleado_Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el control clínico: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Control_Clinico> ObtenerControlesClinicos()
        {
            List<Control_Clinico> controlesClinicos = new List<Control_Clinico>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM tb_control_clinico";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Control_Clinico controlClinico = new Control_Clinico(
                        Convert.ToDateTime(reader["ControlClinico_Fecha"]),
                        reader["ControlClinico_Tratamiento"].ToString(),
                        Convert.ToInt32(reader["Animal_Id"]),
                        Convert.ToInt32(reader["Empleado_Id"])
                    );
                    controlClinico.ControlClinico_Id = Convert.ToInt32(reader["ControlClinico_Id"]);
                    controlClinico.ControlClinico_Descripcion = reader["ControlClinico_Descripcion"].ToString();
                    controlesClinicos.Add(controlClinico);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los controles clínicos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return controlesClinicos;
        }

        public void EliminarControlClinico(int controlClinicoId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM tb_control_clinico WHERE ControlClinico_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", controlClinicoId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el control clínico: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ActualizarControlClinico(Control_Clinico controlClinico)
        {
            try
            {
                connection.Open();
                string query = "UPDATE tb_control_clinico SET ControlClinico_Fecha = @fecha, ControlClinico_Tratamiento = @tratamiento, ControlClinico_Descripcion = @descripcion, Animal_Id = @animalId, Empleado_Id = @empleadoId WHERE ControlClinico_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha", controlClinico.ControlClinico_Fecha);
                command.Parameters.AddWithValue("@tratamiento", controlClinico.ControlClinico_Tratamiento);
                command.Parameters.AddWithValue("@descripcion", controlClinico.ControlClinico_Descripcion);
                command.Parameters.AddWithValue("@animalId", controlClinico.Animal_Id);
                command.Parameters.AddWithValue("@empleadoId", controlClinico.Empleado_Id);
                command.Parameters.AddWithValue("@id", controlClinico.ControlClinico_Id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el control clínico: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Control_Clinico> BuscarControlesClinicosPorAnimal(string parametro, string valor)
        {
            List<Control_Clinico> controlesClinicos = new List<Control_Clinico>();
            try
            {
                connection.Open();
                string query = $"SELECT * FROM tb_control_clinico WHERE {parametro} = @valor";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@valor", valor);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Control_Clinico controlClinico = new Control_Clinico(
                        Convert.ToDateTime(reader["ControlClinico_Fecha"]),
                        reader["ControlClinico_Tratamiento"].ToString(),
                        Convert.ToInt32(reader["Animal_Id"]),
                        Convert.ToInt32(reader["Empleado_Id"])
                    );
                    controlClinico.ControlClinico_Id = Convert.ToInt32(reader["ControlClinico_Id"]);
                    controlClinico.ControlClinico_Descripcion = reader["ControlClinico_Descripcion"].ToString();
                    controlesClinicos.Add(controlClinico);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los controles clínicos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return controlesClinicos;
        }
    }
}
