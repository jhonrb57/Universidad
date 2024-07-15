using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Universidad.Models;

namespace Universidad.Data
{
    public partial class UniversidadEntity : DbContext
    {
        public UniversidadEntity()
            : base("name=UniversidadEntity")
        {
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<MateriaEstudiante> MateriaEstudiante { get; set; }
        public virtual DbSet<MateriaProfesor> MateriaProfesor { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .HasMany(e => e.MateriaEstudiante)
                .WithRequired(e => e.Estudiante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.MateriaEstudiante)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.MateriaProfesor)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.MateriaProfesor)
                .WithRequired(e => e.Profesor)
                .WillCascadeOnDelete(false);
        }
    }
}
