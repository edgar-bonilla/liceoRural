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
        public DbSet<Docente> Docente { get; set; }
    }
}
