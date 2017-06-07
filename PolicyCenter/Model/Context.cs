using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Context
    {
        private static Model.PolicyCenterContext context = null;

        public static Model.PolicyCenterContext GetInstance()
        {
            return (context == null) ? new PolicyCenterContext() : context;            
        }
    }
}
