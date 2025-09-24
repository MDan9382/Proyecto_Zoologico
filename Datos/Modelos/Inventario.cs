using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Inventario
    {
        public int Inventario_Id { get; set; }
        public string Inventario_Nombre { get; set; }
        public string Inventario_Tipo { get; set; }
        public int Inventario_Cantidad { get; set; }
      //  public Inventario() { }

        public Inventario(string inventario_Nombre, string inventario_Tipo, int inventario_Cantidad)
        {
            Inventario_Nombre = inventario_Nombre;
            Inventario_Tipo = inventario_Tipo;
            Inventario_Cantidad = inventario_Cantidad;
        }
    }
}
