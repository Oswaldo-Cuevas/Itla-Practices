using System;

namespace First_Homework_Oswaldo.Entities
{
    public class Student : CommunityMember
    {
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }

        public void Inscribirse()
        {
            Console.WriteLine("El estudiante ha sido inscrito correctamente.");
        }

        public override string ObtenerInformacionBasica()
        {
            return base.ObtenerInformacionBasica() +
                   $" | Matrícula: {Matricula} | Carrera: {Carrera}";
        }
    }
}