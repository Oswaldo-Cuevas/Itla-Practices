using System;

namespace First_Homework_Oswaldo.Entities
{
    public class Professor : Teacher
    {
        public string NivelEducativo { get; set; }

        public void ImpartirClase()
        {
            Console.WriteLine($"Impartiendo la asignatura {Asignatura}");
        }
    }
}