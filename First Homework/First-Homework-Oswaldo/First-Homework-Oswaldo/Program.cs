using System;
using First_Homework_Oswaldo.Entities;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            NombreCompleto = "Oswaldo Cuevas",
            DocumentoIdentidad = "001-1234567-8",
            Matricula = "2024-0015",
            Carrera = "Desarrollo de Software",
            Semestre = 3
        };

        Console.WriteLine(student.ObtenerInformacionBasica());
        student.Inscribirse();

        Professor professor = new Professor
        {
            NombreCompleto = "Dra. María López",
            Asignatura = "Programación",
            HorasSemanales = 10
        };

        professor.ImpartirClase();
        Console.WriteLine($"Salario: {professor.CalcularSalario()}");
    }
}