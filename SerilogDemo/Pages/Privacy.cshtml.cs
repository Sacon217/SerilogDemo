using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SerilogDemo.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger _logger;

        public PrivacyModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("SeriLogger");
        }

        public void OnGet()
        {
        }
    }
}
