using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend.Pages.WeedkendPage
{
    public class BrandsModel : PageModel
    {
        private readonly MyContext _context;

        public BrandsModel()
        {
            _context = new MyContext();
        }

        public IList<Weedkend.Models.Brand> Brands { get; set; }
        public void OnGet()
        {
            Brands = _context.Brand.ToList();
        }
    }
}