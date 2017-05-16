namespace Model
{
    public class Vehiculo : Bien
    {
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }

        public int IdModelo { get; set; }
        public Modelo Modelo { get; set; }

        public int IdVersion { get; set; }
        public Version Version { get; set; }

        
             
    }
}