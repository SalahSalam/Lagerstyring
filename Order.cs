using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Order
    {
        private int OrderID { get;  }
        private DateTime CreatedAt { get; set; }
        private enum OrderStatus
        {
            Open,
            Closed,
            Sent
        }
        private OrderStatus Status { get; set; } 
    }
}
