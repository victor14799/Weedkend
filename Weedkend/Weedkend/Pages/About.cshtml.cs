using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weedkend.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
            double TotalPrice = Models.SessionExtensions.Get<double>(HttpContext.Session, "total");
            ViewData["Total"] = TotalPrice.ToString("#,###");
        }
    }
}
