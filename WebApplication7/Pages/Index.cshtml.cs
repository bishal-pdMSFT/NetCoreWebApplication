using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication7.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }
        public void OnGet()
        {
            this.Title = MyStringConverter.Converter.ToUpper("My title");
        }
    }
}
