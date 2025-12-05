using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Inventoryitem
    {
        public int InventoryItemID { get; }
        public int ProductID { get; }
        public int LocationID { get; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }

        public Inventoryitem(int inventoryItemID, int productID, int locationID, int quantity, DateTime lastupdated) 
        {
            InventoryItemID = inventoryItemID;
            ProductID = productID;
            LocationID = locationID;
            Quantity = quantity;
            LastUpdated = lastupdated;
            if (quantity < 0) 
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
        }
        public void UpdateQuantity(int value)
        {
            if (Quantity + value < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
            Quantity = value;
            LastUpdated = DateTime.Now;
        }
    }
}
