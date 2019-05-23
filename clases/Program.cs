using System;

namespace clase_2
{
    class Program
    {
        static int Division(int a, int b){
            if (b == 0)
                SystemException;
            else if (b == 1)
                return a;
            else
            // Iteracion
            //int div = 0;
            //for (int i = b; i < a; i+=b)
            //{
            //   div++;
            //}
            //return div;

            // Recursivo
            return (a > b) ? Division(a-b, b) + 1 : 0;
        }

        static void Main(string[] args)
        {
            // Ejercicio para el hogar
            // Hacer una funcion Division()
            // que divida dos numeros enteros
            // SIN USAR EL OPERADOR /
            // Un hongo -> con una iteracion
            // Dos hongos -> recursivo

            var divide = Division(5, 2);
            Console.WriteLine(divide);
        }
    }
}
