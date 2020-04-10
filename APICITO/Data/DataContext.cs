using APICITO.Data.Entities;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICITO.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }


        public DataContext(DbContextOptions options) : base(options)
        {
        }

       
    }
}
