using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Persistance.Configuartions
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            // w ten sposób (.OwnsOne) konfigurujemy prop, które zostały wyciągnięte do ValueObjects
            builder.OwnsOne(p => p.DirectorName).Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
            builder.OwnsOne(p => p.DirectorName).Property(p => p.LastName).HasColumnName("LastName").IsRequired();
        }
    }
}
