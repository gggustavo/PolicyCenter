namespace Model
{
    public class Persona
    {
        public Persona()
        {
            Activo = true;
        }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Cuit { get; set; }
        public string Cuil { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public int IdDireccion { get; set; }
        public Direccion Direccion { get; set; }
        public int IdLocalidad { get; set; }
        public Localidad Localidad { get; set; }
        public bool Activo { get; set; }
    }
}