using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Concentrado> Concentrado { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<GradoSeccion> GradoSeccion { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<Imagen> image { get; set; }
      
    
    }
}
