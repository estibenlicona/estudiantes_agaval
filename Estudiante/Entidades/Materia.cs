using System;
using System.Collections.Generic;
using System.Text;

namespace Estudiante.Entidades
{
    public class Materia
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public List<Nota> Notas { get; set; }

    }
}
