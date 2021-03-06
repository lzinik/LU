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
class Lista<TIPO> where TIPO : DocumentoLegal  // Solo acepta TIPO que deriven de DocumentoLegal
{
    private TIPO[] lista;
    public Lista(TIPO[] miLista){
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

class ListaDeFacturas
{
    private Factura[] lista;
    public ListaDeFacturas(Factura[] miLista){
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