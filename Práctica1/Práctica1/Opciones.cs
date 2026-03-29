using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    public class Opciones
    {
        public static Alumno cabecera = null;
        public static Random rnd = new Random();

        public static void RegistrarAlumno()
        {
            //Usuario
            Alumno nuevo = new Alumno();
            Console.WriteLine(" Ingrese Nombres y Apellidos: ");
            nuevo.Nombres = Console.ReadLine();

            //Edad
            Console.WriteLine(" Ingrese Edad: ");
            nuevo.Edad = int.Parse(Console.ReadLine());

            //Código
            nuevo.Codigo = "N" + rnd.Next(1000, 10000) + "P";

            //Correo
            string[] partes = nuevo.Nombres.ToLower().Split(' ');
            string correo = partes[0];
            for (int i = 1; i < partes.Length; i++)
            {
                correo += partes[i][0];
            }
            nuevo.Correo = correo + "@upn.pe";

            //Notas
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Nombre del curso: {i + 1}: ");
                nuevo.Notas[i, 0] = Console.ReadLine();
                Console.WriteLine(" Nota 1: ");
                nuevo.Notas[i, 1] = Console.ReadLine();
                Console.WriteLine(" Nota 2: ");
                nuevo.Notas[i, 2] = Console.ReadLine();
            }

            //Método de Insertar al Final de una Lista
            if (cabecera == null)
            {
                cabecera = nuevo;
            }
            else
            {
                Alumno temporal = cabecera;
                while (temporal.Siguiente != null)
                {
                    temporal = temporal.Siguiente;
                }
                temporal.Siguiente = nuevo;
            }
            Console.WriteLine(" Alumno registrado con éxito!!");

        }
        public static void MostrarLista()
        {
            Alumno temporal = cabecera;
            while (temporal != null)
            {
                Console.WriteLine($" \nCod: {temporal.Codigo} | Nom: {temporal.Nombres} | Edad: {temporal.Edad} | Correo: {temporal.Correo}");
                Console.WriteLine(" Curso\t\tN1\tN2");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"{temporal.Notas[i, 0]}\t{temporal.Notas[i, 1]}\t{temporal.Notas[i, 2]}");
                }
                temporal = temporal.Siguiente;
            }
        }
        public static void ContarAlumnos()
        {
            int contador = 0;
            Alumno temporal = cabecera;
            while (temporal != null)
            {
                contador++;
                temporal = temporal.Siguiente;
            }
            Console.WriteLine($" Total de alumnos registrados: {contador}");
        }
    }
}
