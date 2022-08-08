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
    public class MovieConfiguartion : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(p => p.Id); // gdyby nie było Id w entity to tak należy wskazać klucz główny

            builder.Property(p => p.Name).HasMaxLength(300).IsRequired();

            builder.Property(p => p.PremiereYear).HasDefaultValue(2000);
        }
    }
}
