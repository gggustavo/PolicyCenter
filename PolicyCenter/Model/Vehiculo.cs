namespace Model
{
    public class Vehiculo
    {        
        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public string Anio { get; set; }
        public string Patente { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
    }
}