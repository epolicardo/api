using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersAPI.Modelos
{
    public class User : IdentityUser
    {
        public Persona Persona { get; set; }
    }
}
