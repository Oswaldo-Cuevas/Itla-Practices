using System;

namespace First_Homework_Oswaldo.Entities
{
    public class Administrator : Employee
    {
        public string AreaAdministrativa { get; set; }

        public void GestionarSistema()
        {
            Console.WriteLine("Gestionando procesos administrativos del sistema.");
        }
    }
}