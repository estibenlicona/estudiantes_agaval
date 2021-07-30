using Newtonsoft.Json;
using System.Collections.Generic;
using Estudiante.Entidades;
using System.IO;

namespace Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiantes> estdiantes = JsonConvert.DeserializeObject<List<Estudiantes>>(File.ReadAllText(@"C:\Users\analistadesarrollo2\source\repos\Estudiante\Estudiante\Estudiantes.json"));
            
        }
    }
}
