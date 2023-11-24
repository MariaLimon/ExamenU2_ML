using ExamenU2_ML.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2_ML.Clases
{
    internal class Nodo
    {
        private Persona _persona;
        private Nodo? _siguiente;

        public Nodo(Persona persona)
        {
            _persona = persona;
            _siguiente = null;
        }

        public Nodo(Persona persona, Nodo siguiente)
        {
            _persona = persona;
            _siguiente = siguiente;
        }

        public Persona PersonaDatos
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
