namespace HierarquiaLista;

public class ListaNaoOrdenada : ILista
{
    private List<string> _itens = new();
    private IImpressoraLista _impressora;

    public ListaNaoOrdenada(IImpressoraLista impressora)
    {
        _impressora = impressora;
    }

    public void Adicionar(string s)
    {
        _itens.Add(s);
    }

    public void Imprimir()
    {
        _impressora.Imprimir(_itens);
    }
}