using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week14Day3.Core.Entities;

namespace Week14Day3.RepositoryEF.Configurations
{
    public class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> builder)
        {
            builder.ToTable("Prodotti");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Codice).IsRequired();
            builder.Property(p => p.Descrizione).IsRequired();
            builder.Property(p => p.Tipologia);
            builder.Property(p => p.Prezzo);
            builder.Property(p => p.Costo);
        }

    }
}
