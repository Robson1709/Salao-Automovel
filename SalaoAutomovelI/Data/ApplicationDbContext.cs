using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalaoAutomovelI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoAutomovelI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Carro> Carros { get; set; }
    }
}
