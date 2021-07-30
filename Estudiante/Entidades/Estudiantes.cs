using System;
using System.Collections.Generic;
using System.Text;

namespace Estudiante.Entidades
{
    public class Estudiantes
    {

        public string Documento { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public List<Materia> Materias { get; set; }
    }
}
