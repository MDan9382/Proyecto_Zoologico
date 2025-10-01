using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Jaulas
    {
        public int Jaula_Id { get; set; }
        public string Jaula_Ambiente { get; set; }
        public float Jaula_Area { get; set; }
        public int Locacion_Id { get; set; }
        public int Animal_Id { get; set; }

        public Jaulas(string jaula_Ambiente, float jaula_Area, int locacion_Id, int animal_Id)
        {            
            Jaula_Ambiente = jaula_Ambiente;
            Jaula_Area = jaula_Area;
            Locacion_Id = locacion_Id;
            Animal_Id = animal_Id;
        }
    }
}
