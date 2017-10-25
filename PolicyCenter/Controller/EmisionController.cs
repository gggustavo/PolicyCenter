using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EmisionController
    {

        public IEnumerable<Model.Poliza> ObtenerEmisiones()
        {
            var context = Model.Context.GetInstance();
            return context.Poliza.ToList();
        }


        public void Emision(Model.Poliza poliza)
        {
            var context = Model.Context.GetInstance();

            poliza.Persona = null;
            poliza.Bien = null;

            poliza.Guid = Guid.NewGuid().ToString();
            poliza.IdentificadorPoliza = poliza.IdProductor.ToString("0000000") + poliza.IdBien.ToString("0000000") + poliza.IdPersona.ToString("0000000");

            context.Poliza.Add(poliza);
            context.SaveChanges();
        }
    }
}
