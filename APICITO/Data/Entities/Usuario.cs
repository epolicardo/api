using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICITO.Data.Entities
{
    public class Usuario
    {
        public DateTime FechaAlta { get; set; }

        public Persona Persona { get; set; }

    }
}
