
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CinemaApp.Models;



namespace CinemaApp
{
    public class SinemaDbContext : DbContext
    {
        public SinemaDbContext() : base("name=SinemaDbConnection") { }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Film>().ToTable("Film");
            modelBuilder.Entity<Salon>().ToTable("Salon");
            modelBuilder.Entity<Seans>().ToTable("Seans");
            modelBuilder.Entity<Rezervasyon>().ToTable("Rezervasyon");
            modelBuilder.Entity<Film>()
                        .HasKey(s => s.FilmId)
                        .Property(e => e.Ad)
                        .HasColumnName("Ad")
                        .HasColumnType("TEXT");

                        

            modelBuilder.Entity<Seans>()
                        .HasRequired(s => s.Film)
                        .WithMany(f => f.Seanslar)
                        .HasForeignKey(s => s.FilmId);

            modelBuilder.Entity<Seans>()
                        .HasRequired(s => s.Salon)
                        .WithMany(s => s.Seanslar)
                        .HasForeignKey(s => s.SalonId);

            modelBuilder.Entity<Rezervasyon>()
                        .HasRequired(r => r.Seans)
                        .WithMany(s => s.Rezervasyonlar)
                        .HasForeignKey(r => r.SeansId)
                        .WillCascadeOnDelete(false);
        }
    }
}