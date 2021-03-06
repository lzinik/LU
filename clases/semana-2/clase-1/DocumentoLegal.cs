using System;

interface Imprimible
{
    void Imprimir();
}

interface Grabable
{
    void Grabar();
}

abstract class MiClaseBase
{
    public abstract void Imprimir();
}
abstract class DocumentoLegal : MiClaseBase, Imprimible, Grabable
{
    private int Numero;
    private int codEnBaseDeDatos;
    protected int fechaAlta;
    
    public int Monto { get; set; }

    //public override void Imprimir()
    //{
    //    Console.WriteLine("Soy un DL: " + GetNumero());
    //}
    void Imprimible.Imprimir()
    {
        try
        {
            Grabar();
        }catch
        {
            Console.WriteLine("no puedo grabar");
            // throw; Vuelve a mandar la excepcion.
        }

        if ( true /* NO HAY PAPEL */) {
            throw new NoHayPapelException();
        } else if ( true /* NO HAY TINTA */) {
            throw new Exception();
        } else if ( true /* impresora apagada */) {
            throw new Exception();
        }
    }
    
    public void Grabar()
    {
        throw new Exception();
    }

    // Las diferencias entre abstract y virtual:
    // Abstract obliga a que todas las clases heredadas tengan cierto metodo,
    // por ejemplo imprimir
    // Virtual permite que una clase heredada, cambie el comportamiento de una funcion.

    public DateTime Fecha{ 
        get{
            return Fecha;
        }
        private set{
            Fecha = value;
        }
    }

    public int Edad{ get; set; }

    public int GetNumero()
    {
        return Numero;
    }
    protected void SetNumero(int numero)
    {
        this.Numero = numero;
    }

    protected static void Hacer()
    { 
    }

    public DocumentoLegal(int numero)
    {
        this.Numero = numero;
    }
    public void Enviar()
    {
        Console.WriteLine("DocumentoLegal.Enviar");
    }

    private void GuardarEnBaseDeDatos()
    {
        Console.WriteLine("DocumentoLegal.GuardarEnBaseDeDatos");
    }
}

class ListaDeDocumentoLegal
{
    private DocumentoLegal[] lista;
    public ListaDeDocumentoLegal(DocumentoLegal[] miLista){
        this.lista = miLista;
    }

    public int Total()
    {
        int total = 0;
        for(var f = 0; f < lista.Length; f++){
            total += lista[f].Monto;
        }
        return total;
    }
}