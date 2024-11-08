using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaFernandoSalinas.Models;

public partial class EmpleadosContext : DbContext
{
    public EmpleadosContext()
    {
    }

    public EmpleadosContext(DbContextOptions<EmpleadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__empleado__5295297C09805FAC");

            entity.ToTable("empleados");

            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.ApellidoEmpleado)
                .HasColumnType("text")
                .HasColumnName("apellidoEmpleado");
            entity.Property(e => e.DireccionEmpleado)
                .HasColumnType("text")
                .HasColumnName("direccionEmpleado");
            entity.Property(e => e.EdadEmpleado)
                .HasColumnType("text")
                .HasColumnName("edadEmpleado");
            entity.Property(e => e.EmailEmpleado)
                .HasColumnType("text")
                .HasColumnName("emailEmpleado");
            entity.Property(e => e.NombreEmpleado)
                .HasColumnType("text")
                .HasColumnName("nombreEmpleado");
            entity.Property(e => e.NumeroTelefono)
                .HasColumnType("text")
                .HasColumnName("numeroTelefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
