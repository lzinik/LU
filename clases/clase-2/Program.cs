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

        static void Main(string[] args)
        {
            int sueldo = 101;
            int empleados = 4;
            int transferencia;
            int[] sueldos = new int[10];

            transferencia = sueldo * empleados;

            int c = Suma(1, Suma(2, 3));

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
