using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ej2
{
    class Archivo
    {
        private const string nombreArchivo = "Agenda.txt";
        public void LeerArchivo(Dictionary<string, Contacto> agenda)
        {
            try
            {
                // StreamReader sr = new StreamReader(nombreArchivo);
                string[] lineas = File.ReadAllLines(nombreArchivo);
                
                foreach(string linea in lineas)
                {
                    string[] splitLine = linea.Split(':');
                    Contacto c = new Contacto($"{splitLine[0]}", $"{splitLine[1]}");
                    agenda.Add(c.Nombre, c);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }
        }

        static public void EscribirArchivo(Dictionary<string, Contacto> agenda)
        {
            try
            {
                foreach(Contacto contacto in agenda)
                {
                    string linea = string.Format("Nombre: {0} Telefono{1}", contacto.Nombre, contacto.Telefono);
                }
                
                

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