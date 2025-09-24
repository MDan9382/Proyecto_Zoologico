using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Animales
    {
        public int Animal_Id { get; set; }
        public string Animal_Especie { get; set; }
        public float Animal_Tamaño { get; set; }
        public float Animal_Peso { get; set; }
        public int Alimentacion_Id { get; set; }

        public Animales (string animal_Especie, float animal_Tamaño, float animal_Peso, int animal_Alimentacion)
        {
            Animal_Especie = animal_Especie;
            Animal_Tamaño = animal_Tamaño;
            Animal_Peso = animal_Peso;
            Alimentacion_Id = animal_Alimentacion;
        }
    }
}
