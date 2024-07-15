namespace HierarquiaLista;

public class ImpressoraLetras : IImpressoraLista
{
    public void Imprimir(List<string> itens)
    {
        for (int i = 0; i < itens.Count; i++)
        {
            Console.WriteLine($"{(char)('A' + i)}. {itens[i]}");
        }
    }
}