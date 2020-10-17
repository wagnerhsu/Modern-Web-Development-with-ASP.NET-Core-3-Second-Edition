using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPage01.Pages
{
    public class IndexModel : PageModel
    {
        ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public PersonModel Person { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Hello, World";
            Person = new PersonModel();
            Person.Email = "wagnerhsu@hotmail.com";
            Person.Name = "Wagner Xu";
        }

        public IActionResult OnPostOne()
        {
            _logger.LogInformation($"{Person.Email}:{Person.Name} for PostOne");
            return RedirectToPage("Shared/Success");
        }
        public IActionResult OnPostTwo()
        {
            _logger.LogInformation($"{Person.Email}:{Person.Name} for PostTwo");
            return RedirectToPage("Success");
        }
        public IActionResult OnPostThree(string foo)
        {
            _logger.LogInformation($"{foo} for PostThree");
            return RedirectToPage("Success");
        }
    }
}
