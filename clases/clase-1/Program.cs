using System;

namespace clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un Array de 10 posiciones
            // imprimir la suma de las 10
            // posiciones.
            // Si es divisible por 3, mencionarlo

            int[] elems = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 15}; // Es divisible por 3
            //int[] elems = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // !(Es divisible por 3)
            int suma = 0;

            for(int i=0; i< elems.Length; i++)
                suma += elems[i];

            if ((suma % 3) == 0)
                Console.WriteLine("Es divisible por 3");
            


            int sueldo = 101;
            int empleados = 4;
            int transferencia;
            int[] sueldos = new int[5];

            sueldos[0] = 100;
            sueldos[1] = 200;
            transferencia = empleados * sueldo;

            if (0 == (transferencia % 2 ))
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");

            Console.WriteLine("Monto: " + transferencia);
        }
    }
}
