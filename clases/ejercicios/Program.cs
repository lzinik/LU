using System;

namespace clase_2
{
    class Program
    {
        static int DivisionRecursiva(int a, int b){
            if (b == 0)
                SystemException;
            else if (b == 1)
                return a;
            else
            // Recursion
                return (a > b) ? Division(a-b, b) + 1 : 0;
        }
        static int DivisionIterativa(int a, int b){
            if (b == 0)
                SystemException;
            else if (b == 1)
                return a;
            else {
                // Iteracion
                int div = 0;
                for (int i = b; i < a; i+=b)
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

            var divideIte = DivisionIterativa(5, 2);
            Console.WriteLine("Division iterativa " + divideIte);
            var divideRec = DivisionRecursiva(5, 2);
            Console.WriteLine("Division recursiva " + divideRec);
            
        }
    }
}
