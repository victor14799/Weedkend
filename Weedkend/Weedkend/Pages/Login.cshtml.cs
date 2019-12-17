using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weedkend.Models;

namespace Weedkend
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPostLogin(string username, string password)
        {
            using (var context = new MyContext())
            {
                var user = context.Set<Account>().FirstOrDefault(u => (u.UserName == username || u.Email == username) && u.Password == password && u.Status.Equals("active"));

                if (user == null)
                {
                    TempData["ERROR"] = "Username or password is incorrect!";
                    return Page();
                }
                else
                {
                    var role = context.Set<Role>().FirstOrDefault(r => r.RoleId == user.Role);
                    HttpContext.Session.SetString("fullname", user.UserName);
                    HttpContext.Session.SetString("username", user.FullName);
                    HttpContext.Session.SetString("role", role.RoleName);
                    HttpContext.Session.SetString("img", user.ImgAvatar);

                    if (role.RoleName == "admin")
                    {
                        return Redirect("/viewOrder");
                    }
                    else return Redirect("/");
                }
            }
        }

        public IActionResult OnPostLogout()
        {
            HttpContext.Session.Clear();
            return Redirect("/login");
        }

    }
}