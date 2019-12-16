using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weedkend.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        [DisplayName("Tên khách hàng")]
        public string FullName { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        public string ShipAddress { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNo { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
