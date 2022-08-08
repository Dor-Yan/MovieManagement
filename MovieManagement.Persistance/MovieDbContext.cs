using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Common.Interfaces;
using MovieManagement.Domain.Common;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MovieManagement.Persistance
{
    public class MovieDbContext : DbContext, IMovieDbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DirectorBiography> DirectorBiographies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // przeszukuje assembly w celu znalezienia konfiguracji
            //można ew wskazać pliki z konfiguracją - .ApplyConfiguration
            
            modelBuilder.SeedData();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = String.Empty;
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = String.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = String.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
