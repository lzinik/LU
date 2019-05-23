using System;

class Factura : DocumentoLegal
{
    public Factura(int numero) : base(numero)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Soy la FC: " + this.GetNumero());
    }
    public void Pagar()
    {
        Console.WriteLine("Factura.Pagar");
    }
}

class FacturaExportacion : Factura
{
    public String Pais { get; set; }
    public FacturaExportacion(int numero) : base(numero){}

    public override void Imprimir() // Como FacturaExportacion hereda de Factura, no necesita implementar la func. Imprimir
    {
        Console.WriteLine("Soy la FC-E: " + this.GetNumero());
    }
}