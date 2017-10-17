using System;

namespace Model
{
    public class HistoriaBien
    {
        public int Id { get; set; }

        public int IdBien { get; set; }
        public Bien Bien { get; set; }

        public decimal Precio { get; set; }
        public DateTime Updated { get; set; }
    }
}