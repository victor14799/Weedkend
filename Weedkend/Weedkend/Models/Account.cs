using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Orders>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Role { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string ImgAvatar { get; set; }

        public Role RoleNavigation { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
