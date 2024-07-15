namespace HierarquiaLista;

public class ImpressoraNumerada : IImpressoraLista
{
    public void Imprimir(List<string> itens)
    {
        for (int i = 0; i < itens.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {itens[i]}");
        }
    }
}