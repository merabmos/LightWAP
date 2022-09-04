using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Customer
{
    public class Customer : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
