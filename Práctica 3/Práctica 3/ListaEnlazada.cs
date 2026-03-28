using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_3
{
    public class ListaEnlazada
    {
        private Nodo primero;
        public void Agregar (string nombre)
        {
            Nodo nuevoNodo = new Nodo { Nombre = nombre, Siguiente = null };
            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }
        //no pueden estar juntos los dos métodos Agregar, por eso se sobrecarga el método,
        //uno recibe un string y el otro no recibe nada, pero ambos se llaman Agregar

        public void Agregar()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Agregar(nombre);
        }
        public void Mostrar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Nombre);
                actual = actual.Siguiente;
            }
        }
        public bool Eliminar(string nombre)
        {
            Nodo temporal = primero;
            Nodo anterior = null;
            while (temporal != null)
            { 
                if (temporal.Nombre == nombre)
                {
                    if (temporal == primero)
                    {
                        // si el nodo a eliminar es el primero, actualizar la referencia "primero"
                        primero = temporal.Siguiente;
                    }
                    else 
                    {
                        anterior.Siguiente = temporal.Siguiente;
                    }
                    return true;
                }
                anterior = temporal;
                temporal = temporal .Siguiente;
            }
            return false;
        }
    }
}
