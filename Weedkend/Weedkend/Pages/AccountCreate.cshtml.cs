using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Weedkend.Models;

namespace Weedkend
{
    public class AccountCreateModel : PageModel
    {
        private readonly Weedkend.Models.MyContext _context;

        public AccountCreateModel()
        {
            _context = new MyContext();
        }

        public string ImgURL { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                ViewData["Role"] = new SelectList(_context.Role, "RoleId", "RoleName");
                return Page();
            }
            catch
            {
                return Redirect("/error");
            }

        }

        [BindProperty]
        public Account Account { get; set; }

        public async Task<IActionResult> OnPostCreateAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                try
                {
                    Account.Role = 1;
                    Account.Status = "Active";
                    Account.ImgAvatar = @"\img\account_img\avatar.png";
                    _context.Account.Add(Account);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./login");
                }
                catch (Exception e)
                {
                    ViewData["Duplica"] = "Username has been exist !!!";
                    return Page();
                }
            }
            catch
            {
                return Redirect("/error");
            }




        }
    }
}