namespace Numero;

public abstract class NumeroDecorator : INumero
{
    protected INumero Numero;

    public NumeroDecorator(INumero numero)
    {
        Numero = numero;
    }

    public virtual void Imprimir()
    {
        Numero.Imprimir();
    }
}