using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Exercise01
{
    internal class WelcomeMessage : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return "Welcome! Today is: " + DateTime.Now.ToString("D");
        }
    }
}
