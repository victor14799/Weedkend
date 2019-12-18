using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Weedkend.Models;

namespace Weedkend
{
    public class AccountEditModel : PageModel
    {
        private readonly Weedkend.Models.MyContext _context;

        public AccountEditModel()
        {
            _context = new MyContext();
        }

        [BindProperty]
        public Account Account { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            try
            {
                FullName = HttpContext.Session.GetString("username");
                Avatar = HttpContext.Session.GetString("img");
                Role = HttpContext.Session.GetString("role");
                ViewData["username"] = id;
                ViewData["FullName"] = FullName;
                ViewData["Image"] = Avatar;
                if (id == null)
                {
                    return NotFound();
                }

                Account = await _context.Account
                    .Include(a => a.RoleNavigation).FirstOrDefaultAsync(m => m.UserName == id);

                if (Account == null)
                {
                    return NotFound();
                }
                ViewData["Role"] = new SelectList(_context.Role, "RoleId", "RoleName");
                return Page();
            }
            catch
            {
                return Redirect("/error");
            }



        }
        public IActionResult OnGetLogout()
        {
            try
            {
                HttpContext.Session.Clear();
                return Redirect("/login");
            }
            catch
            {
                return Redirect("/error");
            }

        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            try
            {
                ViewData["Role"] = new SelectList(_context.Role, "RoleId", "RoleName");
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                var img = @"\img\account_img\" + Account.ImgAvatar;
                Account.ImgAvatar = img;
                _context.Attach(Account).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    ViewData["error"] = "Edit Account Fail !!!";
                    return Page();
                }

                return RedirectToPage("./AccountShow");
            }
            catch
            {
                return Redirect("/error");
            }

        }


    }
}
