using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuarios>().HasKey(a => a.UsuarioId);

            modelBuilder.Entity<Usuarios>().Property(x => x.Usuario)
                      .HasMaxLength(50)
                      .IsRequired();
            modelBuilder.Entity<Usuarios>().Property(x => x.Contrasena)
                    .HasMaxLength(50)
                    .IsRequired();
            modelBuilder.Entity<Usuarios>().Property(x => x.CorreoElectronico)
                   .HasMaxLength(50)
                   .IsRequired();
            modelBuilder.Entity<Usuarios>().Property(x => x.Estatus)
                   .IsRequired();
            modelBuilder.Entity<Usuarios>().Property(x => x.Sexo)
                  .IsRequired();
            modelBuilder.Entity<Usuarios>().Property(x => x.FechaCreacion)
                  .IsRequired();
        }
    }
}
