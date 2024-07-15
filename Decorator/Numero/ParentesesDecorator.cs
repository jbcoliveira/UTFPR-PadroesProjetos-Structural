namespace Numero;

public class ParentesesDecorator : NumeroDecorator
{
    public ParentesesDecorator(INumero numero) : base(numero) { }

    public override void Imprimir()
    {
        Console.Write("(");
        base.Imprimir();
        Console.Write(")");
    }
}