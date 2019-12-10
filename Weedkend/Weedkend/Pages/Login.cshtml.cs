using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                var user = context.Set<Account>().FirstOrDefault(u => u.UserName == username && u.Password == password && u.Status.Equals("active"));
                var role = context.Set<Role>().FirstOrDefault(r => r.RoleId == user.Role);
                if (user == null)
                {
                    TempData["ERROR"] = "Invalid username password!";
                    return Page();
                }
                else if (role.RoleName.Equals("admin"))
                {
                    return Redirect("/homeadmin");
                }
                else return Redirect("/homepage");
            }
        }
    }
}