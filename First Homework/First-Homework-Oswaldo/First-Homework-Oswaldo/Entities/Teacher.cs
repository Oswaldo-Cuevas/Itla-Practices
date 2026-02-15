namespace First_Homework_Oswaldo.Entities
{
    public abstract class Teacher : Employee
    {
        public string Asignatura { get; set; }
        public int HorasSemanales { get; set; }

        public override decimal CalcularSalario()
        {
            return HorasSemanales * 500;
        }
    }
}