namespace Model
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int? Piso { get; set; }
        public string Departamento { get; set; }
    }
}