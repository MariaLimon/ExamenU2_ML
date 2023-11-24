using ExamenU2_ML.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2_ML.Clases
{
    public class ListaSimple
    {
        Nodo primero;
        Nodo ultimo;

        

        public void InsertarLista(Persona personaAgregada)
        {
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(personaAgregada);
            }
            else
            {
                primero = new Nodo(personaAgregada,primero);
            }
        }
        //public void InsertarListaFinal(Persona personaAgregada)
        //{
        //    if (ListaVacia())
        //    {
        //        primero = ultimo = new Nodo(personaAgregada);
        //    }
        //    else
        //    {
        //        ultimo = new Nodo(personaAgregada, ultimo);
        //    }
        //}


        public void BuscarLista(string personaBuscar)
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                int contador =0;
                while (actual != null)
                {
                    if(personaBuscar == actual.PersonaDatos.Nombre)
                    {
                        Console.WriteLine($"esta en la lista en la posicion {contador}");
                        break;
                    }
                    else
                    {
                        contador++;
                        actual = actual.Siguiente;
                        
                    }
                }
                Console.WriteLine($"La persona {personaBuscar} No esta en la lista");
            }
        }

        public bool ListaVacia()
        {
            if (primero == null)
                return true;
            return false;
        }
        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primero; 
                while(actual != null)
                {
                    Console.WriteLine($" el nombre es: {actual.PersonaDatos.Nombre} y la edad es: {actual.PersonaDatos.Edad}");
                    actual = actual.Siguiente;
                }
                Console.WriteLine("-> null");
            }
        }

        public void ordenarLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                }
            }
        }
    }
}
