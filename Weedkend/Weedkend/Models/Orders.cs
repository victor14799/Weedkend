using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weedkend.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public string UserName { get; set; }
        public DateTime Datetime { get; set; }

        public Customer Customer { get; set; }
        public Account UserNameNavigation { get; set; }
        public ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
