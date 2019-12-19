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
    public class AccountProfileModel : PageModel
    {
        private readonly Weedkend.Models.MyContext _context;

        public AccountProfileModel()
        {
            _context = new MyContext();
        }
        public List<SelectListItem> roles { get; set; }

        [BindProperty]
        public Account Account { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Role { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                FullName = HttpContext.Session.GetString("username");
                Avatar = HttpContext.Session.GetString("img");
                Role = HttpContext.Session.GetString("role");

                ViewData["FullName"] = FullName;
                ViewData["Image"] = Avatar;
                string id = HttpContext.Session.GetString("fullname");
                if (id == null)
                {
                    return NotFound();
                }

                Account = await _context.Account
                    .Include(a => a.RoleNavigation).FirstOrDefaultAsync(m => m.UserName == id);
                ViewData["Role"] = new SelectList(_context.Role, "RoleId", "RoleName");
                if (Account == null)
                {
                    return NotFound();
                }

                roles = _context.Role.Select(r => new SelectListItem
                {
                    Value = r.RoleId.ToString(),
                    Text = r.RoleName
                }).ToList();
                ViewData["Role"] = roles;
                return Page();
            }
            catch
            {
                return Redirect("Error");
            }

        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            FullName = HttpContext.Session.GetString("username");
            Avatar = HttpContext.Session.GetString("img");
            Role = HttpContext.Session.GetString("role");
            ViewData["Role"] = new SelectList(_context.Role, "RoleId", "RoleName");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var img = @"\img\account_img\" + Account.ImgAvatar;
            Account.ImgAvatar = img;
            Account.Status = "Active";

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

            return Page();
        }


    }
}
