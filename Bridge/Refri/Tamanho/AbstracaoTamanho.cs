namespace Refri.Tamanho;

public abstract class AbstracaoTamanho
{
    protected IImplementacaoRefrigerante Refrigerante;

    protected AbstracaoTamanho(IImplementacaoRefrigerante refrigerante)
    {
        Refrigerante = refrigerante;
    }

    public abstract void Beber();
}