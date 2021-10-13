﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Razor_Currency_Converter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        private string FullName { get; set; }

        public readonly ILogger<IndexModel> _logger;

        [BindProperty]
        private string Value { get; set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Mohammed";
        }

        public void OnPost()
        {
            if(string.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "Name is registered!";
            }
        }
    }
}