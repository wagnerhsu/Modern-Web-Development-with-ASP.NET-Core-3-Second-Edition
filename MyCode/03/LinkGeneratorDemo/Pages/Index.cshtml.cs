using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace LinkGeneratorDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var endpoint = this.HttpContext.GetEndpoint();
            var name = endpoint.DisplayName;
            _logger.LogDebug(JsonSerializer.Serialize(name));
            var dataToken = endpoint.Metadata.GetMetadata<IDataTokensMetadata>();
        }
    }
}
