using System.Linq;

namespace Controller
{
    public static class Test
    {
        public static void Initialize()
        {
            var context = new Model.PolicyCenterContext();
            var marcas = context.Marca.ToList();

        }
    }
}
