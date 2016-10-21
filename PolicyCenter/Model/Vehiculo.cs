using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public int IdVersion { get; set; }
        public Version Version { get; set; }
        public string Anio { get; set; }
        public string Patente { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
    }
}