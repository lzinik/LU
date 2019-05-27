using System;
using System.IO;

namespace ej2
{
    class Program
    {
        private const string FILE_NAME = "Aga.txt";
        static void Main(string[] args)
        {
            /* Consigna:
             Hacer un programa que escriba en un archivo de texto un listado de personas y telefonos

             El programa tiene que tambien poder leer el archivo y cargarlo en una coleccion.

             Si modifico el archivo, tengo que poder leerlo nuevamente.
            */
            try {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(FILE_NAME))
                {
                    string lines;

                    while (sr.Peek() > -1)
                    {
                            lines = sr.ReadLine();
                            Console.WriteLine(lines);
                    }
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                }
            } catch (Exception e) {
                // Let the user know what went wrong.
                Console.WriteLine("Error al leer el archivo:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

            // Escribir archivo.

            string[] names = new string[] {"Zara Ali", "Nuha Ali"};
         
            using (StreamWriter sw = new StreamWriter("names.txt")) {

                foreach (string s in names) {
                sw.WriteLine(s);
                }
            }
            
            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt")) {
                while ((line = sr.ReadLine()) != null) {
                Console.WriteLine(line);
                }
            }
            Console.ReadKey();

            // Seguir leyendo el archivo: https://www.tutorialspoint.com/csharp/csharp_text_files.htm
            //                            https://stackoverflow.com/questions/4672887/c-sharp-equivalent-to-ifstream-ofstream-in-c
        }
    }
}