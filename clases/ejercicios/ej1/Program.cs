﻿using System;

namespace ej1
{
    class Program
    {
        static int DivisionRecursiva(int dividendo, int divisor){
            if (divisor == 0)
                throw new DivideByZeroException();
            else if (divisor == 1)
                return dividendo;
            else
                return (dividendo >= divisor) ? DivisionRecursiva(dividendo-divisor, divisor) + 1 : 0;
        }
        static int DivisionIterativa(int dividendo, int divisor){
            if (divisor == 0)
                throw new DivideByZeroException();
            else if (divisor == 1)
                return dividendo;
            else {
                int div = 0;
                for (int i = divisor; i <= dividendo; i+=divisor)
                {
                    div++;
                }
                return div;
            }
        }

        static void Main(string[] args)
        {
            // Ejercicio para el hogar
            // Hacer una funcion Division()
            // que divida dos numeros enteros
            // SIN USAR EL OPERADOR /
            // Un hongo -> con una iteracion
            // Dos hongos -> recursivo

            // Pruebas DivisionIterativa
            var divideIte1 = DivisionIterativa(4, 2);
            Console.WriteLine("Division iterativa: " + divideIte1);
            var divideIte2 = DivisionIterativa(5, 2);
            Console.WriteLine("Division iterativa: " + divideIte2);
            var divideIte3 = DivisionIterativa(5, 6);
            Console.WriteLine("Division iterativa: " + divideIte3);
            var divideIte4 = DivisionIterativa(5, 1);
            Console.WriteLine("Division iterativa: " + divideIte4);

            // Pruebas DivisionRecursiva
            var divideRec1 = DivisionRecursiva(4, 2);
            Console.WriteLine("Division recursiva: " + divideRec1);
            var divideRec2 = DivisionRecursiva(5, 2);
            Console.WriteLine("Division recursiva: " + divideRec2);
            var divideRec3 = DivisionRecursiva(5, 6);
            Console.WriteLine("Division recursiva: " + divideRec3);
            var divideRec4 = DivisionRecursiva(5, 0);
            Console.WriteLine("Division recursiva: " + divideRec4);
        }
    }
}
