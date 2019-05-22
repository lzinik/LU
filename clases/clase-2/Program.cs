using System;

namespace clase_2
{
    enum TipoEmpleado {
        Empleado, LU, Contratado
    }
    struct Persona
    {
        public string Nombre;
        public string Apellido;
        public long Sueldo;

        public TipoEmpleado Tipo;
    }

    class Program
    {
        static void ImprimirPersona(Persona p) {
            Console.WriteLine("Nombre: " + p.Nombre + " Apellido: " + p.Apellido + " Sueldo: " + p.Sueldo);
        }
        static void ImprimirSiEsPar(int transferencia){
            if (0 == (transferencia % 2) )
                Console.WriteLine (transferencia + " es par.");
            else
                Console.WriteLine (transferencia + " es impar.");
        }

        static int Suma(int a, int b){
            return a + b;
        }
        
        static int Suma(int a, int b, int c){
            return a + b + c;
        }

        static double Suma(double a, double b, double c){
            return a + b + c;
        }

        static int Suma(params int[] a){ //Se utiliza params
            int suma = 0;
            for ( int idx = 0; idx < a.Length; idx++)
            {
                suma += a[idx];
            }
            return suma;
        }

        static int HacerAlgo(int a, int b, out int capricho)
        {
            capricho = 0;
            return 0;
        }

        static int Sumatoria(int numero)
        {
            // Usando ternario
            return (numero == 0) ? 0 : numero + Sumatoria(numero-1);

            // Usando if
            //if(numero == 0)
            //{
            //    return 0;
            //} else {
            //    return numero + Sumatoria(numero - 1);
            //}

            // Iterando
            //int sumatoria = 0;
            //for (int num = numero; num != 0; num--)
            //{
            //   sumatoria += num;
            //}
            //return sumatoria;
        }

        static int Division(int a, int b){
            
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

            Console.WriteLine(5 / 2);


            int sueldo = 101;
            int empleados = 4;
            int transferencia;
            int[] sueldos = new int[10];

            transferencia = sueldo * empleados;

            int c = Suma(1, Suma(2, 3));
            
            int cap;
            var r = HacerAlgo(1, 2, out cap);

            var sumatoria = Sumatoria(3);

            ImprimirSiEsPar(1);
            ImprimirSiEsPar(2);
            ImprimirSiEsPar(3);
            ImprimirSiEsPar(transferencia);
            Console.WriteLine("Monto: " + transferencia);

            Persona p = new Persona();
            p.Nombre = "Luciano";
            p.Apellido = "Zinik";
            p.Sueldo = 100;
            p.Tipo = TipoEmpleado.LU;

            var otraP = new Persona{
                Nombre = "Luciano",
                Apellido = "Zinik",
                Sueldo = 100,
                Tipo = TipoEmpleado.LU
            };
            ImprimirPersona(p);

            if (otraP.Tipo == TipoEmpleado.Contratado){

            }

        }
    }
}
