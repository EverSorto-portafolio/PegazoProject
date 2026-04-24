namespace PEGAZO.Model
{
    public class Curriculo
    {
        public int Id { get; set; }
        public int  IdEstudiante { get; set; }
        public string CursosRealizado { get; set; }
        public string ExperienciaLaboral { get; set; }
        public string UrlFoto { get; set; }
        public string Idiomas { get; set; }
    }
}
