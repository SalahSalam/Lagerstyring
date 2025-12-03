using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Orderline
    {
        private int OrderLineID { get; }
        private int OrderID { get; }
        private int ProductID { get; }
        private int Quantity { get; set; }
    }
}
