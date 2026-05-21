using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnfermeriaProject.EnfermeriaProyect.DataAcces.Data;

using EnfermeriaProject.Models.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Enfermero> Enfermeros { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Agendamiento> Agendamientos { get; set; }
}
