using Microsoft.EntityFrameworkCore;
namespace ProyectoApi.Models;

public class Conexiones : DbContext {
     public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Estudiantes> Estudiantes { get; set; } = null!;
    public DbSet<Tiposangre> Tiposangre { get; set; } = null!;

   
}
