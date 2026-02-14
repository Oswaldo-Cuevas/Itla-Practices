namespace First_Homework_Oswaldo.Entities
{
    public class Alumni : CommunityMember
    {
        public string CarreraGraduada { get; set; }
        public int AnioGraduacion { get; set; }

        public string ObtenerCertificado()
        {
            return $"Certificado de graduación: {CarreraGraduada} ({AnioGraduacion})";
        }
    }
}