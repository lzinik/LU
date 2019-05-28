using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ej2
{
    class Archivo
    {
        private const string nombreArchivo = "Agenda.txt";
        public void LeerArchivo()
        {
            Dictionary<string, Persona> agenda = new Dictionary<string, Persona>();
            Persona p1 = new Persona("Martin", "15-5580-7442");
            Persona p2 = new Persona("Tomas", "15-4782-1535");
            Persona p3 = new Persona("Damian", "15-3535-2691");

            agenda.Add(p1.Nombre, p1);
            
            try
            {
                StreamReader sr = new StreamReader(nombreArchivo);                
                string line;
                
                int count = 0;

                while ( ( line = sr.ReadLine() ) != null)
                {
                    string[] splitLine = line.Split(':');
                    
                    Persona p = new Persona($"{splitLine[0]}", $"{splitLine[1]}");
                    agenda.Add(p.Nombre, p);

                    Console.WriteLine(line);
                    line = sr.ReadLine();

                    count ++;
                }
                
                sr.Close();
                Console.ReadLine();
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void EscribirArchivo()
        {
            try
            {
                

                // File.AppendAllText(@fileName, $"{nombre}" + $"{telefono}" + Environment.NewLine);

                Console.WriteLine("Luciano Zinik");



                //         Console.WriteLine("Escriba el nombre a agendar");
                //         String nombre = Console.ReadLine();
                //         sw.Write(nombre);

                //         Console.WriteLine("Escriba el telefono");
                //         String telefono = Console.ReadLine();
                //         dic.Add(nombre, telefono);
                //         sw.Write(telefono);
                //     }
                //     sw.Close();
                // }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public void ModificarArchivo()
        {
            var dic = new Dictionary<string, string>();            
        }
    }
}