using System;
using System.IO;

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
            Archivo archivo = new Archivo();
            archivo.LeerArchivo();
            // archivo.EscribirArchivo();
            // archivo.LeerArchivo();
            // archivo.ModificarArchivo();
        }
    }
}