using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            ListaEnlazada lista = new ListaEnlazada();
            do
            {
                Console.WriteLine("  *___________________________* ");
                Console.WriteLine("  |      Menú de Opciones     |");
                Console.WriteLine("  |    1. Registrar Amigo     |");
                Console.WriteLine("  |     2. Mostrar Lista      |");
                Console.WriteLine("  |    3. Eliminar Amigo      |");
                Console.WriteLine("  |        4. Salir           |");
                Console.WriteLine("  *---------------------------*");
                Console.WriteLine("  Seleccione: ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        lista.Agregar();
                        break;
                    case 2:
                        lista.Mostrar();
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre del amigo a eliminar: ");
                        string b = Console.ReadLine();
                        if (lista.Eliminar(b))
                            Console.WriteLine("Amigo eliminado.");
                        else
                            Console.WriteLine("Amigo no encontrado.");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 4);
        
        }
    }
}
