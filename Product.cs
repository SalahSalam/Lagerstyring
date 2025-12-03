using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class Product
    {
        private int Productid { get; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string Category { get; set; }
        private decimal Price { get; set; }
        private int Minimumstock { get; set; }
    }
}
