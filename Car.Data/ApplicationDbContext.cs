using Car.Data.EntityModels;
using Car.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cooperation> Cooperations { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<Personal> Personals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.Relational().TableName = entity.Relational().TableName.ToSnakeCase();

                // Replace column names            
                foreach (var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = property.Name.ToSnakeCase();
                }

                foreach (var key in entity.GetKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.Relational().Name = index.Relational().Name.ToSnakeCase();
                }
            }

            #region Customer

            modelBuilder
               .Entity<Customer>()
               .HasOne(a => a.Personal);

            modelBuilder
                .Entity<Customer>()
                .HasOne(a => a.Cooperation);

            modelBuilder
                .Entity<Customer>()
                .HasOne(a => a.Government);

            #endregion

            #region Personal

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasOne(p => p.CustomerGroup);
                entity.HasOne(p => p.Title);
                entity.HasOne(p => p.Prospect);
                entity.HasOne(p => p.Source);
            });

            #endregion

            #region Cooperation

            modelBuilder
               .Entity<Cooperation>()
               .HasOne(a => a.Prospect );

            modelBuilder
               .Entity<Cooperation>()
               .HasOne(a => a.Vehicle);

            modelBuilder
               .Entity<Cooperation>()
               .HasOne(a => a.Source);

            #endregion

            #region Government

            modelBuilder
               .Entity<Government>()
               .HasOne(a => a.Prospect);

            modelBuilder
               .Entity<Government>()
               .HasOne(a => a.Vehicle);

            modelBuilder
               .Entity<Government>()
               .HasOne(a => a.Source);

            #endregion
        }
    }
}
