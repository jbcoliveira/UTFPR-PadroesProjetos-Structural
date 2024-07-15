namespace Numero;

public class ColchetesDecorator : NumeroDecorator
{
    public ColchetesDecorator(INumero numero) : base(numero) { }

    public override void Imprimir()
    {
        Console.Write("[");
        base.Imprimir();
        Console.Write("]");
    }
}