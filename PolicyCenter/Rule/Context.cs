using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public static class Context
    {
        private static RuleContext context = null;

        public static RuleContext GetInstance()
        {
            return (context == null) ? new RuleContext() : context;            
        }
    }
}
