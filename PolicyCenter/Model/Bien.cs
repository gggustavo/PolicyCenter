namespace Model
{
    public abstract class Bien
    {
        public int IdBien { get; set; }       
        public int IdRamo { get; set; }
        public Ramo Ramo { get; set; }

        public int Anio { get; set; }
        public decimal Precio { get; set; }
    }
}