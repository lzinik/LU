using System;

class NotaDeCredito : DocumentoLegal
{
    public NotaDeCredito(int numero) : base(numero)
    {
    }
    public override void Imprimir()
    {
        Console.WriteLine("Soy la NC: " + this.GetNumero()); // no es necesario el this.
    }

    static public NotaDeCredito LeerDeBaseDeDatos()
    {
        return new NotaDeCredito(3);
    }
}

class ListaDeNotaDeCredito
{
    private NotaDeCredito[] lista;
    public ListaDeNotaDeCredito(NotaDeCredito[] miLista){
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