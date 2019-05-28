using System;

namespace ej2
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}