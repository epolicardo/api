using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Modelos;

namespace UsersAPI.Data
{
    public class DataContext : IdentityDbContext<User>
    {


        public DbSet<Persona> Personas { get; set; }

        public DataContext(DbContextOptions<DataContext> options ):base (options)
        {

        }
    }
}
