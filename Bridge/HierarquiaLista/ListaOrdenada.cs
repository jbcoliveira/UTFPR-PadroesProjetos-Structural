namespace HierarquiaLista;

public class ListaOrdenada : ILista
{
    private List<string> _itens = new();
    private IImpressoraLista _impressora;

    public ListaOrdenada(IImpressoraLista impressora)
    {
        _impressora = impressora;
    }

    public void Adicionar(string s)
    {
        _itens.Add(s);
    }

    public void Imprimir()
    {
        _itens.Sort();
        _impressora.Imprimir(_itens);
    }
}