using System.Collections.Generic;

namespace Model
{
    public class Organizador
    {
        public int IdOrganizador { get; set; }
        public string Nombre { get; set; }

        public int IdProductor { get; set; }
        public ICollection<Productor> Productores { get; set; }
    }
}