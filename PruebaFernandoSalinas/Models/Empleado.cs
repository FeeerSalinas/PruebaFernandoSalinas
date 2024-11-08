using System;
using System.Collections.Generic;

namespace PruebaFernandoSalinas.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string NombreEmpleado { get; set; } = null!;

    public string ApellidoEmpleado { get; set; } = null!;

    public string EdadEmpleado { get; set; } = null!;

    public string DireccionEmpleado { get; set; } = null!;

    public string NumeroTelefono { get; set; } = null!;

    public string EmailEmpleado { get; set; } = null!;
}
