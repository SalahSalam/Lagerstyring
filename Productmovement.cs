using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Productmovement
    {
        private int Movementid { get; }
        private int Productid { get; set; }
        private int Userid { get; set; }
        private int Quantity { get; set; }
        private Type Movementtype { get; set; }
        private DateTime Timestamp { get; set; }
    }
}
