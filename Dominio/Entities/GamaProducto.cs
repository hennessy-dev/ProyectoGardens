using System;
using System.Collections.Generic;

namespace Persistencia;

public partial class GamaProducto
{
    public string Gama { get; set; } = null!;

    public string? DescripcionTexto { get; set; }

    public string? DescripcionHtml { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
