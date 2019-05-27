using System;

namespace clase_2
{
    class Program
    {
        static int DivisionRecursiva(int a, int b){
            if (b == 0)
                throw new DivideByZeroException();
            else if (b == 1)
                return a;
            else
            // Recursion
                return (a >= b) ? DivisionRecursiva(a-b, b) + 1 : 0;
        }
        static int DivisionIterativa(int a, int b){
            if (b == 0)
                throw new DivideByZeroException();
            else if (b == 1)
                return a;
            else {
                // Iteracion
                int div = 0;
                for (int i = b; i <= a; i+=b)
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
            var divideIte4 = DivisionIterativa(5, 0);
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
