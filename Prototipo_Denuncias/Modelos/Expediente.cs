using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo_Denuncias
{
    public class Expediente
    {
        public string Codigo { get; set; }
        public string FechaRegistro { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Categoria { get; set; }
        public string Distrito { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
