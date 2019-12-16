﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weedkend.Models
{
    public partial class OrdersDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã đơn hàng")]
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        [DisplayName("Giá Sản phẩm")]
        public double UnitPrice { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        public Orders Order { get; set; }
        public Product Product { get; set; }

        public double GetTotal() { return UnitPrice * Quantity; }

    }
}
