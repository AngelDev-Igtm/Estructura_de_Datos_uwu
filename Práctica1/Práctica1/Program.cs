using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.Clear();
            do
            {
                Console.WriteLine("  *___________________________* ");
                Console.WriteLine("  |      Menú de Opciones     |");
                Console.WriteLine("  |   1. Registrar Alumno     |");
                Console.WriteLine("  |     2. Mostrar Lista      |");
                Console.WriteLine("  | 3. N° Alumnos Registrados |");
                Console.WriteLine("  |        4. Salir           |");
                Console.WriteLine("  *---------------------------*");
                Console.WriteLine("  Seleccione: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Opciones.RegistrarAlumno();
                        break;
                    case 2:
                        Opciones.MostrarLista();
                        break;
                    case 3:
                        Opciones.ContarAlumnos();
                        break;
                }
            } while (opcion != 4);

        }

    }
}
