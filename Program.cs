using ExamenU2_ML.Clases;
using ExamenU2_ML.Modelo;

namespace ExamenU2_ML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona persona1 = new Persona("peruaba", 52);
            Persona persona2 = new Persona("prueba2" , 89);
            Persona persona3 = new Persona("prueba3", 89);
            Persona persona4 = new Persona("prueba4", 89);

            ListaSimple lista = new ListaSimple();
            lista.InsertarLista(persona1);
            lista.InsertarLista(persona2);
            lista.InsertarLista(persona3);
            lista.InsertarLista(persona4);
            
           
            
            lista.ImprimirLista();

            string nombre = "prueba552";
            lista.BuscarLista(nombre);
        }
    }
}