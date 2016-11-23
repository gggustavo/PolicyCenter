namespace Model
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }

        public int IdModelo { get; set; }
        public Modelo Modelo { get; set; }

        public int IdVersion { get; set; }
        public Version Version { get; set; }

        public string Anio { get; set; }        
        public decimal Precio { get; set; }        
    }
}