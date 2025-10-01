using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Animales
    {
        public int Animal_Id { get; set; }
        public string Animal_Especie { get; set; }
        public float Animal_Tamaño { get; set; }
        public float Animal_Peso { get; set; }
        public string Animal_Dieta { get; set; }

        public Animales (string animal_Especie, float animal_Tamaño, float animal_Peso, string animal_Dieta)
        {
            Animal_Especie = animal_Especie;
            Animal_Tamaño = animal_Tamaño;
            Animal_Peso = animal_Peso;
            Animal_Dieta = animal_Dieta;
        }
    }
}
