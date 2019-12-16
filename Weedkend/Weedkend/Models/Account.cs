using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weedkend.Models
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Orders>();
        }
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        public int Role { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 10, MinimumLength = 10,ErrorMessage ="Phone must have 10 number")]
        public string PhoneNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
         public string Address { get; set; }
        public string Status { get; set; }
        public string ImgAvatar { get; set; }

        public Role RoleNavigation { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
