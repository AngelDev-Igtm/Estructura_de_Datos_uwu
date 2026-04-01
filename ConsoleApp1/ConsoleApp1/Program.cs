using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public class CRUD
        {
            public Nodo cabecera = null;
            public Nodo listita() 
            {
                Nodo list = cabecera;
                return list;
            } 
            public void InsertarInicio(int valor)
            { 
                Nodo nuevo = new Nodo();
                nuevo.dato = valor;
                nuevo.siguiente = cabecera;
                cabecera = nuevo;
            }
            public void Mostrar() 
            { 
               Nodo temporal = cabecera;
                while (temporal != null) 
                { 
                    Console.WriteLine(temporal.dato + "\t");
                    temporal = temporal.siguiente;
                }
            }
            public void Actualizar(int v_actual, int v_nuevo) 
            {
                Nodo temporal = cabecera;
                while ( temporal  !=null)
                {
                    if (temporal.dato == v_actual) 
                    { 
                    temporal.dato=v_nuevo;
                        break;

                    }
                    temporal = temporal.siguiente;
                }
            }
            public void Burbuja()
            {
                Nodo temp1 = cabecera;
                Nodo temp2 = cabecera;
                while (temp1 != null) 
                {
                    while (temp2.siguiente != null)
                    {
                        int v1 = temp2.dato;
                        int v2= temp2.siguiente.dato;
                        if (v2 < v1) 
                        {
                            int aux = v1;
                            v1 = v2;
                            v2 = aux;
                        }
                        temp2.dato = v1;
                        temp2.siguiente.dato = v2;
                        temp2 = temp2.siguiente;
                    }
                    temp2 = cabecera;
                    temp1 = temp1.siguiente;
                }
            }
            public void UnirListas( Nodo lista, Nodo lista2) 
            {
                Nodo temp = lista;
                while (temp.siguiente != null) 
                { 
                    temp = temp.siguiente;
                }
                temp.siguiente = lista2;
                lista2 = null;
                cabecera = lista;
            }
           
            
        }
        static void Main(string[] args)
        {
            int valoractualizar, valoraremplazar;
            Console.WriteLine(" Método de Inserción de Datos");
            CRUD lista = new CRUD();
            lista.InsertarInicio(12);
            lista.InsertarInicio(20);
            lista.InsertarInicio(32);
            lista.InsertarInicio(05);
            lista.Mostrar();
            Console.WriteLine(" Ingrese Dato a Actualizar");
            valoractualizar = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese Dato a Remplazar");
            valoraremplazar = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nueva Lista");
            lista.Actualizar(valoractualizar, valoraremplazar);
            lista.Mostrar();
            Console.WriteLine(" Lista ordenada Burbuja");
            lista.Burbuja();
            lista.Mostrar();
            Console.WriteLine(" Nueva lista \t");
            CRUD lista2 = new CRUD();
            lista2.InsertarInicio(12);
            lista2.InsertarInicio(2);
            lista2.InsertarInicio(30);
            lista2.InsertarInicio(60);
            lista2.Mostrar();
            CRUD lista3 = new CRUD();
            lista3.UnirListas(lista.listita(), lista2.listita());
            Console.WriteLine(" Nueva Lista 3");
            lista3.listita();
            lista3.Mostrar();
        }
    }
}
