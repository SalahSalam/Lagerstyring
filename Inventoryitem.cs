using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Inventoryitem
    {
        private int InventoryItemID { get; }
        private int ProductID { get; }
        private int Locationid { get; }
        private int Quantity { get; set; }
        private DateTime LastUpdated { get; set; }
    }
}
