using System.Reflection.Emit;
using System.Collections.Immutable;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

namespace PruebaTecnica.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Persona> Personas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<Usuario>(entityTypeBuilder =>{
    //        entityTypeBuilder.ToTable("Usuarios");

    //        entityTypeBuilder.Property(u =>u.Nombre)
    //         .HasMaxLength(100);
    //         entityTypeBuilder.Property(u =>u.)
    //          .HasDefaultValue(100);
    // });
    
    
    }

