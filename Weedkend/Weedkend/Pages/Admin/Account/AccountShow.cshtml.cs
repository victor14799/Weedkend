using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend
{
    public class AccountShowModel : PageModel
    {
        private readonly Weedkend.Models.MyContext _context;

        public AccountShowModel()
        {
            _context = new MyContext();
        }

        public IList<Account> Account { get; set; }

        //public async Task OnGetAsync()
        //{
        //    Account = await _context.Account
        //        .Include(a => a.RoleNavigation).ToListAsync();
        //}
        public Account AccountDelete { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            FullName = HttpContext.Session.GetString("username");
            Avatar = HttpContext.Session.GetString("img");
            Role = HttpContext.Session.GetString("role");
            ViewData["FullName"] = FullName;
            ViewData["Image"] = Avatar;

            if (Role != "admin")
            {
                return Redirect("/login");
            }

            if (string.IsNullOrEmpty(FullName))
            {
                return Redirect("/login");
            }

            if (Role == "admin")
            {
                Account = await _context.Account
              .Include(a => a.RoleNavigation).ToListAsync();
                return Page();

            }
            else return Redirect("/notAccess");

        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }
        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AccountDelete = await _context.Account.FindAsync(id);

            if (AccountDelete != null)
            {
                AccountDelete.Status = "Deactive";
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        public async Task<IActionResult> OnGetActiveAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AccountDelete = await _context.Account.FindAsync(id);

            if (AccountDelete != null)
            {
                AccountDelete.Status = "Active";
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }
}
