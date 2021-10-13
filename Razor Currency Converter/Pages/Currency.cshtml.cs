using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Currency_Converter.Pages
{
    public class CurrencyModel : PageModel
    {
        [BindProperty]
        public string Value { get; set; }

        public void OnGet()
        {
        }
    }
}
