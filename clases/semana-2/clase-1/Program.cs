using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            if (b == 0)
                return 0; //Manejar excepcion
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


            int sueldo = 101;
            int empleados = 4;
            int transferencia;
            int[] sueldos = new int[10];

            transferencia = sueldo * empleados;

            int c = Suma(1, Suma(2, 3));
            
            int cap;
            var r = HacerAlgo(1, 2, out cap);

            var sumatoria = Sumatoria(3);

            //ImprimirSiEsPar(1);
            //ImprimirSiEsPar(2);
            //ImprimirSiEsPar(3);
            //ImprimirSiEsPar(transferencia);
            //Console.WriteLine("Monto: " + transferencia);

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
            //ImprimirPersona(p);

            if (otraP.Tipo == TipoEmpleado.Contratado){

            }

            var fc = new Factura(1);
            var nc = new NotaDeCredito(1);
            var nc2 = new NotaDeCredito(2);

            nc.Imprimir();
            nc2.Imprimir();
            bool si = (fc is Factura);
            si = (fc is DocumentoLegal);

            var facturas = new Factura[3];
            facturas[0] = new Factura(1);
            facturas[1] = new Factura(2);
            facturas[2] = new Factura(3);

            ListaDeFacturas listaF = new ListaDeFacturas(facturas);
            listaF.Total();
            var lista = new Lista<DocumentoLegal>(null);

            var list = new List<DocumentoLegal>();

            list.Sort(new CompraradorMontoDL());

            var dic = new Dictionary<string, Factura>();
            dic.Add("lagash#1", new Factura(1));
            dic.Add("lagash#2", new Factura(2));
            var fact = dic["lagash#1"];

            list.Add(facturas[0]);

            HacerAlgoConDocumentos(nc);
            HacerAlgoConDocumentos(fc);

            Func<int, int> f = delegate(int i) {
                return i + 1;
            };
            f(4);

            Func<DocumentoLegal, bool> siEsPar = delegate(DocumentoLegal dl){
                return (dl.Monto % 2) == 0;
            };
            list.Where(siEsPar);

            list.Where(delegate(DocumentoLegal dl){
                return (dl.Monto % 2) == 0;
            });

            list.Where( (dl) => (dl.Monto % 2) == 0 );


            Func<int, int, int> f1 = delegate(int i, int j ) {
                return i + 1;
            };
            Func<int> f2 = delegate() {
                return 1;
            };

            object algo = (DocumentoLegal)fc;
            algo = nc;
            algo = "Diego";
            algo = 3;

            var nnc = NotaDeCredito.LeerDeBaseDeDatos();
            NotaDeCredito onc = null;
            HacerAlgoConDocumentos(onc);
            
            try{
                onc.Imprimir();
            }catch(NoHayPapelException){
                Console.WriteLine("Comprar papel.");
            }catch{
                Console.WriteLine("Seguí participando.");
            }

            Dictionary<int, string> ds = new Dictionary<int, string>();
            ds.Add(1, "Luciano");
            ds.Add(2, "Julian");
            ds.Add(9, "Martin");
            string s = ds[9];

            DateTime fecha = new DateTime(2019, 2, 28);
            fecha.AddDays(1);

            List<string> nombres = new List<string>();
            nombres.Add("Luciano");
            nombres.Add("Diego");
            nombres.Add("Martin");

            for( int idx = 0; idx < nombres.Count; idx++)
            {
                var nom = nombres[idx];
                Console.WriteLine(nom);
            }
            foreach(var nom in nombres.Where( (nn) => nn[0] == 'D' ))
            {
                Console.WriteLine(nom);
            }

            // Ejercicio:
            // Hagan un programa que escriba en un archivo de texto
            // un listado de personas y telefonos

            // El programa tiene que tambien poder leer el archivo y cargarlo en una coleccion
            // Si modifico el archivo, tengo que poder leerlo nuevamente.

        }

        static void HacerAlgoConDocumentos(DocumentoLegal dl)
        {
            dl.Imprimir();
        }
    }
}

class CompraradorMontoDL : IComparer<DocumentoLegal>
{
    public int Compare(DocumentoLegal x, DocumentoLegal y)
    {
        if(x.Monto > y.Monto) return -1;
        if(x.Monto < y.Monto) return 1;
        return 0;
    }
}

class NoHayPapelException : Exception
{
    
}