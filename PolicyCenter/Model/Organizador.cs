using System.Collections.Generic;

namespace Model
{
    public class Organizador
    {
        public int IdOrganizador { get; set; }
        public string Nombre { get; set; }

        public int IdProductor { get; set; }
        public Productor Productores { get; set; }
    }
}