using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PersonasController
    {
        public IList<Model.Persona> ObtenerPersonas()
        {
            var context = Model.Context.GetInstance();
            return context.Persona.Include("Direccion").Include("Localidad").ToList();
        }


        public void AgregarPersona(Model.Persona persona)
        {
            var context = Model.Context.GetInstance();
            context.Persona.Add(persona);
            context.SaveChanges();
        }

        public void Eliminar(int idPersona)
        {
            var context = Model.Context.GetInstance();
            var person = context.Persona.Find(idPersona);
            person.Activo = false;
            context.Entry(person).State = System.Data.Entity.EntityState.Modified;            
            context.SaveChanges();
        }
    }
}
