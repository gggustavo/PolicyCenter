namespace Model
{
    public class Version
    {
        public int IdVersion { get; set; }
        public string Nombre { get; set; }

        public Modelo Modelo { get; set; }
        public int IdModelo { get; set; }
    }
}