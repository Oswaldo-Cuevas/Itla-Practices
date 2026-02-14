using System;

namespace First_Homework_Oswaldo.Entities
{
    public abstract class CommunityMember
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string DocumentoIdentidad { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public bool EstaActivo { get; set; }

        protected CommunityMember()
        {
            FechaRegistro = DateTime.Now;
            EstaActivo = true;
        }

        public virtual string ObtenerInformacionBasica()
        {
            return $"Nombre: {NombreCompleto} | Documento: {DocumentoIdentidad}";
        }
        public void Desactivar()
        {
            EstaActivo = false;
        }
    }
}