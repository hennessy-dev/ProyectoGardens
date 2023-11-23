using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class Empleado
{
    public int CodigoEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidol { get; set; } = null!;

    public string? Apellid02 { get; set; }

    public string Extension { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CodigoOficina { get; set; } = null!;

    public int? CodigoJefe { get; set; }

    public string? Puesto { get; set; }

    public virtual ICollection<Cliente> Clientes { get; } = new List<Cliente>();

    public virtual Empleado? CodigoJefeNavigation { get; set; }

    public virtual Oficina CodigoOficinaNavigation { get; set; } = null!;

    public virtual ICollection<Empleado> InverseCodigoJefeNavigation { get; } = new List<Empleado>();
}
