using System;
using APIMSLancamentos.Repository.Context.Model;
using Microsoft.EntityFrameworkCore;

namespace APIMSLancamentos.Repository.Context
{
    public class LancamentosContext : DbContext
    {
        public DbSet<Lancamentos> Lancamentos { get; set; }

        public LancamentosContext(DbContextOptions<LancamentosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}

