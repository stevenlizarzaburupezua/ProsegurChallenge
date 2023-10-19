using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Prosegur.GAP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Repository.Context
{
    public class GAPDBContext : DbContext
    {
        public GAPDBContext(DbContextOptions<GAPDBContext> options) : base(options)
        {
        }

        public DbSet<Usuario> USUARIO => Set<Usuario>();
        public DbSet<Rol> ROL => Set<Rol>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected virtual void DbSeed(ModelBuilder builder) { }
    }
}
