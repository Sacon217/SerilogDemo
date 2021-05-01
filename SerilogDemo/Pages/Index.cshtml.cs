using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("SeriLogger");
            
        }

        public void OnGet()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 55)
                    {
                        throw new Exception("El valor de i es 55 y no pudo sumar mas.");
                    }
                    else
                    {
                        _logger.LogInformation("El valor de i es: {VariableFor}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "No se completo toda la iteracion del for");
            }
        }
    }
}
