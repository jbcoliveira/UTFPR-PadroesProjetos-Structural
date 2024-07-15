namespace Refri.Tamanho;

public class TamanhoGrande : AbstracaoTamanho
{
    public TamanhoGrande(IImplementacaoRefrigerante refrigerante) : base(refrigerante)
    {
    }

    public override void Beber()
    {
        Console.WriteLine("Toma um gole de " + Refrigerante);
        Console.WriteLine("Toma um gole de " + Refrigerante);
        Console.WriteLine("Toma um gole de " + Refrigerante);
        Console.WriteLine("Acabou o(a) " + Refrigerante);
        Console.WriteLine();
    }
}