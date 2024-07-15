namespace Numero;

public class ChavesDecorator : NumeroDecorator
{
    public ChavesDecorator(INumero numero) : base(numero) { }

    public override void Imprimir()
    {
        Console.Write("{");
        base.Imprimir();
        Console.Write("}");
    }
}