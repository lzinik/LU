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