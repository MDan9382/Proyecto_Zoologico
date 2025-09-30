using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.DAO
{
    internal class Control_TiempoDAO
    {
        MySqlConnection conexion = new MySqlConnection(ConexionSQL.cadenaConexion);
        public void AgregarControlTiempo(Control_Tiempo controlTiempo)
        {
            try
            {
                string query = "INSERT INTO Tb_Control_Tiempo (ControlTiempo_Inicio, ControlTiempo_Fin, ControlTiempo_Tipo, Empleado_Id) " +
                               "VALUES (@Inicio, @Fin, @Tipo, @EmpleadoId)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Inicio", controlTiempo.ControlTiempo_Inicio);
                cmd.Parameters.AddWithValue("@Fin", controlTiempo.ControlTiempo_Fin);
                cmd.Parameters.AddWithValue("@Tipo", controlTiempo.ControlTiempo_Tipo);
                cmd.Parameters.AddWithValue("@EmpleadoId", controlTiempo.Empleado_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar control de tiempo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<Control_Tiempo> ObtenerControlesTiempo()
        {
            List<Control_Tiempo> controlesTiempo = new List<Control_Tiempo>();
            try
            {
                string query = "SELECT * FROM Tb_Control_Tiempo";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Control_Tiempo controlTiempo = new Control_Tiempo(
                        Convert.ToDateTime(reader["ControlTiempo_Inicio"]),
                        Convert.ToDateTime(reader["ControlTiempo_Fin"]),
                        reader["ControlTiempo_Tipo"].ToString(),
                        Convert.ToInt32(reader["Empleado_Id"])
                    );
                    controlTiempo.ControlTiempo_Id = Convert.ToInt32(reader["ControlTiempo_Id"]);
                    controlesTiempo.Add(controlTiempo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener controles de tiempo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return controlesTiempo;
        }

        public void ActualizarControlTiempo(Control_Tiempo controlTiempo)
        {
            try
            {
                string query = "UPDATE Tb_Control_Tiempo SET ControlTiempo_Inicio = @Inicio, ControlTiempo_Fin = @Fin, " +
                               "ControlTiempo_Tipo = @Tipo, Empleado_Id = @EmpleadoId WHERE ControlTiempo_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Inicio", controlTiempo.ControlTiempo_Inicio);
                cmd.Parameters.AddWithValue("@Fin", controlTiempo.ControlTiempo_Fin);
                cmd.Parameters.AddWithValue("@Tipo", controlTiempo.ControlTiempo_Tipo);
                cmd.Parameters.AddWithValue("@EmpleadoId", controlTiempo.Empleado_Id);
                cmd.Parameters.AddWithValue("@Id", controlTiempo.ControlTiempo_Id);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar control de tiempo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void EliminarControlTiempo(int controlTiempoId)
        {
            try
            {
                string query = "DELETE FROM Tb_Control_Tiempo WHERE ControlTiempo_Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", controlTiempoId);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar control de tiempo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Control_Tiempo> BuscarParametrosControlTiempo(string paramatro, string valor)
        {
            List<Control_Tiempo> controlesTiempo = new List<Control_Tiempo>();
            try
            {
                string query = $"SELECT * FROM Tb_Control_Tiempo WHERE {paramatro} = @valor";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@valor", valor);
                conexion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Control_Tiempo controlTiempo = new Control_Tiempo(
                        Convert.ToDateTime(reader["ControlTiempo_Inicio"]),
                        Convert.ToDateTime(reader["ControlTiempo_Fin"]),
                        reader["ControlTiempo_Tipo"].ToString(),
                        Convert.ToInt32(reader["Empleado_Id"])
                    );
                    controlTiempo.ControlTiempo_Id = Convert.ToInt32(reader["ControlTiempo_Id"]);
                    controlesTiempo.Add(controlTiempo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener controles de tiempo: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return controlesTiempo;
        }

    }
}
