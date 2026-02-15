using System;

namespace First_Homework_Oswaldo.Entities
{
    public abstract class Employee : CommunityMember
    {
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public DateTime FechaIngreso { get; set; }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}