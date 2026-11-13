using System.ComponentModel.DataAnnotations;

namespace CRUD_Modulo9.Entities;

public class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }
    public string? NumeroDocumento { get; set; }
    public string? NombreCompleto { get; set; } = "";
    public int? Sueldo { get; set; }
}
