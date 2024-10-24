using System.ComponentModel.DataAnnotations;

namespace ProyectoApi.Models;

public class Estudiantes{
    [Key]
    public Int32 Id_estudiante { get; set; }
    public string? Carne { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public string? Correo_electronico { get; set; }
    public DateTime? Fecha_nacimiento { get; set; }

}