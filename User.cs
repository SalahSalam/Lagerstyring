using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyring
{
    public class User
    {
        private int Id { get; }
        private string Name { get; set; }
        private string Role { get; set; }
    }
}
