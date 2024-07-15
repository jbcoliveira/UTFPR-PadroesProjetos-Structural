namespace Refri.Tamanho;

public class TamanhoPequeno : AbstracaoTamanho
{
    public TamanhoPequeno(IImplementacaoRefrigerante refrigerante) : base(refrigerante)
    {
    }

    public override void Beber()
    {
        Console.WriteLine("Toma um gole de " + Refrigerante);
        Console.WriteLine("Acabou o(a) " + Refrigerante);
        Console.WriteLine();
    }
}