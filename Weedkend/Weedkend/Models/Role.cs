using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Role
    {
        public Role()
        {
            Account = new HashSet<Account>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
