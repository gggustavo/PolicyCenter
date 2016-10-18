namespace Model
{
    public class Productor
    {
        public int IdProductor { get; set; }
        public string Nombre { get; set; }

        public int IdOrganizador { get; set; }
        public Organizador Organizador { get; set; }
    }
}