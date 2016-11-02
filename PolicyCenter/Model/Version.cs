using System.Collections.Generic;
namespace Model
{
    public class Version
    {
        public int IdVersion { get; set; }
        public string Nombre { get; set; }
        
        public ICollection<Modelo> Models { get; set; }
    }
}