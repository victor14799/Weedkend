using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public Guid OrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public string UserName { get; set; }
        public DateTime Datetime { get; set; }

        public Customer Customer { get; set; }
        public Account UserNameNavigation { get; set; }
        public ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
