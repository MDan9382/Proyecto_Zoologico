using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Control_LimpiezaDAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);

        public void AgregarControlLimpieza(Control_Limpieza controlLimpieza)
        {
           
            try
            {
                conexion.Open();
                string query = "INSERT INTO Tb_Control_Limpieza (ControlLimpieza_Hora, Empleado_Id, ControlLimpieza_Fecha, Locacion_Id) VALUES (@Hora, @EmpleadoId, @Fecha, @Locacion_Id)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Hora", controlLimpieza.ControlLimpieza_Hora);
                cmd.Parameters.AddWithValue("@EmpleadoId", controlLimpieza.Empleado_Id);
                cmd.Parameters.AddWithValue("@Fecha", controlLimpieza.ControlLimpieza_Fecha);
                cmd.Parameters.AddWithValue("@Locacion_Id", controlLimpieza.Locacion_Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar control de limpieza: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Control_Limpieza> ObtenerControlesLimpieza()
        {
            List<Control_Limpieza> controlesLimpieza = new List<Control_Limpieza>();
            try
            {
                string query = "SELECT * FROM Tb_Control_Limpieza";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Control_Limpieza controlLimpieza = new Control_Limpieza(
                        (TimeSpan)reader["ControlLimpieza_Hora"],
                        Convert.ToInt32(reader["Empleado_Id"]),
                        Convert.ToInt32(reader["Locacion_Id"]),
                        Convert.ToDateTime(reader["ControlLimpieza_Fecha"])                        
                    );
                    
                    controlLimpieza.ControlLimpieza_Id = Convert.ToInt32(reader["ControlLimpieza_Id"]);                    
                    controlesLimpieza.Add(controlLimpieza);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener controles de limpieza: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return controlesLimpieza;
        }

        public void EliminarControlLimpieza(int controlLimpiezaId)
        {
            try
            {
                string query = "DELETE FROM Tb_Control_Limpieza WHERE ControlLimpieza_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", controlLimpiezaId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar control de limpieza: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarControlLimpieza(Control_Limpieza controlLimpieza)
        {
            try
            {
                string query = "UPDATE Tb_Control_Limpieza SET ControlLimpieza_Hora = @Hora, Empleado_Id = @EmpleadoId, ControlLimpieza_Fecha = @Fecha WHERE ControlLimpieza_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Hora", controlLimpieza.ControlLimpieza_Hora);
                cmd.Parameters.AddWithValue("@EmpleadoId", controlLimpieza.Empleado_Id);
                cmd.Parameters.AddWithValue("@Id", controlLimpieza.ControlLimpieza_Id);
                cmd.Parameters.AddWithValue("@Fecha", controlLimpieza.ControlLimpieza_Fecha);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar control de limpieza: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Control_Limpieza> BuscarParametrosControlLimpieza(string parametro, string valor)
        {
            List<Control_Limpieza> controlesLimpieza = new List<Control_Limpieza>();
            try
            {
                string query = $"SELECT * FROM Tb_Control_Limpieza WHERE {parametro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Control_Limpieza controlLimpieza = new Control_Limpieza(
                        (TimeSpan)reader["ControlLimpieza_Hora"],
                        Convert.ToInt32(reader["Empleado_Id"]),
                        Convert.ToInt32(reader["Locacion_Id"]),
                        Convert.ToDateTime(reader["ControlLimpieza_Fecha"])
                    );
                    controlLimpieza.ControlLimpieza_Id = Convert.ToInt32(reader["ControlLimpieza_Id"]);    
                    controlesLimpieza.Add(controlLimpieza);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar controles de limpieza por empleado: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return controlesLimpieza;
        }
    }
}
