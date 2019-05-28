using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Consigna:
             Hacer un programa que escriba en un archivo de texto un listado de personas y telefonos

             El programa tiene que tambien poder leer el archivo y cargarlo en una coleccion.

             Si modifico el archivo, tengo que poder leerlo nuevamente.
            */

            
            Dictionary<string, Contacto> agenda = new Dictionary<string, Contacto>();
            Contacto c1 = new Contacto("Martin", "15-5580-7442");
            Contacto c2 = new Contacto("Tomas", "15-4782-1535");
            Contacto c3 = new Contacto("Damian", "15-3535-2691");

            agenda.Add(c1.Nombre, c1);

            Archivo archivo = new Archivo();
            archivo.LeerArchivo(agenda);
            // archivo.EscribirArchivo();
            // archivo.LeerArchivo();
            // archivo.ModificarArchivo();
        }
    }
}