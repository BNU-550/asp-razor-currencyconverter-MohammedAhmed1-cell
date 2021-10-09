using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Currency_Converter.Pages.Shared
{
    public class CurrencyConverterModel : PageModel
    {
        [BindProperty]
        public double Amount { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
