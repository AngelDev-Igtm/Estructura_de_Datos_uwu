using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    public class Alumno
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string[,] Notas { get; set; } = new string [2, 3];
        public Alumno Siguiente { get; set; }
    }
}
