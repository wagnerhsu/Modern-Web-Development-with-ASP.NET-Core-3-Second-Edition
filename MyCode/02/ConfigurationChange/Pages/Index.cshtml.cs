using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConfigurationChange.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        IConfiguration _configuration;
        WagnerLogConfig _wagnerLogConfig;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration, IOptions<WagnerLogConfig> options)
        {
            _logger = logger;
            _configuration = configuration;
            _wagnerLogConfig = options.Value;
        }

        public string LogDefaultLevel { get; set; }
        public void OnGet()
        {
            _logger.LogInformation(_configuration["Wagner:Default"]);
            LogDefaultLevel = _wagnerLogConfig.Default;
        }
    }
}
