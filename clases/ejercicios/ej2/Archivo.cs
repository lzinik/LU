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
            using (StreamWriter sw = new StreamWriter(nombreArchivo, true))
            {
                try
                {
                    foreach(KeyValuePair<string, Contacto> contacto in agenda)
                    {
                        string linea = string.Format("Nombre: {0} Telefono{1}", contacto.Value.Nombre, contacto.Value.Telefono);
                        sw.WriteLine(linea);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }
        public void ModificarArchivo(Contacto contacto, string cambio)
        {
            StreamReader reader = new StreamReader(nombreArchivo);
            string input = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(nombreArchivo, true))
            {
                {
                    if (contacto.Nombre != null)
                    string output = input.Replace(word, cambio);
                    writer.Write(output);                     
                }
                writer.Close();
            }
        }
    }
}