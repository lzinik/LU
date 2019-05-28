using System;

namespace ej2
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}