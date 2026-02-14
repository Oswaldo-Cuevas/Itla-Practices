using System;

namespace First_Homework_Oswaldo.Entities
{
    public class AdministrativeStaff : Employee
    {
        public string Departamento { get; set; }

        public void RealizarTramite()
        {
            Console.WriteLine("Realizando trámite administrativo.");
        }
    }
}