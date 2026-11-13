using CRUD_Modulo9.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Modulo9.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {


    }
    public DbSet<Empleado> Empleado { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Empleado>(entity =>
    //    {
    //        entity.ToTable("Empleado");
    //        entity.HasKey(e => e.IdEmpleado);
    //    });
    //}

}
