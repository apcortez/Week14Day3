using Microsoft.EntityFrameworkCore;
using System;
using Week14Day3.Core.Entities;
using Week14Day3.RepositoryEF.Configurations;

namespace Week14Day3.RepositoryEF
{
    public class ProdottoContext : DbContext
    {
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Utente> Utenti { get; set; }
        public ProdottoContext()
        {

        }

        public ProdottoContext(DbContextOptions<ProdottoContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		                                Database=Amazon;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Prodotto>(new ProdottoConfiguration());
            modelBuilder.ApplyConfiguration<Utente>(new UtenteConfiguration());
        }
    }
}
